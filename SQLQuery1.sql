
Create database teacherDB
GO
Use teacherDB
GO
CREATE TABLE [dbo].[Position] (
    [PositionId] INT          IDENTITY (1, 1) NOT NULL,
    [Position]   VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([PositionId] ASC)
);

INSERT INTO Position (Position) VALUES
('Assistant Professor'),
('Sr Professor'),
('Professor')
GO

CREATE TABLE [dbo].[Teacher] (
    [TeachId]    INT           IDENTITY (1, 1) NOT NULL,
    [TeachCode]  VARCHAR (50)  NULL,
    [TeachName]  VARCHAR (50)  NULL,
    [PositionId] INT           NULL,
    [DOB]        DATE          NULL,
    [Gender]     VARCHAR (50)  NULL,
    [State]      VARCHAR (50)  NULL,
    [ImagePath]  VARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([TeachId] ASC),
    FOREIGN KEY ([PositionId]) REFERENCES [dbo].[Position] ([PositionId])
);

CREATE TABLE [dbo].[TechInstitute] (
    [TechInstId] INT          IDENTITY (1, 1) NOT NULL,
    [TeachId]    INT          NULL,
    [InstName]   VARCHAR (50) NULL,
    [PositionId] INT          NULL,
    [ExpYear]    INT          NULL,
    PRIMARY KEY CLUSTERED ([TechInstId] ASC),
    FOREIGN KEY ([TeachId]) REFERENCES [dbo].[Teacher] ([TeachId]),
    FOREIGN KEY ([PositionId]) REFERENCES [dbo].[Position] ([PositionId])
);
GO
CREATE PROC [dbo].[TeacherAddOrEdit]
@TeachId int,
@TeachCode  VARCHAR (50),
@TeachName VARCHAR (50),
@PositionId INT,
@DOB DATE,
@Gender  VARCHAR (50),
@State varchar(50),
@ImagePath varchar(max)
AS

	--Insert--
	IF @TeachId = 0 BEGIN
		INSERT INTO Teacher(TeachCode,TeachName,PositionId,DOB,Gender,State,ImagePath)
		VALUES(@TeachCode,@TeachName,@PositionId,@DOB,@Gender,@State,@ImagePath)

		SELECT SCOPE_IDENTITY();

		END

	--Update--
	ELSE BEGIN
		UPDATE Teacher
		set
			TeachCode= @TeachCode,
			TeachName=@TeachName,
			PositionId =@PositionId,
			DOB=@DOB,
			Gender=@Gender,
			State=@State,
			ImagePath=@ImagePath
		where TeachId=@TeachId

		select @TeachId;

		END
GO

CREATE PROC TeacherDelete
@TeachId int
AS
 --Master
 DELETE FROM Teacher WHERE TeachId=@TeachId
 --Details
 DELETE FROM TechInstitute WHERE TeachId=@TeachId
 GO

 CREATE PROC TeacherViewAll
AS
SELECT  T.TeachId,T.TeachCode,T.TeachName,P.PositionId,T.DOB,T.State,T.ImagePath FROM Teacher T INNER JOIN
Position P ON T.PositionId=P.PositionId

GO

CREATE PROC TeacherViewByID
@TeachId int
AS
	---Master
	SELECT * FROM Teacher WHERE TeachId = @TeachId
	---Details
	SELECT * FROM TechInstitute WHERE TeachId = @TeachId
GO

CREATE PROC TechInstituteAddOrEdit
@TechInstId INT,
@TeachId INT,
@InstName VARCHAR (50),
@PositionId INT,
@ExpYear INT
AS

--INSERT--
IF @TechInstId=0
	INSERT INTO TechInstitute(TeachId,InstName, PositionId, ExpYear )
	VALUES (@TeachId,@InstName, @PositionId, @ExpYear)

--UPDATE--
ELSE 
	UPDATE TechInstitute 
	SET 
		
		InstName = @InstName,
		PositionId = @PositionId,
		ExpYear=@ExpYear
	WHERE TechInstId =@TechInstId
GO

CREATE PROC TechInstituteDelete
@TechInstId  int
AS
 DELETE FROM TechInstitute WHERE TechInstId=@TechInstId
 GO
 select * from Position