CREATE TABLE [dbo].[PostalCode] (
    [Id]         INT          NOT NULL,
    [CityId]     INT          NOT NULL,
    [CountyId]   INT          NOT NULL,
    [RegionId]   INT          NOT NULL,
    [CountryId]  INT          NOT NULL,
    [PostalCode] VARCHAR (25) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_PostalCode_City] FOREIGN KEY ([CityId]) REFERENCES [dbo].[City] ([Id]),
    CONSTRAINT [FK_PostalCode_Country] FOREIGN KEY ([CountryId]) REFERENCES [dbo].[Country] ([Id]),
    CONSTRAINT [FK_PostalCode_County] FOREIGN KEY ([CountyId]) REFERENCES [dbo].[County] ([Id]),
    CONSTRAINT [FK_PostalCode_Region] FOREIGN KEY ([RegionId]) REFERENCES [dbo].[Region] ([Id])
);

