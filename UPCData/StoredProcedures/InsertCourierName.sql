CREATE PROCEDURE [dbo].[InsertCourierName]
	@name nvarchar(128)
AS
	INSERT INTO [dbo].[CourierName]([Value]) VALUES (@name)
