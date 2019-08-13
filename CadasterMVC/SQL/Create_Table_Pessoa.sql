CREATE TABLE [Cadaster].[dbo].[Pessoa] 
	(
		Id					BIGINT			PRIMARY KEY IDENTITY,
		Nome				VARCHAR(100)	NOT NULL,
		Empresa				VARCHAR(100)	NOT NULL,
		Contato				VARCHAR(100)	NOT NULL,
		Sexo				VARCHAR(20)				,
		DataCriacao			DATETIME		NOT NULL,
		UltimaAtualizacao	DATETIME
	)

INSERT INTO
	Cadaster..Pessoa (Nome, Empresa, Contato, Sexo, DataCriacao, UltimaAtualizacao)
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