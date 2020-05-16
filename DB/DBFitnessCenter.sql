USE master;
GO

IF EXISTS(SELECT * FROM sys.databases WHERE name = 'FitnessCenter')
BEGIN
	DROP DATABASE FitnessCenter;
END

CREATE DATABASE FitnessCenter
GO

USE FitnessCenter
GO

CREATE TABLE dbo.Client
	(
	ID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	FirstName NVARCHAR(50) NOT NULL,
	LastName NVARCHAR(50) NOT NULL,
	MiddleName NVARCHAR(50) NOT NULL,
	SubscriptionNumber NUMERIC(6) UNIQUE  NOT NULL, 
	IDCoach INT NULL
	)
GO


CREATE TABLE dbo.Coach
	(
	ID INT PRIMARY KEY IDENTITY(1,1),
	FirstName NVARCHAR(50) NOT NULL,
	LastName NVARCHAR(50) NOT NULL,
	MiddleName NVARCHAR(50) NOT NULL,
	Phone BIGINT UNIQUE NOT NULL
	)
GO

CREATE TABLE dbo.Hall
	(
	ID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	NameHall NVARCHAR(50) UNIQUE NOT NULL,
	[Description] NVARCHAR(150) NOT NULL DEFAULT 'Описание отсутствует'
	)
GO

CREATE TABLE dbo.Lessons
	(
	IDLessons INT PRIMARY KEY IDENTITY(1,1),
	IDClient INT NOT NULL,
	IDHall INT NOT NULL,
	ClassTime DATETIME NOT NULL,
	)
GO

ALTER TABLE Client
	ADD CONSTRAINT FK_Coach_Client_ID FOREIGN KEY (IDCoach)
		REFERENCES Coach(ID)
		ON DELETE SET NULL
		ON UPDATE CASCADE
GO
ALTER TABLE Lessons
	ADD CONSTRAINT FK_Lessons_Client_ID FOREIGN KEY (IDClient)
		REFERENCES Client(ID)
		ON DELETE CASCADE
		ON UPDATE CASCADE
GO
ALTER TABLE Lessons
	ADD CONSTRAINT FK_Lessons_Hall_ID FOREIGN KEY (IDHall)
		REFERENCES Hall(ID)
		ON DELETE CASCADE
		ON UPDATE CASCADE
GO
---------------------StoredProcedures ByClient--------------------------------
CREATE PROCEDURE [dbo].[Sp_GetClients]
AS
BEGIN
     SELECT 
	 ID,
	 FirstName,
	 LastName,
	 MiddleName,
	 Cast(SubscriptionNumber AS INT) AS SubscriptionNumber,
	 IDCoach
  	 FROM Client 
END
GO


CREATE PROCEDURE [dbo].[Sp_InsertClient]

    @FirstName NVARCHAR(50),
	@LastName NVARCHAR(50),
	@MiddleName NVARCHAR(50),
	@SubscriptionNumber NUMERIC(6), --------<
	@IDCoach INT = NULL
AS
BEGIN	

	INSERT INTO Client(FirstName,LastName,MiddleName,SubscriptionNumber,IDCoach)
	VALUES (@FirstName,@LastName,@MiddleName,@SubscriptionNumber,@IDCoach)
END
GO

CREATE PROCEDURE [dbo].[Sp_UpdateCoachByClient]
	@SubscriptionNumber INT,
	@IDCoach INT = NULL
AS
BEGIN
	IF EXISTS(SELECT ID,FirstName,LastName,Phone FROM Coach WHERE @IDCoach = ID)
	BEGIN	
		IF EXISTS(SELECT ID,FirstName,LastName,SubscriptionNumber FROM Client WHERE @SubscriptionNumber = SubscriptionNumber)
		BEGIN
			DECLARE @IDClient INT
			SELECT @IDClient = ID FROM Client WHERE @SubscriptionNumber = SubscriptionNumber

			DELETE	Lessons
			WHERE @IDClient = IDClient

			PRINT 'У клиента с номером ' + CAST(@SubscriptionNumber as NVARCHAR) +' Обновлен тренер ' + 
			char(10) + 'Все занятия клиента были удалены'

			UPDATE Client SET IDCoach = @IDCoach
			FROM Client
			WHERE (@SubscriptionNumber = SubscriptionNumber)
			RETURN
		END
		ELSE 
		BEGIN
			PRINT 'Такого клиента нет'
			RETURN 
		END
	END	
	ELSE 
	BEGIN
		PRINT 'Такого тренера нет'
		RETURN
	END
END	
GO

CREATE PROCEDURE [dbo].[Sp_GetBySubNumberClient]
	@SubscriptionNumber INT
AS
BEGIN
     SELECT	ID, FirstName, LastName, MiddleName, CAST(SubscriptionNumber as INT) AS SubscriptionNumber, IDCoach
	 FROM Client
    WHERE (@SubscriptionNumber = SubscriptionNumber )
END	
GO


CREATE PROCEDURE [dbo].[Sp_GetByIdClient]
	@Id INT
