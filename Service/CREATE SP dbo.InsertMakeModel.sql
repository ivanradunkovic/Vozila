USE [Make]
GO

/* StoredProcedure [dbo].[InsertMakeModel] */
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[InsertMake]
    @Id int(3),
	@Name nvarchar(50),
    @Abrv nvarchar(50)
AS
IF NOT EXISTS (
					SELECT * FROM [dbo].Make
					WHERE Id = @Id AND Name = @Name AND 
						  Abrv = @Abrv
			  )
BEGIN
    SET NOCOUNT ON;
    INSERT INTO [dbo].[Make]([Id],[Name],[Abrv])
    VALUES(@Id, @Name, @Abrv)
END

ELSE
BEGIN

RAISERROR('Data already exists!', 1, 1) WITH LOG
RETURN -100

END
GO




USE [Model]
GO

/* StoredProcedure [dbo].[InsertMakeModel] */
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[InsertModel]
    @Id int(3),
	@MakeId int (3),
	@Name nvarchar(50),
    @Abrv nvarchar(50)
AS
IF NOT EXISTS (
					SELECT * FROM [dbo].Make
					WHERE Id = @Id AND MakeId = @MakeId AND Name = @Name AND 
						  Abrv = @Abrv
			  )
BEGIN
    SET NOCOUNT ON;
    INSERT INTO [dbo].[Make]([Id],[MakeId],[Name],[Abrv])
    VALUES(@Id, @MakeId, @Name, @Abrv)
END

ELSE
BEGIN

RAISERROR('Data already exists!', 1, 1) WITH LOG
RETURN -100

END
GO
