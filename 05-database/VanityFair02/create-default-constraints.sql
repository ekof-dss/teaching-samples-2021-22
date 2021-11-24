USE [VanityFair02]
GO

ALTER TABLE [dbo].[Movie] ADD  CONSTRAINT [DF_Movie_GenreId]  DEFAULT ((1)) FOR [GenreId]
GO
ALTER TABLE [dbo].[Movie] ADD  CONSTRAINT [DF_Movie_Lasting]  DEFAULT ((90)) FOR [Lasting]
GO
ALTER TABLE [dbo].[Movie] ADD  CONSTRAINT [DF_Movie_StateId]  DEFAULT ((0)) FOR [StateId]
GO
ALTER TABLE [dbo].[Movie] ADD  CONSTRAINT [DF_Movie_ImdbScore]  DEFAULT ((0)) FOR [ImdbScore]
GO
ALTER TABLE [dbo].[Movie] ADD  CONSTRAINT [DF_Movie_Profit]  DEFAULT ((0)) FOR [Profit]
GO
