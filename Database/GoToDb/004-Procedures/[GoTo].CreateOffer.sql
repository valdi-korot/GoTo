DROP PROCEDURE [GoTo].CreateOffer
GO
Create Procedure [GoTo].CreateOffer 
   @id	NVARCHAR(200),
   @title  NVARCHAR(200),
   @description NVARCHAR(1000),   
   @Longitude FLOAT,       
   @Latitude FLOAT,        
   @AuthorID NVARCHAR(100),			
   @Status NVARCHAR(10),
   @Type NVARCHAR(100),				
   @MeetDateTime DATETIME,
   @CreatedDateTime	DATETIME
AS
 INSERT INTO [GoTo].Offers 
   (
   id,
   title,
   description,   
   Longitude,       
   Latitude,        
   AuthorID,			
   Status,
   Type,				
   MeetDateTime,
   CreatedDateTime
   )
   VALUES
   (
   @id,
   @title ,
   @description,   
   @Longitude ,       
   @Latitude,        
   @AuthorID,			
   @Status,
   @Type,				
   @MeetDateTime,
   @CreatedDateTime)


