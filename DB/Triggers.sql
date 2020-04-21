
---------------------TriggerByClinentInsert--------------------------------
CREATE TRIGGER [dbo].[CheckInsertClient]
   ON  [dbo].[Client]
   INSTEAD OF INSERT
AS 
BEGIN
DECLARE @FirstName VARCHAR(50)
DECLARE @LastName VARCHAR(50)
DECLARE @MiddleName VARCHAR(50)
DECLARE @SubscriptionNumber numeric(6) = 100000
DECLARE @IDCoach INT
DECLARE @ChekCoach INT = 0

SET @FirstName = (SELECT FirstName FROM inserted);
SET @LastName = (SELECT LastName FROM inserted);
SET @MiddleName = (SELECT MiddleName FROM inserted);
SET @IDCoach = (SELECT IDCoach FROM inserted);

IF EXISTS (SELECT IDCoach FROM inserted WHERE IDCoach IS NOT NULL)
	BEGIN
		PRINT @ChekCoach
		SET @ChekCoach = 0
	END
ELSE 
	BEGIN
		PRINT 'Тренер отсуствует в записи , запись добавлена без тренера '
		SET @IDCoach = NULL
		SET @SubscriptionNumber = 100000 + IDENT_CURRENT('Client');
		INSERT INTO Client(FirstName,LastName,MiddleName,SubscriptionNumber,IDCoach)
		VALUES (@FirstName,@LastName,@MiddleName,@SubscriptionNumber,@IDCoach)
		PRINT 'Клиент добавлен его ID:' + CAST(IDENT_CURRENT('Client') as VARCHAR) + char(10) +'Номер абонимента:'+ CAST(@SubscriptionNumber as NVARCHAR);
		RETURN
	END
IF
(
	((LEN(@FirstName) < 2) OR (LEN(@FirstName) < 2) OR (LEN(@MiddleName) < 2))
	OR
	((LEN(@FirstName) > 30) OR (LEN(@FirstName) > 30) OR (LEN(@MiddleName) > 30))
)
BEGIN
	PRINT 'ФИО не должны быть меньше 2 символов и больше 30'
END	
ELSE 
BEGIN
	DECLARE @IdAddClient INT

	
	IF EXISTS
	(
		SELECT ID,LastName,FirstName FROM Coach
		WHERE (@IDCoach = ID)
	)
	BEGIN
		PRINT @ChekCoach
		SET @ChekCoach = 1
	END

	PRINT @ChekCoach


	IF (@ChekCoach = 1)
	BEGIN
		PRINT 'Клиент добавлена с тренером'
		SET @SubscriptionNumber = 100000 + IDENT_CURRENT('Client');
		INSERT INTO Client(FirstName,LastName,MiddleName,SubscriptionNumber,IDCoach)
		VALUES (@FirstName,@LastName,@MiddleName,@SubscriptionNumber,@IDCoach)
				
		PRINT 'Клиент добавлен его ID:' + CAST(IDENT_CURRENT('Client') as VARCHAR) + char(10) +'Номер абонимента:'+ CAST(@SubscriptionNumber as NVARCHAR);
	END 

	ELSE IF (@ChekCoach = 0)
	BEGIN
		SET @IDCoach = NULL
		PRINT 'Такого тренера нет, клиент добавлен без тренера '
		SET @SubscriptionNumber = 100000 + IDENT_CURRENT('Client');
		INSERT INTO Client(FirstName,LastName,MiddleName,SubscriptionNumber,IDCoach)
		VALUES (@FirstName,@LastName,@MiddleName,@SubscriptionNumber,@IDCoach)
				
		PRINT 'Клиент добавлен его ID:' + CAST(IDENT_CURRENT('Client') as VARCHAR) + char(10) +'Номер абонимента:'+ CAST(@SubscriptionNumber as NVARCHAR);
	END

END	
END	


GO


---------------------TriggerByCoachInsert--------------------------------
CREATE TRIGGER CheckInsertCoach
   ON  Coach
   INSTEAD OF INSERT
AS 
BEGIN
DECLARE @FirstName VARCHAR(50)
DECLARE @LastName VARCHAR(50)
DECLARE @MiddleName VARCHAR(50)
DECLARE @Phone BIGINT

SET @FirstName = (SELECT FirstName FROM inserted);
SET @LastName = (SELECT LastName FROM inserted);
SET @MiddleName = (SELECT MiddleName FROM inserted);
SET @Phone = (SELECT Phone FROM inserted);

IF
(
	((LEN(@FirstName) < 2) OR (LEN(@FirstName) < 2) OR (LEN(@MiddleName) < 2))
	OR
	((LEN(@FirstName) > 30) OR (LEN(@FirstName) > 30) OR (LEN(@MiddleName) > 30))
)
	BEGIN
		PRINT 'Инициалы не могут быть меньше 2 символов и больше 30'
	END
