USE DVLD_DB
GO

-- ========== Pepole =====================

ALTER TABLE tblPeople
ADD CONSTRAINT FK_tblPeople_tblCountries
FOREIGN KEY (CountryID) REFERENCES tblCountries(CountryID);

ALTER TABLE tblUsers
ADD CONSTRAINT FK_tblUsers_tblPeople
FOREIGN KEY (PersonID) REFERENCES tblPeople(PersonID)
ON UPDATE NO ACTION ON DELETE NO ACTION;

ALTER TABLE tblDrivers
ADD CONSTRAINT FK_tblDrivers_tblPeople
FOREIGN KEY (PersonID) REFERENCES tblPeople(PersonID)
ON UPDATE NO ACTION ON DELETE NO ACTION;

ALTER TABLE tblApplications
ADD CONSTRAINT FK_tblApplications_tblPeople
FOREIGN KEY (PersonID) REFERENCES tblPeople(PersonID);

ALTER TABLE tblCertificates
ADD CONSTRAINT FK_tblCertificates_tblPeople
FOREIGN KEY (PersonID) REFERENCES tblPeople(PersonID);

ALTER TABLE tblDrivers
ADD CONSTRAINT FK_tblDrivers_tblUsers
FOREIGN KEY (CreatedByUserID) REFERENCES tblUsers(UserID)
ON UPDATE NO ACTION ON DELETE NO ACTION;

ALTER TABLE tblUserAuthLogs
ADD CONSTRAINT FK_tblUserAuthLogs_tblUsers
FOREIGN KEY (UserID) REFERENCES tblUsers(UserID)
ON UPDATE NO ACTION ON DELETE NO ACTION;

ALTER TABLE tblLicenses
ADD CONSTRAINT FK_tblLicenses_tblUsers
FOREIGN KEY (CreatedByUserID) REFERENCES tblUsers(UserID);

ALTER TABLE tblApplications
ADD CONSTRAINT FK_tblApplications_tblUsers
FOREIGN KEY (CreatedByUserID) REFERENCES tblUsers(UserID);

ALTER TABLE tblDetainedLicenses
ADD CONSTRAINT FK_tblDetainedLicenses_ReleaseByUserID_tblUsers
FOREIGN KEY (ReleaseByUserID) REFERENCES tblUsers(UserID);

ALTER TABLE tblDetainedLicenses
ADD CONSTRAINT FK_tblDetainedLicenses_CreatedByUserID_tblUsers
FOREIGN KEY (CreatedByUserID) REFERENCES tblUsers(UserID);

ALTER TABLE tblRenewLicenses
ADD CONSTRAINT FK_tblRenewLicenses_tblUsers
FOREIGN KEY (CreatedByUserID) REFERENCES tblUsers(UserID);

ALTER TABLE tblInternationalLicenses
ADD CONSTRAINT FK_tblInternationalLicenses_tblUsers
FOREIGN KEY (CreatedByUserID) REFERENCES tblUsers(UserID);

ALTER TABLE tblCertificates
ADD CONSTRAINT FK_tblCertificates_tblUsers
FOREIGN KEY (CreatedByUserID) REFERENCES tblUsers(UserID);

ALTER TABLE tblTestAppointments
ADD CONSTRAINT FK_tblTestAppointments_tblUsers
FOREIGN KEY (CreatedByUserID) REFERENCES tblUsers(UserID);

ALTER TABLE tblLicenses
ADD CONSTRAINT FK_tblLicenses_tblDrivers
FOREIGN KEY (DriverID) REFERENCES tblDrivers(DriverID);


-- ----------------------------Tests--------------

ALTER TABLE tblTests
ADD CONSTRAINT FK_tblTests_tblTestTypes
FOREIGN KEY (TestTypeID) REFERENCES tblTestTypes(TestTypeID);

ALTER TABLE tblRenewLicenses
ADD CONSTRAINT FK_tblRenewLicenses_tblTests
FOREIGN KEY (VisionTestID) REFERENCES tblTests(TestID);


-- ---------------------------- Applications-------------------------------------

ALTER TABLE tblApplications
ADD CONSTRAINT FK_tblApplications_tblApplicationTypes
FOREIGN KEY (ApplicationTypeID) REFERENCES tblApplicationTypes(ApplicationTypeID)
ON UPDATE NO ACTION ON DELETE NO ACTION;

