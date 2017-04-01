CREATE TABLE [GoTo].Offers
(
   id               UNIQUEIDENTIFIER  NOT NULL PRIMARY KEY,
   title            NVARCHAR(200)     NOT NULL,
   description      NVARCHAR(1000)    NOT NULL
)