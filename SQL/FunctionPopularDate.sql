USE [Willis]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE FUNCTION [dbo].[MostPopularDate](@temp INT)
RETURNS DateTime
AS
BEGIN
	DECLARE @PopDate DateTime

	SELECT @PopDate = MAX (mycount)
	FROM (SELECT DateStart, COUNT(DateStart) mycount
	FROM Reservations GROUP BY DateStart)
	
	RETURN @PopDate
END


