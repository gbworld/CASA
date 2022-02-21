CREATE TABLE [dbo].[Country] (
    [Id]             INT           NOT NULL,
    [CountryName]    VARCHAR (100) NOT NULL,
    [CountryAbbrev3] CHAR (3)      NOT NULL,
    [CountryAbbrev2] CHAR (2)      NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

