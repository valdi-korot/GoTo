DROP PROCEDURE [GoTo].GetOffers
GO
CREATE PROCEDURE [GoTo].GetOffers
AS
  SELECT
  o.title       AS Title,
  o.description AS Description
  FROM [GoTo].Offers o

/*
   INSERT INTO [GoTo].Offers 
   (
   id,
   title,
   description
   )
   VALUES
   (
   NEWID(),
   'test1',
   'descritiontest'
   )
   EXEC [GoTo].GetOffers
*/