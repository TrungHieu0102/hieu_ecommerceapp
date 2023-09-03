BEGIN TRANSACTION;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230902175212_FixObject', N'7.0.10');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230902205812_fixdatabase', N'7.0.10');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

EXEC sp_rename N'[AppProducts].[Visiblity]', N'Visibility', N'COLUMN';
GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AppProducts]') AND [c].[name] = N'ThumbnailPicture');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [AppProducts] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [AppProducts] ALTER COLUMN [ThumbnailPicture] nvarchar(250) NULL;
GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AppProducts]') AND [c].[name] = N'SeoMetaDescription');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [AppProducts] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [AppProducts] ALTER COLUMN [SeoMetaDescription] nvarchar(250) NULL;
GO

DECLARE @var2 sysname;
SELECT @var2 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AppProducts]') AND [c].[name] = N'Description');
IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [AppProducts] DROP CONSTRAINT [' + @var2 + '];');
ALTER TABLE [AppProducts] ALTER COLUMN [Description] nvarchar(max) NULL;
GO

DECLARE @var3 sysname;
SELECT @var3 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AppProductReviews]') AND [c].[name] = N'Content');
IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [AppProductReviews] DROP CONSTRAINT [' + @var3 + '];');
ALTER TABLE [AppProductReviews] ALTER COLUMN [Content] nvarchar(max) NULL;
GO

DECLARE @var4 sysname;
SELECT @var4 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AppProductCategories]') AND [c].[name] = N'SeoMetaDescription');
IF @var4 IS NOT NULL EXEC(N'ALTER TABLE [AppProductCategories] DROP CONSTRAINT [' + @var4 + '];');
ALTER TABLE [AppProductCategories] ALTER COLUMN [SeoMetaDescription] nvarchar(250) NULL;
GO

DECLARE @var5 sysname;
SELECT @var5 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AppProductCategories]') AND [c].[name] = N'CoverPicture');
IF @var5 IS NOT NULL EXEC(N'ALTER TABLE [AppProductCategories] DROP CONSTRAINT [' + @var5 + '];');
ALTER TABLE [AppProductCategories] ALTER COLUMN [CoverPicture] nvarchar(250) NULL;
GO

DECLARE @var6 sysname;
SELECT @var6 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AppProductAttributeVarchars]') AND [c].[name] = N'Value');
IF @var6 IS NOT NULL EXEC(N'ALTER TABLE [AppProductAttributeVarchars] DROP CONSTRAINT [' + @var6 + '];');
ALTER TABLE [AppProductAttributeVarchars] ALTER COLUMN [Value] nvarchar(500) NULL;
GO

DECLARE @var7 sysname;
SELECT @var7 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AppProductAttributeTexts]') AND [c].[name] = N'Value');
IF @var7 IS NOT NULL EXEC(N'ALTER TABLE [AppProductAttributeTexts] DROP CONSTRAINT [' + @var7 + '];');
ALTER TABLE [AppProductAttributeTexts] ALTER COLUMN [Value] nvarchar(max) NULL;
GO

DECLARE @var8 sysname;
SELECT @var8 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AppProductAttributes]') AND [c].[name] = N'Note');
IF @var8 IS NOT NULL EXEC(N'ALTER TABLE [AppProductAttributes] DROP CONSTRAINT [' + @var8 + '];');
ALTER TABLE [AppProductAttributes] ALTER COLUMN [Note] nvarchar(max) NULL;
GO

DECLARE @var9 sysname;
SELECT @var9 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AppOrderTransactions]') AND [c].[name] = N'Note');
IF @var9 IS NOT NULL EXEC(N'ALTER TABLE [AppOrderTransactions] DROP CONSTRAINT [' + @var9 + '];');
ALTER TABLE [AppOrderTransactions] ALTER COLUMN [Note] nvarchar(max) NULL;
GO

DECLARE @var10 sysname;
SELECT @var10 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AppManufacturers]') AND [c].[name] = N'CoverPicture');
IF @var10 IS NOT NULL EXEC(N'ALTER TABLE [AppManufacturers] DROP CONSTRAINT [' + @var10 + '];');
ALTER TABLE [AppManufacturers] ALTER COLUMN [CoverPicture] nvarchar(250) NULL;
GO

DECLARE @var11 sysname;
SELECT @var11 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AppManufacturers]') AND [c].[name] = N'Country');
IF @var11 IS NOT NULL EXEC(N'ALTER TABLE [AppManufacturers] DROP CONSTRAINT [' + @var11 + '];');
ALTER TABLE [AppManufacturers] ALTER COLUMN [Country] nvarchar(max) NULL;
GO

DECLARE @var12 sysname;
SELECT @var12 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AppInventoryTicketItems]') AND [c].[name] = N'BatchNumber');
IF @var12 IS NOT NULL EXEC(N'ALTER TABLE [AppInventoryTicketItems] DROP CONSTRAINT [' + @var12 + '];');
ALTER TABLE [AppInventoryTicketItems] ALTER COLUMN [BatchNumber] varchar(50) NULL;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230903002758_updatevisibilitySpellColumn', N'7.0.10');
GO

COMMIT;
GO

