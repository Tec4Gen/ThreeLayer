
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
DECLARE @IDCoach NVARCHAR(50)
DECLARE @ChekCoach INT = 0

SET @FirstName = (SELECT FirstName FROM inserted);
SET @LastName = (SELECT LastName FROM inserted);
SET @MiddleName = (SELECT MiddleName FROM inserted);
SET @IDCoach = (SELECT IDCoach FROM inserted);

IF EXISTS (SELECT IDCoach FROM inserted WHERE IDCoach IS NOT NULL)
	BEGIN
		SET @ChekCoach = 0
	END
ELSE 
	BEGIN
		
		SET @IDCoach = NULL
		IF (SELECT COUNT(*) 
				FROM Client 
				WHERE (SubscriptionNumber = @SubscriptionNumber + IDENT_CURRENT('Client'))) = 1	
			BEGIN
				SET @SubscriptionNumber = @SubscriptionNumber + 1;
			END
		SET @SubscriptionNumber += IDENT_CURRENT('Client')
		INSERT INTO Client(FirstName,LastName,MiddleName,SubscriptionNumber,IDCoach)
		VALUES (@FirstName,@LastName,@MiddleName,@SubscriptionNumber,@IDCoach)
		PRINT '������ ���������� � ������ , ������ ��������� ��� �������'
		PRINT '������ �������� ��� ID:' + CAST(IDENT_CURRENT('Client') as VARCHAR) + char(10) +'����� ����������:'+ CAST(@SubscriptionNumber as NVARCHAR);
		RETURN
	END
IF
(
	((LEN(@FirstName) > 2) AND (LEN(@LastName) > 2) AND (LEN(@MiddleName) > 2))
	AND
	((LEN(@FirstName) < 30) AND (LEN(@LastName) < 30) AND (LEN(@MiddleName) < 30))
)
BEGIN
	DECLARE @IdAddClient INT

	IF EXISTS
	(
		SELECT ID,LastName,FirstName FROM Coach
		WHERE (@IDCoach = ID)
	)
	BEGIN
		SET @ChekCoach = 1
	END
	IF (@ChekCoach = 1)
	BEGIN
		
		IF (SELECT COUNT(*) 
				FROM Client 
				WHERE (SubscriptionNumber = @SubscriptionNumber + IDENT_CURRENT('Client'))) = 1	
			BEGIN
				SET @SubscriptionNumber = @SubscriptionNumber + 1;
			END
		SET @SubscriptionNumber += IDENT_CURRENT('Client')
		INSERT INTO Client(FirstName,LastName,MiddleName,SubscriptionNumber,IDCoach)
		VALUES (@FirstName,@LastName,@MiddleName,@SubscriptionNumber,@IDCoach)		
		PRINT '������ �������� � ��������'
		PRINT ' ��� ID:' + CAST(IDENT_CURRENT('Client') as VARCHAR) + char(10) +'����� ����������:'+ CAST(@SubscriptionNumber as NVARCHAR);
		RETURN
	END 

	ELSE IF (@ChekCoach = 0)
	BEGIN
		SET @IDCoach = NULL
		
			IF (SELECT COUNT(*) 
				FROM Client 
				WHERE SubscriptionNumber = @SubscriptionNumber + IDENT_CURRENT('Client')) = 1	
			BEGIN
				SET @SubscriptionNumber = @SubscriptionNumber + 1;
			END
		SET @SubscriptionNumber += IDENT_CURRENT('Client')
		INSERT INTO Client(FirstName,LastName,MiddleName,SubscriptionNumber,IDCoach)
		VALUES (@FirstName,@LastName,@MiddleName,@SubscriptionNumber,@IDCoach)
		PRINT '������ ������� ���, ������ �������� ��� �������'
		PRINT ' ��� ID:' + CAST(IDENT_CURRENT('Client') as VARCHAR) + char(10) +'����� ����������:'+ CAST(@SubscriptionNumber as NVARCHAR);
		RETURN
	END

END	
	
ELSE 
BEGIN
	PRINT '��� �� ������ ���� ������ 2 �������� � ������ 30'
	RETURN
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
		PRINT '�������� �� ����� ���� ������ 2 �������� � ������ 30'
	END
