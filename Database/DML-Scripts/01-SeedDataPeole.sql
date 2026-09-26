USE DVLD_DB;
GO

INSERT INTO tblPeople 
(
    NationalNO, 
    FirstName, 
    SecondName, 
    ThirdName, 
    LastName, 
    Gendor, 
    DateOfBirth, 
    [Address], 
    PhoneNumber, 
    Email, 
    CountryID, 
    Notes, 
    ImagePath
)
VALUES
('N001', 'John', 'Edward', 'Robert', 'Smith', 'M', '1988-05-12', '123 Elm Street, New York, NY', '+12025550143', 'john.smith@example.com', 1, NULL, NULL),
('N002', 'Emily', 'Grace', 'Rose', 'Johnson', 'F', '1992-08-24', '456 Oak Avenue, London, UK', '+442079460912', 'emily.johnson@example.com', 12, NULL, NULL),
('N003', 'Michael', 'David', 'James', 'Williams', 'M', '1985-01-15', '789 Pine Road, Toronto, Canada', '+14165550178', 'm.williams@example.com', 25, NULL, NULL),
('N004', 'Sarah', 'Elizabeth', 'Ann', 'Brown', 'F', '1995-11-30', '321 Maple Drive, Sydney, Australia', '+61255501234', 'sarah.brown@example.com', 40, NULL, NULL),
('N005', 'James', 'Alexander', 'Charles', 'Jones', 'M', '1990-03-22', '654 Cedar Lane, Manchester, UK', '+441614960123', 'james.jones@example.com', 12, NULL, NULL),
('N006', 'Jessica', 'Marie', 'Lynn', 'Miller', 'F', '1998-07-19', '987 Birch Boulevard, Chicago, IL', '+13125550199', 'jessica.m@example.com', 1, NULL, NULL),
('N007', 'Daniel', 'Christopher', 'Paul', 'Davis', 'M', '1982-09-05', '147 Walnut Street, Dublin, Ireland', '+35314960144', 'daniel.davis@example.com', 55, NULL, NULL),
('N008', 'Sophia', 'Victoria', 'Jane', 'Wilson', 'F', '2000-12-10', '258 Spruce Way, Auckland, New Zealand', '+6495550155', 'sophia.wilson@example.com', 78, NULL, NULL),
('N009', 'Matthew', 'Thomas', 'George', 'Taylor', 'M', '1993-04-18', '369 Ash Court, Glasgow, UK', '+441414960166', 'matthew.t@example.com', 90, NULL, NULL),
('N010', 'Olivia', 'Charlotte', 'Kate', 'Anderson', 'F', '1997-02-28', '741 Beech Street, Los Angeles, CA', '+12135550188', 'olivia.a@example.com', 93, NULL, NULL);

GO

SELECT * FROM tblPeople