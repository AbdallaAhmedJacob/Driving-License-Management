USE DVLD_DB;
GO

-- إيقاف العد المؤقت لتسريع عملية الإدخال (اختياري للأداء العالي)
SET NOCOUNT ON;

DECLARE @Counter INT = 1;
DECLARE @MaxRows INT = 1000; -- عدد السجلات المطلوبة

-- مصفوفات مساعدة لتوليد بيانات واقعية
DECLARE @FirstNames TABLE (ID INT IDENTITY(1,1), Name VARCHAR(50));
INSERT INTO @FirstNames (Name) VALUES 
('John'), ('Emily'), ('Michael'), ('Sarah'), ('James'), ('Jessica'), ('Daniel'), ('Sophia'), ('Matthew'), ('Olivia'),
('David'), ('Emma'), ('Chris'), ('Hannah'), ('Andrew'), ('Chloe'), ('Joshua'), ('Grace'), ('Ryan'), ('Mia');

DECLARE @SecondNames TABLE (ID INT IDENTITY(1,1), Name VARCHAR(50));
INSERT INTO @SecondNames (Name) VALUES 
('Edward'), ('Grace'), ('David'), ('Elizabeth'), ('Alexander'), ('Marie'), ('Christopher'), ('Victoria'), ('Thomas'), ('Charlotte'),
('Robert'), ('Rose'), ('James'), ('Ann'), ('Charles'), ('Lynn'), ('Paul'), ('Jane'), ('George'), ('Kate');

DECLARE @ThirdNames TABLE (ID INT IDENTITY(1,1), Name VARCHAR(50));
INSERT INTO @ThirdNames (Name) VALUES 
('Robert'), ('Rose'), ('James'), ('Ann'), ('Charles'), ('Lynn'), ('Paul'), ('Jane'), ('George'), ('Kate'),
('John'), ('Emily'), ('Michael'), ('Sarah'), ('James'), ('Jessica'), ('Daniel'), ('Sophia'), ('Matthew'), ('Olivia');

DECLARE @LastNames TABLE (ID INT IDENTITY(1,1), Name VARCHAR(50));
INSERT INTO @LastNames (Name) VALUES 
('Smith'), ('Johnson'), ('Williams'), ('Brown'), ('Jones'), ('Miller'), ('Davis'), ('Wilson'), ('Taylor'), ('Anderson'),
('Thomas'), ('Jackson'), ('White'), ('Harris'), ('Martin'), ('Thompson'), ('Garcia'), ('Martinez'), ('Robinson'), ('Clark');

-- بدء عملية الإدخال التكراري
WHILE @Counter <= @MaxRows
BEGIN
    DECLARE @NationalNO VARCHAR(20) = 'N' + RIGHT('0000' + CAST(@Counter AS VARCHAR(10)), 4);
    
    DECLARE @FIdx INT = (ABS(CHECKSUM(NEWID())) % 20) + 1;
    DECLARE @SIdx INT = (ABS(CHECKSUM(NEWID())) % 20) + 1;
    DECLARE @TIdx INT = (ABS(CHECKSUM(NEWID())) % 20) + 1;
    DECLARE @LIdx INT = (ABS(CHECKSUM(NEWID())) % 20) + 1;
    
    DECLARE @FirstName VARCHAR(50) = (SELECT Name FROM @FirstNames WHERE ID = @FIdx);
    DECLARE @SecondName VARCHAR(50) = (SELECT Name FROM @SecondNames WHERE ID = @SIdx);
    DECLARE @ThirdName VARCHAR(50) = (SELECT Name FROM @ThirdNames WHERE ID = @TIdx);
    DECLARE @LastName VARCHAR(50) = (SELECT Name FROM @LastNames WHERE ID = @LIdx);
    
    -- تحديد الجنس عشوائياً (M أو F)
    DECLARE @Gendor CHAR(1) = CASE WHEN (@Counter % 2 = 0) THEN 'F' ELSE 'M' END;
    
    -- توليد تاريخ ميلاد عشوائي بين الأعوام 1970 و 2005
    DECLARE @BirthDate DATE = DATEADD(DAY, - (ABS(CHECKSUM(NEWID())) % 12775), '2005-01-01');
    
    -- توليد عنوان وبريد إلكتروني ورقم هاتف بناءً على الاسم ورقم التسلسل
    DECLARE @Address VARCHAR(100) = CAST((@Counter + 100) AS VARCHAR(10)) + ' Main Street, City ' + CAST(@Counter AS VARCHAR(10));
    DECLARE @Phone VARCHAR(20) = '+1' + RIGHT('0000000000' + CAST(ABS(CHECKSUM(NEWID())) % 9000000000 + 1000000000 AS VARCHAR(10)), 10);
    DECLARE @Email VARCHAR(100) = LOWER(@FirstName) + '.' + LOWER(@LastName) + CAST(@Counter AS VARCHAR(5)) + '@example.com';
    DECLARE @CountryID INT = (ABS(CHECKSUM(NEWID())) % 90) + 1;

    -- إدخال السجل في الجدول
    INSERT INTO tblPeople (NationalNO, FirstName, SecondName, ThirdName, LastName, Gendor, DateOfBirth, [Address], PhoneNumber, Email, CountryID, Notes, ImagePath)
    VALUES (@NationalNO, @FirstName, @SecondName, @ThirdName, @LastName, @Gendor, @BirthDate, @Address, @Phone, @Email, @CountryID, NULL, NULL);

    SET @Counter = @Counter + 1;
END

SET NOCOUNT OFF;
GO

-- التحقق من نجاح العملية وعرض عدد الصفوف الكلي
SELECT COUNT(*) AS TotalPeopleCount FROM tblPeople;
GO

SELECT * FROM tblPeople;