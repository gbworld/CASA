CREATE TABLE [dbo].[Region] (
    [Id]            INT           NOT NULL,
    [CountryId]     INT           NOT NULL,
    [RegionTypeId]  INT           NOT NULL,
    [RegionName]    VARCHAR (250) NOT NULL,
    [RegionAbbrev2] CHAR (2)      NOT NULL,
    CONSTRAINT [PK_StateProvince] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Region_Country] FOREIGN KEY ([CountryId]) REFERENCES [dbo].[Country] ([Id]),
    CONSTRAINT [FK_Region_RegionType] FOREIGN KEY ([RegionTypeId]) REFERENCES [dbo].[RegionType] ([Id])
);