ELSE 
	BEGIN

		IF(LEN(CAST(@Phone as nvarchar)) > 10)
			BEGIN 
				PRINT '����� �� ����� �������� ������ ��� �� 10 ��������'
			END

		ELSE IF((LEN(CAST(@Phone as nvarchar)) < 5))
			BEGIN
				PRINT '����� �� ����� �������� ������ ��� �� 5 ��������'
			END
		ELSE IF (@Phone < 0)
			BEGIN
				PRINT '����� �� ����� ���� �������������'
			END
		ELSE 
			BEGIN	
				INSERT INTO Coach(FirstName,LastName,MiddleName,Phone)
				VALUES (@FirstName,@LastName,@MiddleName,@Phone)
				PRINT '������ �������� ��� ID:' + CAST(IDENT_CURRENT('Coach') as NVARCHAR) + char(10) +'����� ��������:'+ CAST(@Phone as NVARCHAR);
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
DECLARE @Description VARCHAR(50) = '�������� ����������'


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
		PRINT '�������� ���� �� ����� ���� ������ 2 ��� �� ������ 20 ��������'
		RETURN
	END
ELSE IF((LEN(@Description) > 150))
	BEGIN
		PRINT '�������� ���� �� ����� ���� ������ 150 ��������'
	END
ELSE 

	INSERT INTO Hall(NameHall,[Description])
	VALUES (@NameHall,@Description)
		PRINT '��� �������� ��� ID:' + CAST(IDENT_CURRENT('Hall') as VARCHAR) + char(10) +'��������:'+ CAST(@NameHall as NVARCHAR);
END

GO

---------------------TriggerByLessons--------------------------------
CREATE TRIGGER CheckInsertedLessons
  ON  [dbo].[Lessons]
  INSTEAD OF INSERT
AS 
BEGIN
DECLARE @Count INT
DECLARE @InsTime DATETIME2
DECLARE @IdClient NVARCHAR (50)
DECLARE @InsIDCoach NVARCHAR(50)
DECLARE @InsIDHall NVARCHAR(50)
SET @InsTime = (SELECT ClassTime FROM inserted);
IF EXISTS  (SELECT *
			FROM (inserted o JOIN Client c
			ON o.IDClient = c.ID)
			WHERE(IDCoach = c.IDCoach) AND c.IDCoach IS NOT NULL)
BEGIN
	SET @InsIDCoach = (SELECT a.IDCoach 
		FROM (
			SELECT *
			FROM (inserted o JOIN Client c
			ON o.IDClient = c.ID)
			WHERE(IDCoach = c.IDCoach)) a
		)
END
ELSE 
BEGIN
	PRINT '� ������� ��� �������'
	RETURN
END

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
	 WHERE (ABS(DATEDIFF(MINUTE,a.ClassTime,@InsTime)) < 60)) > 0
)
BEGIN
	PRINT '������ �����'
	RETURN
END
ELSE
	BEGIN
		--PRINT '������ ��������'
		IF
		(
			(SELECT COUNT(*) 
				FROM (SELECT IDClient, IDHall,ClassTime
						FROM Lessons 
						WHERE (IDHall = @InsIDHall)
				) AllHall

				WHERE (ABS(DATEDIFF(MINUTE,AllHall.ClassTime,@InsTime)) < 60)) > 0
			)
		BEGIN	
			PRINT '��� �����'
			RETURN
		END
		ELSE
		BEGIN 
			--PRINT '��� ��������'
			IF
			(
				(SELECT COUNT(*) 
					FROM (SELECT IDClient, IDHall,ClassTime
							FROM Lessons 
							WHERE (IDClient = @IdClient)
					) AllClient

					WHERE (ABS(DATEDIFF(MINUTE,AllClient.ClassTime,@InsTime)) < 60)) > 0
			)
			BEGIN 
				PRINT '������ �����'
				RETURN
			END
			--��� ������ ���������
			ELSE 
			BEGIN
				PRINT '������� ���������'
				    INSERT INTO Lessons(IDClient,IDHall,ClassTime)
					VALUES (@IdClient,@InsIDHall,@InsTime)
			END
		END
	END
END
GO
