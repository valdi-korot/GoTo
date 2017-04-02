DROP PROCEDURE [GoTo].GetOffers
GO
CREATE PROCEDURE [GoTo].GetOffers
AS
  SELECT
   o.id       AS ID,
   o.title       AS Title,
   o.description  AS Description,   
   o.Longitude AS Longitude,       
   o.Latitude AS Latitude,        
   o.AuthorID AS AuthorID,			
   o.Status AS Status,
   o.Type AS Type,				
   o.MeetDateTime	AS MeetDateTime,
   o.CreatedDateTime AS CreatedDateTime	
  FROM [GoTo].Offers o
/*
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
   NEWID(),
   'test1',
   'descritiontest',
   1234.567890,
   1234.567890,
   '12345678-1234-1234-1234-123456789abc',
	null,
   'type45678-1234-1234-1234-123456789abc',
   '20170204',   
   '20170204')
   EXEC [GoTo].GetOffers
*/