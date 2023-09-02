INSERT INTO [dbo].[AppManufacturers]
           ([Id]
           ,[Name]
           ,[Code]
           ,[Slug]
           ,[CoverPicture]
           ,[Visibility]
           ,[IsActive]
           ,[Country]
           ,[ExtraProperties]
           ,[ConcurrencyStamp]
           ,[CreationTime]
           ,[CreatorId])
     VALUES
           (newid()
           ,'Apple'
           ,'123'
           ,'apple'
           ,NULL
           ,1
           ,1
           ,'US'
           ,NULL
           ,NULL
           ,GETDATE()
           ,NULL)


