USE [Willis]
GO

/****** Object:  View [dbo].[BasicRules]    Script Date: 5/11/2022 8:27:52 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE View [dbo].[AvailableReservationsView] as

SELECT c.SiteNumber, ar.DateAvailable FROM Campsites c JOIN AvailableReservations ar ON c.CampsitesID = ar.CampsitesID
GO


