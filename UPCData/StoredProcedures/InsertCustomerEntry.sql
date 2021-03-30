CREATE PROCEDURE [dbo].[InsertCustomerEntry]
	@name       NVARCHAR(128),
    @phone      NVARCHAR(128),
    @email      NVARCHAR(128),
    @market     NVARCHAR(128),
    @order      NVARCHAR(128),
    @date       NVARCHAR(128),
    @product    NVARCHAR(128),
    @query      NVARCHAR(128),
    @action     NVARCHAR(128),
    @message    NVARCHAR(128),
    @status     NVARCHAR(128),
    @type       NVARCHAR(128)
AS
INSERT INTO [dbo].[CustomerEntry]
           ([CustomerName]
           ,[Phone]
           ,[Email]
           ,[MarketPlace]
           ,[OrderNumber]
           ,[OrderDate]
           ,[Product]
           ,[Query]
           ,[Action]
           ,[WhatsappMessage]
           ,[Status]
           ,[Type])
     VALUES
           (@name   
           ,@phone  
           ,@email  
           ,@market 
           ,@order  
           ,@date   
           ,@product
           ,@query  
           ,@action 
           ,@message
           ,@status 
           ,@type   )


