CREATE TABLE [dbo].[County] (
    [Id]         INT           IDENTITY (1, 1) NOT NULL,
    [RegionId]   INT           NOT NULL,
    [CountyName] VARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_County_Region] FOREIGN KEY ([RegionId]) REFERENCES [dbo].[Region] ([Id])
);

