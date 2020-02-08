CREATE External TABLE [dbo].[ExternalTable] 
(  
	 [Id] INT NOT NULL ,
	 [Title]varchar,
	 [price]money
)
WITH
(
   LOCATION='/folder/file',
   DATA_SOURCE=[DataSource1],
   FILE_FORMAT=[FileFormat1]
