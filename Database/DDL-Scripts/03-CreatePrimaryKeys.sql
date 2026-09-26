USE DVLD_DB
GO

-- -----------People Tables--------------

ALTER TABLE tblCountries 
ADD CONSTRAINT PK_tblCountries PRIMARY KEY (CountryID);

ALTER TABLE tblPeople 
ADD CONSTRAINT PK_tblPeople PRIMARY KEY (PersonID);

ALTER TABLE tblUsers 
ADD CONSTRAINT PK_tblUsers PRIMARY KEY (UserID);

ALTER TABLE tblUserAuthLogs 
ADD CONSTRAINT PK_tblUserAuthLogs PRIMARY KEY (AuthLogID);

ALTER TABLE tblDrivers 
ADD CONSTRAINT PK_tblDrivers PRIMARY KEY (DriverID);

ALTER TABLE tblCertificates 
ADD CONSTRAINT PK_tblCertificates PRIMARY KEY (CertificateID);

-- -------------------------- Applications -----------------------------------

ALTER TABLE tblFees 
ADD CONSTRAINT PK_tblFees PRIMARY KEY (FeesID);

ALTER TABLE tblApplicationTypes 
ADD CONSTRAINT PK_tblApplicationTypes PRIMARY KEY (ApplicationTypeID);

ALTER TABLE tblApplications 
ADD CONSTRAINT PK_tblApplications PRIMARY KEY (ApplicationID);

ALTER TABLE tblLocalDrivingLicenseApps 
ADD CONSTRAINT PK_tblLocalDrivingLicenseApps PRIMARY KEY (LocalDrivingLicenseAppID);

-- ----------------------------Tests--------------

ALTER TABLE tblTestAppointments 
ADD CONSTRAINT PK_tblTestAppointments PRIMARY KEY (TestAppointmentID);

ALTER TABLE tblTestTypes 
ADD CONSTRAINT PK_tblTestTypes PRIMARY KEY (TestTypeID);

ALTER TABLE tblTests 
ADD CONSTRAINT PK_tblTests PRIMARY KEY (TestID);

-- ----------------------------Licenses-------------------

ALTER TABLE tblLicenseClasses 
ADD CONSTRAINT PK_tblLicenseClasses PRIMARY KEY (LicenseClassID);

ALTER TABLE tblLicenses 
ADD CONSTRAINT PK_tblLicenses PRIMARY KEY (LicenseID);

ALTER TABLE tblInternationalLicenses 
ADD CONSTRAINT PK_tblInternationalLicenses PRIMARY KEY (InternationalLicenseID);

ALTER TABLE tblDetainedLicenses 
ADD CONSTRAINT PK_tblDetainedLicenses PRIMARY KEY (DetainLicenseID);

-- Composite Primary Key tblRenewLicenses
ALTER TABLE tblRenewLicenses 
ADD CONSTRAINT PK_tblRenewLicenses PRIMARY KEY (LicenseID, RenewLicenseApplicationID);

ALTER TABLE tblPayments 
ADD CONSTRAINT PK_tblPayments PRIMARY KEY (PaymentID);