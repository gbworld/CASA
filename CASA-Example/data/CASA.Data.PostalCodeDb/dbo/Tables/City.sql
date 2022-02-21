CREATE TABLE [dbo].[City] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [CountyId] INT           NOT NULL,
    [RegionId] INT           NOT NULL,
    [CityName] VARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_City_County] FOREIGN KEY ([CountyId]) REFERENCES [dbo].[County] ([Id])
);