ALTER TABLE tblLicenses
ADD CONSTRAINT FK_tblLicenses_tblApplications
FOREIGN KEY (ApplicationID) REFERENCES tblApplications(ApplicationID);

ALTER TABLE tblApplications
ADD CONSTRAINT FK_tblApplications_Self_ApplicationReference
FOREIGN KEY (ApplicationReference) REFERENCES tblApplications(ApplicationID);

ALTER TABLE tblRenewLicenses
ADD CONSTRAINT FK_tblRenewLicenses_tblApplications
FOREIGN KEY (RenewLicenseApplicationID) REFERENCES tblApplications(ApplicationID);

ALTER TABLE tblDetainedLicenses
ADD CONSTRAINT FK_tblDetainedLicenses_tblApplications
FOREIGN KEY (ReleaseApplicationID) REFERENCES tblApplications(ApplicationID);

ALTER TABLE tblInternationalLicenses
ADD CONSTRAINT FK_tblInternationalLicenses_tblApplications
FOREIGN KEY (ApplicationID) REFERENCES tblApplications(ApplicationID);

ALTER TABLE tblLocalDrivingLicenseApps
ADD CONSTRAINT FK_tblLocalDrivingLicenseApps_tblApplications
FOREIGN KEY (ApplicationID) REFERENCES tblApplications(ApplicationID);

ALTER TABLE tblTestAppointments
ADD CONSTRAINT FK_tblTestAppointments_tblApplications
FOREIGN KEY (ApplicationID) REFERENCES tblApplications(ApplicationID);

ALTER TABLE tblPayments
ADD CONSTRAINT FK_tblPayments_tblFees
FOREIGN KEY (FeesID) REFERENCES tblFees(FeesID);

ALTER TABLE tblLicenseClasses
ADD CONSTRAINT FK_tblLicenseClasses_tblFees
FOREIGN KEY (FeesID) REFERENCES tblFees(FeesID);

ALTER TABLE tblDetainedLicenses
ADD CONSTRAINT FK_tblDetainedLicenses_tblFees
FOREIGN KEY (FineFees) REFERENCES tblFees(FeesID);

ALTER TABLE tblApplicationTypes
ADD CONSTRAINT FK_tblApplicationTypes_tblFees
FOREIGN KEY (ApplicationFees) REFERENCES tblFees(FeesID);

ALTER TABLE tblInternationalLicenses
ADD CONSTRAINT FK_tblInternationalLicenses_tblFees
FOREIGN KEY (FeesID) REFERENCES tblFees(FeesID);

ALTER TABLE tblTestTypes
ADD CONSTRAINT FK_tblTestTypes_tblFees
FOREIGN KEY (FeesID) REFERENCES tblFees(FeesID);

ALTER TABLE tblLicenses
ADD CONSTRAINT FK_tblLicenses_tblLicenseClasses
FOREIGN KEY (LicenseClassID) REFERENCES tblLicenseClasses(LicenseClassID);

ALTER TABLE tblLocalDrivingLicenseApps
ADD CONSTRAINT FK_tblLocalDrivingLicenseApps_tblLicenseClasses
FOREIGN KEY (LicenseClassID) REFERENCES tblLicenseClasses(LicenseClassID);

ALTER TABLE tblInternationalLicenses
ADD CONSTRAINT FK_tblInternationalLicenses_tblLicenses
FOREIGN KEY (LicenseID) REFERENCES tblLicenses(LicenseID);

ALTER TABLE tblDetainedLicenses
ADD CONSTRAINT FK_tblDetainedLicenses_tblLicenses
FOREIGN KEY (LicenseID) REFERENCES tblLicenses(LicenseID);

ALTER TABLE tblRenewLicenses
ADD CONSTRAINT FK_tblRenewLicenses_tblLicenses
FOREIGN KEY (LicenseID) REFERENCES tblLicenses(LicenseID);

ALTER TABLE tblApplications
ADD CONSTRAINT FK_tblApplications_tblPayments
FOREIGN KEY (PaymentID) REFERENCES tblPayments(PaymentID);

ALTER TABLE tblTests
ADD CONSTRAINT FK_tblTests_tblTestAppointments
FOREIGN KEY (AppointmentID) REFERENCES tblTestAppointments(TestAppointmentID);