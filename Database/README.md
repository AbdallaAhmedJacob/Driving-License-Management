# Database Design Documentation - Driver & Vehicle Licensing Department (DVLD)

## 1. Overview
This database schema is engineered to manage all operations related to driver licensing, driving test appointments, driver profiles, license detainment, and multi-type applications.

---

## 2. Modules & Entity Description

### A. People & User Management Module
* **`tblCountries`**: Master lookup table for countries and nationalities.
* **`tblPeople`**: Central repository for personal information (National ID, Full Name, DOB, Contact Info).
* **`tblUsers`**: System user accounts, permissions, and active status.
* **`tblUserAuthLogs`**: Audit logs capturing user authentication activities (Logins/Logouts).
* **`tblDrivers`**: Profiles representing individuals registered as official drivers.
* **`tblCertificates`**: Educational and qualification certificates for individuals.

### B. Applications & Payments Module
* **`tblFees`**: Financial lookup table defining base fee rates.
* **`tblApplicationTypes`**: Categories of service applications and their associated fee rates.
* **`tblApplications`**: Core table tracking all service requests, payment statuses, and reference numbers.
* **`tblLocalDrivingLicenseApps`**: Specialized extension for local driving license requests.
* **`tblPayments`**: Transaction records capturing payment methods, amounts, and completion status.

### C. Testing & Appointments Module
* **`tblTestAppointments`**: Scheduled test appointments mapped directly to service applications.
* **`tblTestTypes`**: Types of tests (Vision, Theory, Practical/Driving) and required fees.
* **`tblTests`**: Recorded results of tests conducted (Pass/Fail, Scores, and Notes).

### D. Licensing & Detain Module
* **`tblLicenseClasses`**: Class definitions for driving licenses (Age requirements, Validity length, Fees).
* **`tblLicenses`**: Active and historic driver licenses issued to drivers.
* **`tblInternationalLicenses`**: Permit records issued based on valid local licenses.
* **`tblDetainedLicenses`**: Records of confiscated/detained licenses, fines, and release tracking.
* **`tblRenewLicenses`**: License renewal history linking renewals to applications and vision tests.

---

## 3. Key Relationships & Business Rules
1. **Application-Centric Tracking (`ApplicationID`)**: Transactions (license issuing, renewal, test scheduling) are bound to unique application records for auditing.
2. **Auditability (`CreatedByUserID`)**: Critical operations capture the exact staff user ID responsible for creation or modification.
3. **Data Integrity Constraints**: Unique constraints (`UQ_tblLicenses_DriverID_LicenseClassID`) enforce rules preventing duplicate active licenses per class per driver.

## 4. Repository Structure
The repository is structured to separate Schema creation (DDL), Data Manipulation (DML), and Diagram assets:

```text
Database/
├── DDL-Scripts/
│   ├── 01-CreateDatabase.sql
│   ├── 02-CreateTables.sql
│   ├── 03-CreatePrimaryKeys.sql
│   ├── 04-CreateForeignKeys.sql
│   ├── 05-CreateUnique.sql
│   ├── 06-CreateCheckConstraints.sql
│   └── 07-CreateViews.sql
├── DML-Scripts/
│   └── 01-SeedDataPeole.sql
├── Diagrams/
│   ├── DVLD.dbml
│   └── DVLD.png
└── README.md
```
## 5. Setup & Execution Instructions
To set up the database, execute the scripts located in DDL-Scripts/ strictly in numerical order:

1. `01-CreateDatabase.sql`: Checks database existence and creates `DVLD_DB`.

2. `02-CreateTables.sql`: Generates database tables without constraints.

3. `03-CreatePrimaryKeys.sql`: Applies Primary Key constraints.

4. `04-CreateForeignKeys.sql`: Sets up Foreign Key relationships.

5. `05-CreateUnique.sql`: Adds unique indexes and constraints.

6. `06-CreateCheckConstraints.sql`: Enforces domain-specific check constraints.

7. `07-CreateViews.sql`: Generates database views for reporting.

### Seeding Data (Optional)
To populate initial seed data, run the scripts in `DML-Scripts/`:

- `01-SeedDataPeole.sql`: Populates tblPeople with initial records.

## 6. Diagrams & E-R Schema
Visual ER diagrams and definition files are located in the `Diagrams/` directory:

`DVLD.png`: High-resolution ERD image.

`DVLD.dbml`: Database Markup Language source files for DB Diagram tools.