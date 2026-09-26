USE DVLD_DB
GO

-- -----------People Tables--------------

CREATE TABLE tblCountries (
    CountryID SMALLINT IDENTITY(1,1) NOT NULL,
    CountryName NCHAR(255) NOT NULL
);  

CREATE TABLE tblPeople (
    PersonID INT IDENTITY(1,1) NOT NULL,
    NationalNO NCHAR(255) NOT NULL,
    FirstName NVARCHAR(50) NOT NULL,
    SecondName NVARCHAR(50) NOT NULL,
    ThirdName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    Gendor CHAR(1) NOT NULL,
    DateOfBirth DATE NOT NULL,
    Address NVARCHAR(500) NOT NULL,
    PhoneNumber VARCHAR(20) NOT NULL,
    Email VARCHAR(100) NULL,
    CountryID SMALLINT NOT NULL,
    Notes NVARCHAR(500) NULL,
    ImagePath NVARCHAR(500) NULL
); 

CREATE TABLE tblUsers (
    UserID INT IDENTITY(1,1) NOT NULL,
    PersonID INT NOT NULL,
    UserName VARCHAR(50) NOT NULL,
    [Password] VARCHAR(255) NOT NULL,
    [Permissions] INT NOT NULL,
    IsActive BIT NOT NULL
); 

CREATE TABLE tblUserAuthLogs (
    AuthLogID INT IDENTITY(1,1) NOT NULL,
    UserID INT NOT NULL,
    AuthType BIT NOT NULL,
    [DateTime] DATETIME DEFAULT SYSDATETIME()
); 

CREATE TABLE tblDrivers (
    DriverID INT IDENTITY(1,1) NOT NULL,
    PersonID INT NOT NULL,
    CreatedAt DATETIME DEFAULT SYSDATETIME(),
    CreatedByUserID INT NOT NULL
); 

CREATE TABLE tblCertificates (
    CertificateID INT IDENTITY(1,1) NOT NULL,
    CertificateNumber INT NOT NULL,
    PersonID INT NOT NULL,
    Issuer NVARCHAR(250) NOT NULL,
    Title NVARCHAR(250) NOT NULL,
    [Description] NVARCHAR(500) NULL,
    IssueDate DATE NOT NULL,
    ExpiryDate DATE NULL,
    Grade NVARCHAR(20) NULL,
    Score DECIMAL(3,2) NULL,
    FileURL NVARCHAR(500) NULL,
    Notes NVARCHAR(500) NULL,
    CreatedAt DATETIME DEFAULT SYSDATETIME(),
    CreatedByUserID INT NOT NULL
); 

-- -------------------------- Applications -----------------------------------

CREATE TABLE tblFees (
    FeesID TINYINT IDENTITY(1,1) NOT NULL,
    Title NVARCHAR(255) NOT NULL,
    FeesAmount MONEY NOT NULL
); 

CREATE TABLE tblApplicationTypes (
    ApplicationTypeID TINYINT IDENTITY(1,1) NOT NULL,
    ApplicationTypeTitle NVARCHAR(100) NOT NULL,
    ApplicationFees TINYINT NOT NULL
); 

CREATE TABLE tblApplications (
    ApplicationID INT IDENTITY(1,1) NOT NULL,
    PersonID INT NOT NULL,
    ApplicationTypeID TINYINT NOT NULL,
    ApplicationStatus TINYINT NOT NULL,
    PaidFees MONEY NOT NULL,
    PaymentID INT NOT NULL,
    Notes NVARCHAR(500) NULL,
    ApplicationReference INT NULL,
    CreatedAt DATETIME DEFAULT SYSDATETIME(),
    CreatedByUserID INT NOT NULL
); 

CREATE TABLE tblLocalDrivingLicenseApps (
    LocalDrivingLicenseAppID INT IDENTITY(1,1) NOT NULL,
    ApplicationID INT NOT NULL,
    LicenseClassID TINYINT NOT NULL
); 

-- ----------------------------Tests--------------

