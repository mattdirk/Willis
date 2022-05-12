USE [Willis]
GO
/****** Object:  StoredProcedure [dbo].[AppraiserTouGet]    Script Date: 5/11/2022 8:13:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[CancelReservation]

@ReservationsID INT

AS
BEGIN
	DECLARE @DateStart DateTime, @DateEnd DateTime, @CampsitesID INT
	SELECT @CampsitesID = CampsitesID, @DateStart = DateStart, @DateEnd = DateEnd FROM Reservations WHERE ReservationsID = @ReservationsID

	DELETE FROM Reservations WHERE ReservationsID = @ReservationsID

	INSERT INTO AvailableReservations(CampsitesID, DateAvailable)
	VALUES (@CampsitesID, @DateStart),
	       (@CampsitesID, @DateEnd) --googled ways to insert all the dates in the range and think thats outside the scope of this challenge.Saw suggestions to use a CTE or a number table


END


