CREATE TABLE [AuthSecurity].[PersonRegion] (
    [Id]            INT IDENTITY (1, 1) NOT NULL,
    [PersonId]      INT NOT NULL,
    [RegionId]      INT NOT NULL,
    [HasPermission] BIT DEFAULT ((1)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_PersonRegion_Person] FOREIGN KEY ([PersonId]) REFERENCES [AuthSecurity].[Person] ([Id]),
    CONSTRAINT [FK_PersonRegion_Region] FOREIGN KEY ([RegionId]) REFERENCES [dbo].[Region] ([Id])
);

