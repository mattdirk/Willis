USE [Willis]
GO

INSERT INTO Campsites (SiteNumber, Type)
VALUES(1, 'double'),
(2, 'single'),
(3, 'double'),
(4, 'single'),
(5, 'double')

INSERT INTO Reservations(CampsitesID, Paid, DateStart, DateEnd)
VALUES (1, 1, '6/1/2022', '6/3/2022'),
(1, 0, '6/4/2022', '6/6/2022'),
(2, 1, '6/1/2022', '6/3/2022'),
(3, 0, '6/5/2022', '6/8/2022')

INSERT INTO AvailableReservations(CampsitesID, DateAvailable)
VALUES(1, '6/7/2022'),
(1, '6/8/2022'),
(1, '6/9/2022'),
(1, '6/10/2022'),
(1, '6/11/2022')