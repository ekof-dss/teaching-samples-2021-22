USE [VanityFair02]
GO

ALTER TABLE [dbo].[Movie]  WITH CHECK ADD  CONSTRAINT [FK_Movie_Genre] FOREIGN KEY([GenreId])
REFERENCES [dbo].[Genre] ([GenreId])
GO
ALTER TABLE [dbo].[Movie] CHECK CONSTRAINT [FK_Movie_Genre]
GO
ALTER TABLE [dbo].[Movie]  WITH CHECK ADD  CONSTRAINT [FK_Movie_State] FOREIGN KEY([StateId])
REFERENCES [dbo].[State] ([StatieId])
GO
ALTER TABLE [dbo].[Movie] CHECK CONSTRAINT [FK_Movie_State]
GO
