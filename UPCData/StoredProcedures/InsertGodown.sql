CREATE PROCEDURE [dbo].[InsertGodown]
	@godown nvarchar(128)
AS
BEGIN
	INSERT INTO Godown([Value])VALUES(@godown);
END