AS
BEGIN
     SELECT	ID, FirstName, LastName, MiddleName, CAST(SubscriptionNumber as INT) AS SubscriptionNumber, IDCoach
	 FROM Client
    WHERE (@Id = ID )
END
GO

CREATE PROCEDURE [dbo].[Sp_DeleteClient]
	@SubscriptionNumber INT
AS
	IF EXISTS (SELECT * FROM Client WHERE @SubscriptionNumber = SubscriptionNumber)
BEGIN
	SELECT	ID, FirstName, LastName, MiddleName, CAST(SubscriptionNumber as INT) AS SubscriptionNumber, IDCoach
	FROM Client
	WHERE @SubscriptionNumber = SubscriptionNumber;

	DELETE FROM Client
	WHERE @SubscriptionNumber = SubscriptionNumber;
END

GO

CREATE PROCEDURE [dbo].[Sp_GetByLastNameClient]
	@LastName NVARCHAR(50)
AS
BEGIN
	SELECT	ID, FirstName, LastName, MiddleName, CAST(SubscriptionNumber as INT) AS SubscriptionNumber, IDCoach
	FROM Client
	WHERE (@LastName = LastName )
END
GO


---------------------StoredProcedures ByCoach--------------------------------


CREATE PROCEDURE [dbo].[Sp_InsertCoach]
    @FirstName NVARCHAR(50),
	@LastName NVARCHAR(50),
	@MiddleName NVARCHAR(50),
	@Number BIGINT
AS
BEGIN
	IF EXISTS(SELECT * FROM COACH WHERE @Number = Phone)
	BEGIN
		PRINT 'Phone_dup'
		--PRINT 'Тренер с таким номером уже существует'
		RETURN
	END
    INSERT INTO Coach(FirstName,LastName,MiddleName,Phone)
    VALUES (@FirstName,@LastName,@MiddleName,@Number)

END
GO


CREATE PROCEDURE [dbo].[Sp_DeleteCoach]
	@Number BIGINT
AS
	IF EXISTS (SELECT * FROM Coach WHERE @Number = Phone)
BEGIN
	SELECT	ID, FirstName, LastName, MiddleName, Phone--CAST(SubscriptionNumber as INT) AS SubscriptionNumber
	FROM Coach
	WHERE @Number = Phone;

	DELETE FROM Coach
	WHERE @Number = Phone;
END
GO

CREATE PROCEDURE [dbo].[Sp_GetCoachs]
AS
BEGIN
     SELECT ID
      ,FirstName
      ,LastName
      ,MiddleName
      ,Phone
  	 FROM Coach 
END
GO

CREATE PROCEDURE [dbo].[Sp_GetByIdCoach]
	@Id INT
AS
BEGIN
     SELECT	ID, FirstName, LastName, MiddleName,Phone
	 FROM Coach
     WHERE (@Id = ID )
END
GO

CREATE PROCEDURE [dbo].[Sp_GetByLastNameCoach]
	@LastName NVARCHAR(50)
AS
BEGIN
	SELECT	ID, FirstName, LastName, MiddleName,Phone
	FROM Coach
	WHERE (@LastName = LastName )
END
GO

CREATE PROCEDURE [dbo].[Sp_GetByPhoneCoach]
	@Phone BIGINT
AS
BEGIN
    SELECT	ID, FirstName, LastName, MiddleName, Phone
	FROM Coach
    WHERE (@Phone = Phone )
END
GO

---------------------StoredProcedures ByHall--------------------------------

CREATE PROCEDURE [dbo].[Sp_InsertHall]
	@Id INT OUTPUT,
    @NameHall NVARCHAR(50),
	@Description NVARCHAR(150) = NULL
AS
BEGIN
	IF EXISTS(SELECT * FROM Hall WHERE @NameHall = NameHall)
	BEGIN
		PRINT 'Зал с таким названием уже существует'
		RETURN
	END

    INSERT INTO Hall(NameHall,[Description])
    VALUES (@NameHall,@Description)

END
GO

CREATE PROCEDURE [dbo].[Sp_DeleteHall]
	@NameHall NVARCHAR(50)
AS
	IF EXISTS (SELECT * FROM Hall WHERE @NameHall = NameHall)
BEGIN
	SELECT	ID, NameHall, [Description]
	FROM Hall
	WHERE @NameHall = NameHall

	DELETE FROM Hall
	WHERE @NameHall = NameHall
END
GO

CREATE PROCEDURE [dbo].[Sp_GetHalls]
AS
BEGIN
     SELECT ID,NameHall,[Description]
  	 FROM Hall 
END
GO

CREATE PROCEDURE [dbo].[Sp_GetByIdHall]
	@Id INT
AS
BEGIN
     SELECT	ID, NameHall, [Description]
	 FROM Hall
     WHERE (@Id = ID )
END
GO

CREATE PROCEDURE [dbo].[Sp_GetByNameHall]
	@NameHall NVARCHAR(50)
AS
BEGIN
	SELECT ID,NameHall,[Description]
	FROM Hall
	WHERE (@NameHall = NameHall)
END
GO

--ALTER TABLE Lessons
--ADD CONSTRAINT UK_IDClient_CalssTime UNIQUE (IDClient,ClassTime);
--GO



