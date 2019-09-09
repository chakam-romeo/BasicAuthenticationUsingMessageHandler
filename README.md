# BasicAuthenticationUsingMessageHandler
Authentification basic avec mesage andler

#creation de la base de données
pour commencer vous devez créer une base de données SQL ApiAuth avec la table suivante Users
USE [ApiAuth]
GO

/****** Object:  Table [dbo].[Users]    Script Date: 09/09/2019 10:08:30 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Users](
	[UserID] [int] NOT NULL,
	[UserName] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[Name] [nvarchar](50) NULL,
	[UserEmailID] [nvarchar](50) NULL,
	[UserRoles] [nvarchar](50) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

Après la création de votre base de données et table, entrez quelque enregistrement

#Pour le test utiliser postman ou votre navigateur 

Entrer l'adresse de l'api suivit de /api/Test dans le header, entrer la valeur en base 64 du coupe login:password

soit base64(login:password) la chaine obtenu doit être ajouter dans le header à la variable autorization comme suivant

Authorization: basic votre chaine convertie en base64