CREATE TABLE tblTestAppointments (
    TestAppointmentID INT IDENTITY(1,1) NOT NULL,
    ApplicationID INT NOT NULL,
    Title NVARCHAR(100) NOT NULL,
    AppointmentDate DATETIME NOT NULL,
    AppointmentLocation NVARCHAR(500) NOT NULL,
    Notes NVARCHAR(500) NULL,
    CreatedAt DATETIME DEFAULT SYSDATETIME(),
    CreatedByUserID INT NOT NULL
); 

CREATE TABLE tblTestTypes (
    TestTypeID TINYINT IDENTITY(1,1) NOT NULL,
    Title NVARCHAR(255) NOT NULL,
    [Description] NVARCHAR(500) NULL,
    FeesID TINYINT NOT NULL
); 

CREATE TABLE tblTests (
    TestID INT IDENTITY(1,1) NOT NULL,
    TestTypeID TINYINT NOT NULL,
    AppointmentID INT NOT NULL,
    IsPassed BIT NOT NULL,
    Score TINYINT NULL,
    Notes NVARCHAR(500) NULL,
    CreatedAt DATETIME DEFAULT SYSDATETIME(),
    CreatedByUserID INT NOT NULL
); 

-- ----------------------------Licenses-------------------

CREATE TABLE tblLicenseClasses (
    LicenseClassID TINYINT IDENTITY(1,1) NOT NULL,
    ClassName NVARCHAR(100) NOT NULL,
    ClassDescription NVARCHAR(500) NULL,
    MinimumAllowedAge TINYINT NOT NULL,
    ValidityLength TINYINT NOT NULL,
    FeesID TINYINT NOT NULL
); 

CREATE TABLE tblLicenses (
    LicenseID INT IDENTITY(1,1) NOT NULL,
    DriverID INT NOT NULL,
    ApplicationID INT NOT NULL,
    LicenseClassID TINYINT NOT NULL,
    LicenseStatus TINYINT NOT NULL DEFAULT 1,
    IsActive BIT NOT NULL,
    ReleaseDate DATE NOT NULL,
    ExpiryDate DATE NOT NULL,
    Notes NVARCHAR(500) NULL,
    CreatedAt DATETIME DEFAULT SYSDATETIME(),
    CreatedByUserID INT NOT NULL
); 

CREATE TABLE tblInternationalLicenses (
    InternationalLicenseID INT IDENTITY(1,1) NOT NULL,
    ApplicationID INT NOT NULL,
    LicenseID INT NOT NULL,
    IsActive BIT NOT NULL,
    ReleaseDate DATE NOT NULL,
    FeesID TINYINT NOT NULL,
    Notes NVARCHAR(500) NULL,
    CreatedAt DATETIME DEFAULT SYSDATETIME(),
    CreatedByUserID INT NOT NULL
); 

CREATE TABLE tblDetainedLicenses (
    DetainLicenseID INT IDENTITY(1,1) NOT NULL,
    LicenseID INT NOT NULL,
    DetainDate SMALLDATETIME NOT NULL,
    ReleaseDate SMALLDATETIME NULL,
    FineFees TINYINT NOT NULL,
    IsReleased BIT NOT NULL,
    Notes NVARCHAR(500) NULL,
    ReleaseApplicationID INT NULL,
    ReleaseByUserID INT NULL,
    CreatedByUserID INT NOT NULL
); 

CREATE TABLE tblRenewLicenses (
    LicenseID INT NOT NULL,
    RenewLicenseApplicationID INT NOT NULL,
    VisionTestID INT NOT NULL,
    RenewLicenseDate DATE NOT NULL,
    Notes NVARCHAR(500) NULL,
    CreatedAt DATETIME DEFAULT SYSDATETIME(),
    CreatedByUserID INT NOT NULL
); 

CREATE TABLE tblPayments (
    PaymentID INT IDENTITY(1,1) NOT NULL,
    FeesID TINYINT NOT NULL,
    PaymentMethod NVARCHAR(500) NOT NULL,
    Amount MONEY NOT NULL,
    PaymentStatus NVARCHAR(100) NOT NULL,
    Notes NVARCHAR(500) NULL
); 