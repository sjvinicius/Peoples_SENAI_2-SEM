CREATE DATABASE T_Peoples;
GO

USE T_Peoples;
GO

CREATE TABLE funcionario( 
	idFuncionario INT PRIMARY KEY IDENTITY
	,nome		  VARCHAR(20)	NOT NULL
	,sobrenome	  VARCHAR(20)	NOT NULL
	,dataNasc	  DATETIME		NOT NULL);
GO