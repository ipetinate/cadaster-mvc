CREATE TABLE [Cadaster].[dbo].[Pessoas] 
	(
		[Id]				BIGINT		PRIMARY KEY IDENTITY,
		[Nome]				VARCHAR(100)	NOT NULL,
		[Empresa]			VARCHAR(100)	NOT NULL,
		[Contato]			VARCHAR(100)	NOT NULL,
		[Sexo]				VARCHAR(20)	NULL	,
		[DataCriacao]			DATETIME	NOT NULL DEFAULT GETDATE(),
		[UltimaAtualizacao]		DATETIME	NOT NULL DEFAULT GETDATE(),
	)

INSERT INTO
	[Cadaster].[dbo].[Pessoas] ([Nome], [Empresa], [Contato], [Sexo], [DataCriacao], [UltimaAtualizacao])
VALUES
	(
		  ['Usuario Fulano']
		, ['Empresa']
		, ['usuario@gmail.com']
		, ['Indefinido']
		, [GETDATE()]
		, [GETDATE()]
	)

SELECT * FROM [Cadaster].[dbo].[Pessoas]
GO
