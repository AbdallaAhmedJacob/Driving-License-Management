USE DVLD_DB
GO 

CREATE VIEW vwPeople
AS
SELECT P.PersonID "Person ID", 
	   P.NationalNO "National NO",
	   P.FirstName "First Name",
	   P.SecondName "Second Name",
	   P.ThirdName "Third Name",
	   P.LastName "Last Name",
	   CASE
	       WHEN P.Gender = 'M' THEN 'Male'
	       WHEN P.Gender = 'F' THEN 'Female'
	   END "Gender",
	   P.DateOfBirth "Date Of Birth",
	   C.CountryName "Nationality",
	   P.PhoneNumber "Phone",
	   P.Email "Email"
FROM tblPeople P
INNER JOIN tblCountries C ON P.CountryID = C.CountryID
GO

-- SELECT * FROM vwPeople

CREATE VIEW vwUsers
AS
	SELECT
		 U.UserID AS 'User ID', 
		 P.PersonID AS 'Person ID',
			P.FirstName + ' ' +
			P.SecondName + ' ' + 
			P.ThirdName + ' ' +
			P.LastName AS 'Full Name',
		 U.UserName AS 'User Name',
		 U.IsActive AS 'Is Active'
	FROM tblUsers U
	INNER JOIN tblPeople P ON U.PersonID = P.PersonID
GO

-- SELECT * FROM vwUsers;