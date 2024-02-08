cd/
cd xampp
cd mysql
cd bin

mysql -u root -p

CREATE DATABASE cadastrados;

show databases;

USE cadastrados;

CREATE TABLE dadoscadastrados(
cpf VARCHAR (20) PRIMARY KEY,
nomecompleto VARCHAR (100) NOT NULL,
nomesocial VARCHAR (100) NOT NULL,
cep INT (10) NOT NULL,
numero INT (10) NOT NULL,
complemento VARCHAR (20) NOT NULL
);


DESC TABLE dadoscadastrados;

