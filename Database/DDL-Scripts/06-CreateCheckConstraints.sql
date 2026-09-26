USE DVLD_DB
GO

ALTER TABLE tblPeople
ADD CONSTRAINT CK_tblPeople_Gendor CHECK (Gendor IN ('M', 'F'));
GO

ALTER TABLE tblApplications
ADD CONSTRAINT CK_tblApplications_ApplicationStatus CHECK (ApplicationStatus IN (1, 2, 3));
GO

ALTER TABLE tblLicenses
ADD CONSTRAINT CK_tblLicenses_LicenseStatus CHECK (LicenseStatus IN (1, 2, 3, 4));
GO