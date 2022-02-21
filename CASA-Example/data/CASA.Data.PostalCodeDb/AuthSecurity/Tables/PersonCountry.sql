CREATE TABLE [AuthSecurity].[PersonCountry] (
    [Id]            INT IDENTITY (1, 1) NOT NULL,
    [PersonId]      INT NOT NULL,
    [CountryId]     INT NOT NULL,
    [HasPermission] BIT DEFAULT ((1)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_PersonCountry_Country] FOREIGN KEY ([CountryId]) REFERENCES [dbo].[Country] ([Id]),
    CONSTRAINT [FK_PersonCountry_Person] FOREIGN KEY ([PersonId]) REFERENCES [AuthSecurity].[Person] ([Id])
);

