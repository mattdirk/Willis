USE [Willis]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[AvailableReservations](
	[AvailableReservationsID] [int] IDENTITY(1,1) NOT NULL,
	[CampsitesID] [int] NOT NULL,
	[DateAvailable] [DateTime] NULL,
 CONSTRAINT [PK_Action] PRIMARY KEY CLUSTERED,
 CONSTRAINT [FK_AvailableReservationCampsite] FOREIGN KEY (CampsitesID) REFERENCES Campsites(CampsitesID)
(
	[AvailableReservationsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = ON, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]
GO


