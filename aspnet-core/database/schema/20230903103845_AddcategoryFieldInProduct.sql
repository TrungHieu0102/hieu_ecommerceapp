BEGIN TRANSACTION;
GO

ALTER TABLE [AppProducts] ADD [CategoryName] nvarchar(250) NULL;
GO

ALTER TABLE [AppProducts] ADD [CategorySlug] nvarchar(250) NULL;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230903103845_AddcategoryFieldInProduct', N'7.0.10');
GO

COMMIT;
GO

