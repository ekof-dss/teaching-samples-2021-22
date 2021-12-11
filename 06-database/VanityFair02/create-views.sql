USE [VanityFair02]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vwMovieProfit]
AS
SELECT        dbo.Movie.MovieId, dbo.Movie.Title, dbo.Genre.ShortName, dbo.State.Code, dbo.Movie.Year, dbo.Movie.Profit
FROM            dbo.Genre INNER JOIN
                         dbo.Movie ON dbo.Genre.GenreId = dbo.Movie.GenreId INNER JOIN
                         dbo.State ON dbo.Movie.StateId = dbo.State.StatieId
GO
