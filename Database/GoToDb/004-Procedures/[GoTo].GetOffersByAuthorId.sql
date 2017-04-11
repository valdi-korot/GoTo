USE [GoToDB]
GO
--DROP PROCEDURE [GoTo].GetOffersByAuthorId
--GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [GoTo].[GetOffersByAuthorId] 
 @AuthorId	NVARCHAR(200)
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
  WHERE o.AuthorID=@AuthorId 
