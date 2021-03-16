/*
CREATE DATABASE userDB;
CREATE TABLE Utente (
    Id int IDENTITY(1,1) PRIMARY KEY,
    Nome varchar(20) NOT NULL,
    Cognome varchar(20) NOT NULL,
    Email varchar(20) NOT NULL,
    Password varchar(100) NOT NULL,
	Telefono varchar(15),
	Stato varchar(20) NOT NULL,
	LastLogin datetime
);
*/
/*
INSERT INTO dbo.Utente (Nome,Cognome,Email,Password,Telefono,Stato,LastLogin)
VALUES('Pippo','PLUTO','pippo@gmail.com','pippo123', 0039324026258,'attivo',GETDATE());
*/
--update Utente SET LastLogin = CURRENT_TIMESTAMP where id = 2
SELECT * FROM Utente