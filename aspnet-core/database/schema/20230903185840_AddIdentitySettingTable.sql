BEGIN TRANSACTION;
GO

CREATE TABLE [AppIdentitySettings] (
    [Id] nvarchar(450) NOT NULL,
    [Name] nvarchar(200) NOT NULL,
    [Prefix] nvarchar(max) NULL,
    [CurrentNumber] int NOT NULL,
    [StepNumber] int NOT NULL,
    CONSTRAINT [PK_AppIdentitySettings] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230903185840_AddIdentitySettingTable', N'7.0.10');
GO

COMMIT;
GO

