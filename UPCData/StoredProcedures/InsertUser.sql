CREATE PROCEDURE [dbo].[InsertUser]
	@name nvarchar(128),
	@pass nvarchar(128),
	@role nvarchar(128)
AS
	INSERT INTO [dbo].[User]([Username], [Password], [Role])
	VALUES (@name, @pass, @role)
