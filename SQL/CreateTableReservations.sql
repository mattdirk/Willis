USE [Willis]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Reservations](
	[ReservationsID] [int] IDENTITY(1,1) NOT NULL,
	[CampsitesID] [int] NOT NULL,
	[Paid] [bit] NULL,
	[DateStart] [DateTime] NULL,
	[DateEnd] [DateTime] NULL,
 CONSTRAINT [PK_Action] PRIMARY KEY CLUSTERED,
 CONSTRAINT [FK_ReservationCampsite] FOREIGN KEY (CampsitesID) REFERENCES Campsites(CampsitesID)
(
	[ReservationsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = ON, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]
GO


