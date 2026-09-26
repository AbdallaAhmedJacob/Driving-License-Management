USE DVLD_DB
GO
USE DVLD_DB
GO

-- -----------People Tables--------------

-- tblCountries
CREATE UNIQUE NONCLUSTERED INDEX UQ_tblCountries_CountryName 
ON tblCountries(CountryName);

-- tblPeople
CREATE UNIQUE NONCLUSTERED INDEX UQ_tblPeople_NationalNO 
ON tblPeople(NationalNO);

-- tblUsers
ALTER TABLE tblUsers 
ADD CONSTRAINT UQ_tblUsers_PersonID UNIQUE (PersonID);

ALTER TABLE tblUsers 
ADD CONSTRAINT UQ_tblUsers_UserName UNIQUE (UserName);

-- tblCertificates
ALTER TABLE tblCertificates 
ADD CONSTRAINT UQ_tblCertificates_CertificateNumber UNIQUE (CertificateNumber);


-- -------------------------- Applications -----------------------------------

-- tblApplications
CREATE UNIQUE NONCLUSTERED INDEX UQ_tblApplications_ApplicationReference 
ON tblApplications(ApplicationReference) 
WHERE ApplicationReference IS NOT NULL;


-- ----------------------------Licenses-------------------

-- tblLicenseClasses
ALTER TABLE tblLicenseClasses 
ADD CONSTRAINT UQ_tblLicenseClasses_ClassName UNIQUE (ClassName);

-- tblLicenses
ALTER TABLE tblLicenses 
ADD CONSTRAINT UQ_tblLicenses_ApplicationID UNIQUE (ApplicationID);

ALTER TABLE tblLicenses 
ADD CONSTRAINT UQ_tblLicenses_DriverID_LicenseClassID UNIQUE (DriverID, LicenseClassID);

-- tblRenewLicenses
ALTER TABLE tblRenewLicenses 
ADD CONSTRAINT UQ_tblRenewLicenses_RenewLicenseApplicationID UNIQUE (RenewLicenseApplicationID);

ALTER TABLE tblRenewLicenses 
ADD CONSTRAINT UQ_tblRenewLicenses_VisionTestID UNIQUE (VisionTestID);