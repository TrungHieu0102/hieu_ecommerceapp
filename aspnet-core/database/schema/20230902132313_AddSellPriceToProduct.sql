BEGIN TRANSACTION;
GO

ALTER TABLE [AppProducts] ADD [sellPrice] float NOT NULL DEFAULT 0.0E0;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230902132313_AddSellPriceToProduct', N'7.0.10');
GO

COMMIT;
GO

