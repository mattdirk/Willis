USE [Willis]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[InsertReservation]

@CampsitesID INT,
@Paid BIT,
@DateStart DateTime,
@DateEnd DateTime

AS
BEGIN
	INSERT INTO Reservations(CampsitesID, Paid, DateStart, DateEnd)
	VALUES (@CampsitesID, @Paid, @DateStart, @DateEnd)

	DELETE FROM AvailableReservations WHERE CampsitesID = @CampsitesID AND DateAvailable BETWEEN @DateStart AND @DateEnd
END


