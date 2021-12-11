USE [VanityFair01]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Movie](
	[MovieId] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](255) NOT NULL,
	[Genre] [nvarchar](255) NOT NULL,
	[Lasting] [smallint] NOT NULL,
	[States] [nvarchar](255) NOT NULL,
	[ImdbScore] [float] NOT NULL,
	[Year] [smallint] NULL,
	[Actors] [nvarchar](4000) NULL,
	[Directors] [nvarchar](4000) NULL,
	[Scenarists] [nvarchar](4000) NULL,
	[Plot] [nvarchar](max) NULL,
	[Profit] [money] NOT NULL,
 CONSTRAINT [PK_Movie] PRIMARY KEY CLUSTERED 
(
	[MovieId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Movie] ADD  CONSTRAINT [DF_Movie_Lasting]  DEFAULT ((90)) FOR [Lasting]
GO

ALTER TABLE [dbo].[Movie] ADD  CONSTRAINT [DF_Movie_States]  DEFAULT ('') FOR [States]
GO

ALTER TABLE [dbo].[Movie] ADD  CONSTRAINT [DF_Movie_ImdbScore]  DEFAULT ((0)) FOR [ImdbScore]
GO

ALTER TABLE [dbo].[Movie] ADD  CONSTRAINT [DF_Movie_Profit]  DEFAULT ((0)) FOR [Profit]
GO

