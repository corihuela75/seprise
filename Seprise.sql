
drop database if exists seprise;
create database seprise;
use seprise;

create table roles(
RolUsu int,
NomRol varchar(30),
constraint primary key(RolUsu)
);

insert into roles values
(120,'Administrador'),
(121,'Empleado');

create table usuario(
CodUsu int auto_increment,
NombreUsu varchar (20),
PassUsu varchar (15),
RolUsu int,
Activo boolean default true,
constraint pk_usuario primary key (CodUsu),
constraint fk_usuario foreign key(RolUsu) references roles(RolUsu)
);

insert into usuario(CodUsu,NombreUsu,PassUsu,RolUsu) values
(26,'Admin','1234',120),
(30,'Cristian','1234',120),
(31,'Heber','1234',120);

CREATE TABLE paciente (
    cod_paci INT AUTO_INCREMENT,
    nombre_paci VARCHAR(50) NOT NULL,
    doc_paci INT,
    fecha_nac_paci DATE,
    edad_paci INT,
    genero_paci ENUM('Masculino', 'Femenino', 'Otro'),
    tel_paci VARCHAR(20),
    direccion_paci VARCHAR(100),
    email_paci VARCHAR(100),
    estado_civil_paci ENUM('Soltero', 'Casado', 'Divorciado', 'Viudo', 'Otro'),
    historial_paci TEXT,
    fecha_registro_paci DATETIME DEFAULT CURRENT_TIMESTAMP,
    obra_social_paci VARCHAR(100),
    constraint pk_paciente primary key (cod_paci)
);


