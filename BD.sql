create database BD;
use BD;


create table LOGIN
(
	CODIGO int primary key auto_increment,
    USUARIO varchar(50),
    SENHA varchar(50)
);

insert into LOGIN (USUARIO,SENHA) values ('ADMIN','1234567');
select * from LOGIN;
select * from LOGIN where USUARIO = 'ADMIN' and SENHA = '1234567';