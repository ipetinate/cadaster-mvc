CREATE TABLE [Cadaster].[dbo].[Pessoa] 
	(
		Id					BIGINT			PRIMARY KEY IDENTITY,
		Nome				VARCHAR(100)	NOT NULL,
		Empresa				VARCHAR(100)	NOT NULL,
		Contato				VARCHAR(100)	NOT NULL,
		Sexo				VARCHAR(20)				,
		DataCriacao			DATETIME		NOT NULL DEFAULT GETDATE(),
		UltimaAtualizacao	DATETIME		NOT NULL DEFAULT GETDATE()
	)

INSERT INTO
	Cadaster..Pessoas (Nome, Empresa, Contato, Sexo, DataCriacao, UltimaAtualizacao)
VALUES
	(
		  'Isac Petinate'
		, 'Viceri'
		, 'idpetinate@gmail.com'
		, 'Masculino'
		, GETDATE()
		, GETDATE()
	)

SELECT * FROM Cadaster..Pessoa
GO