CREATE PROCEDURE [dbo].[Sp_InsertLessons]
	@IdClient INT,
    @IDHall INT,
	@Time DATETIME
AS
BEGIN
	IF NOT EXISTS (SELECT * FROM Client WHERE @IdClient=ID)
	BEGIN
		PRINT 'No_such_client'
		--PRINT 'Такого клиента нет'
		RETURN
	END
	IF NOT EXISTS (SELECT * FROM Hall WHERE @IDHall=ID)
	BEGIN
		PRINT 'No_such_hall'
		--PRINT 'Такого зала нет'
		RETURN
	END
    INSERT INTO Lessons(IDClient,IDHall,ClassTime)
    VALUES (@IdClient,@IDHall,@Time)
END
GO

CREATE PROCEDURE [dbo].[Sp_DeleteLesson]
	@IDLesson INT
AS
IF EXISTS (SELECT * FROM Lessons WHERE @IDLesson = IDLessons)
	BEGIN
		SELECT	IDLessons, IDClient, IDHall, ClassTime
		FROM Lessons
		WHERE @IDLesson = IDLessons;

		DELETE FROM Lessons
		WHERE @IDLesson = IDLessons;
	END
GO

CREATE PROCEDURE [dbo].[Sp_GetAllLessonsById]
	@IDLesson INT
AS
IF EXISTS (SELECT * FROM Lessons WHERE @IDLesson = IDLessons)
	BEGIN
		SELECT	IDLessons, IDClient, IDHall, ClassTime
		FROM Lessons
		WHERE @IDLesson = IDLessons
	END
GO

CREATE PROCEDURE [dbo].[Sp_GetAllLessons]
AS
BEGIN
     SELECT IDLessons,IDClient,IDHall,ClassTime
	 FROM Lessons 

END
GO

CREATE PROCEDURE [dbo].[Sp_GetAllLessonsBySubNumClient]
	@SubNumClient INT
AS
DECLARE @IDClient INT

SET @IDClient = (
				SELECT ID 
				FROM Client
				WHERE (@SubNumClient = SubscriptionNumber)
				)
IF EXISTS (SELECT * FROM Lessons WHERE @IDClient = IDClient)
	BEGIN
		SELECT	IDLessons, IDClient, IDHall, ClassTime
		FROM Lessons
		WHERE @IDClient = IDClient
	END
GO

CREATE PROCEDURE [dbo].[Sp_GetAllLessonsByNameHall]
	@NameHall NVARCHAR(50)
AS
DECLARE @IDHall INT

SET @IDHall= (SELECT ID 
			  FROM Hall
			  WHERE (@NameHall = NameHall))

IF EXISTS (SELECT * FROM Lessons WHERE @IDHall = IDHall)
	BEGIN
		SELECT	IDLessons, IDClient, IDHall, ClassTime
		FROM Lessons
		WHERE @IDHall = IDHall;
	END
GO

CREATE PROCEDURE [dbo].[Sp_GetAllLessonsByPhoneCoach]
	@Phone BIGINT
AS
DECLARE @IDCoach INT

SET @IDCoach= (SELECT ID 
			  FROM Coach
			  WHERE (@Phone = Phone))

IF (@IDCoach IS NOT NULL)
	BEGIN
			SELECT IDLessons,IDClient, IDHall,ClassTime,IDCoach
			FROM (Lessons o JOIN Client c
			ON o.IDClient = c.ID)
			WHERE(IDCoach = @IDCoach)
	END
GO

CREATE PROCEDURE [dbo].[Sp_EmploymentHallByDate]
	@Date DATETIME2,
	@HallId INT
AS
IF NOT EXISTS (SELECT ID FROM Hall WHERE @HallId = ID)
BEGIN
	PRINT 'Такого зала нет'
	RETURN
END
SELECT IDLessons, IDClient, IDHall,ClassTime
		FROM Lessons 
		WHERE ((CAST(ClassTime AS DATE) = @Date) AND @HallId = IDHall)
GO

CREATE PROCEDURE [dbo].[Sp_EmploymentHallByDateTime]
	@Date DATETIME2,
	@HallId INT
AS
IF NOT EXISTS (SELECT ID FROM Hall WHERE @HallId = ID)
BEGIN
	PRINT 'Такого зала нет'
	RETURN
END

SELECT IDLessons, IDClient, IDHall,ClassTime
		FROM Lessons 
		WHERE ((ABS(DATEDIFF(MINUTE,@Date,ClassTime)) < 60) AND @HallId = IDHall)
GO

CREATE PROCEDURE [dbo].[Sp_EmploymentAllHallByDate]
	@Date DATETIME2
AS

SELECT IDLessons, IDClient, IDHall,ClassTime
		FROM Lessons 
		WHERE (CAST(ClassTime AS DATE) = @Date)
GO

CREATE PROCEDURE [dbo].[Sp_EmploymentAllHallByDateTime]
	@Date DATETIME2
AS

SELECT IDLessons, IDClient, IDHall,ClassTime
		FROM Lessons 
		WHERE (ABS(DATEDIFF(MINUTE,@Date,ClassTime)) < 60)
GO

