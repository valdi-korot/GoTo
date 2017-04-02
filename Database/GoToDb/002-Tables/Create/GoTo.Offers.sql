
Use [GoToDB] 
IF NOT EXISTS (SELECT * FROM sys.tables
WHERE name = N'Offers' AND type = 'U')
BEGIN
--DROP TABLE [GoTo].Offers 
CREATE TABLE [GoTo].Offers
(
   id               UNIQUEIDENTIFIER  NOT NULL PRIMARY KEY,
   title            NVARCHAR(200)     NOT NULL,
   description      NVARCHAR(1000)    NOT NULL,
   Longitude        FLOAT NULL,
   Latitude         FLOAT NULL,
   AuthorID			NVARCHAR(100) NOT NULL,
   Status varchar(10)  NULL CHECK (Status IN('open', 'closed', 'deleted')),
   Type				NVARCHAR(100)  NULL,
   MeetDateTime	DATETIME NOT NULL,
   CreatedDateTime	DATETIME NOT NULL

)
END