ELSE 
	BEGIN

		IF(LEN(CAST(@Phone as nvarchar)) > 10)
			BEGIN 
				PRINT 'Номер не может состоять больше чем из 10 символов'
			END

		ELSE IF((LEN(CAST(@Phone as nvarchar)) < 5))
			BEGIN
				PRINT 'Номер не может состоять меньше чем из 5 символов'
			END
		ELSE IF (@Phone < 0)
			BEGIN
				PRINT 'Номер не может быть отрицательным'
			END
		ELSE 
			BEGIN	
				INSERT INTO Coach(FirstName,LastName,MiddleName,Phone)
				VALUES (@FirstName,@LastName,@MiddleName,@Phone)
				PRINT 'Тренер добавлен его ID:' + CAST(IDENT_CURRENT('Coach') as VARCHAR) + char(10) +'Номер телефона:'+ CAST(@Phone as NVARCHAR);
			END
	END
END
GO

---------------------TriggerByHall--------------------------------
CREATE TRIGGER CheckInsertHall
   ON  [dbo].[Hall]
   INSTEAD OF INSERT
AS 
BEGIN
DECLARE @NameHall VARCHAR(50)
DECLARE @Description VARCHAR(50) = 'Описание отсутсвует'


SET @NameHall = (SELECT NameHall FROM inserted);
IF EXISTS (SELECT [Description] FROM inserted)
BEGIN
	SET @Description = (SELECT [Description] FROM inserted);
END


IF
(
	((LEN(@NameHall) < 2) OR (LEN(@NameHall) > 20))
)
	BEGIN
		PRINT 'Название хола не может быть меньше 2 или же больше 20 символов'
	END
ELSE IF((LEN(@Description) > 150))
	BEGIN
		PRINT 'Описание хола не может быть больше 150 символов'
	END
ELSE 

	INSERT INTO Hall(NameHall,[Description])
	VALUES (@NameHall,@Description)
		PRINT 'Зал добавлен его ID:' + CAST(IDENT_CURRENT('Hall') as VARCHAR) + char(10) +'Название:'+ CAST(@NameHall as NVARCHAR);
END
GO

---------------------TriggerByLessons--------------------------------
CREATE TRIGGER CheckInsertedLessons
   ON  Lessons
   AFTER INSERT
AS 
BEGIN
DECLARE @Count INT
DECLARE @InsTime DATETIME2
DECLARE @IdClient NVARCHAR (50)
DECLARE @InsIDCoach NVARCHAR(50)
DECLARE @InsIDHall NVARCHAR(50)

SET @InsTime = (SELECT ClassTime FROM inserted);

SET @InsIDCoach = (SELECT a.IDCoach 
		FROM (
			SELECT *
			FROM (inserted o JOIN Client c
			ON o.IDClient = c.ID)
			WHERE(IDCoach = c.IDCoach)) a
		)

SET @InsTime = (SELECT ClassTime FROM inserted);
SET @IdClient = (SELECT IDClient FROM inserted);
SET @InsIDHall = (SELECT IDHall FROM inserted);

--DEBUG
--PRINT @InsTime
--PRINT @InsIDCoach
--PRINT @IdClient

IF 
(
	(SELECT COUNT(*)
		FROM 
			(SELECT o.IDClient, o.IDHall,o.ClassTime,c.IDCoach
			FROM Lessons o JOIN Client c
			ON o.IDClient = c.ID
			WHERE(IDCoach = @InsIDCoach)) a
	 WHERE (ABS(DATEDIFF(MINUTE,a.ClassTime,@InsTime)) < 60)) > 1
)
BEGIN
	--PRINT 'Тренер занят'
	ROLLBACK TRAN
END
ELSE
	BEGIN
		--PRINT 'Тренер свободен'
		IF
		(
			(SELECT COUNT(*) 
				FROM (SELECT IDClient, IDHall,ClassTime
						FROM Lessons 
						WHERE (IDHall = @InsIDHall)
				) AllHall

				WHERE (ABS(DATEDIFF(MINUTE,AllHall.ClassTime,@InsTime)) < 60)) > 1
			)
		BEGIN 
		--PRINT 'Зал занят'
			ROLLBACK TRAN
		END
		ELSE
		BEGIN 
			--PRINT 'Зал свободен'
			IF
			(
				(SELECT COUNT(*) 
					FROM (SELECT IDClient, IDHall,ClassTime
							FROM Lessons 
							WHERE (IDClient = @IdClient)
					) AllClient

					WHERE (ABS(DATEDIFF(MINUTE,AllClient.ClassTime,@InsTime)) < 60)) > 1
			)
			BEGIN 
				--PRINT 'Клиент занят'
				ROLLBACK TRAN
			END
			--Все хорошо добавляем
			ELSE 
			BEGIN
				PRINT 'Занятие добавлено'
				--PRINT 'Клиент свободен'
			END
		END
	END
END
GO
