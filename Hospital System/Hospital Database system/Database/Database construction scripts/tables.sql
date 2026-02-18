CREATE TABLE [dbo].[patient]
(
	[patientID] INT NOT NULL PRIMARY KEY,
	[patientPassword] VARCHAR(50) NOT NULL
);
CREATE TABLE [dbo].[doctor]
(
	[doctorID] INT NOT NULL PRIMARY KEY,
);
CREATE TABLE [dbo].[appointment] 
(
	[appointmentID] INT NOT NULL PRIMARY KEY,
	[patientID] INT NOT NULL FOREIGN KEY REFERENCES patient(patientID),
	[doctorID] INT NOT NULL FOREIGN KEY REFERENCES doctor(doctorID),
	[appointmentDate] TIMESTAMP NOT NULL
);