
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
(121,'Empleado'),
(122,'Medico');

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
    estado_civil_paci ENUM('Soltero', 'Casado', 'Divorciado', 'Viudo', 'Otro', ''),
    historial_paci TEXT,
    fecha_registro_paci DATETIME DEFAULT CURRENT_TIMESTAMP,
    obra_social_paci VARCHAR(100),
    constraint pk_paciente primary key (cod_paci)
);

INSERT INTO paciente (nombre_paci, doc_paci, fecha_nac_paci, edad_paci, genero_paci, tel_paci, direccion_paci, email_paci, estado_civil_paci, historial_paci, obra_social_paci)
VALUES 
('Carlos Gómez', 12345678, '1985-04-10', 39, 'Masculino', '123-456-7890', 'Calle 123, Ciudad A', 'carlos.gomez@ejemplo.com', 'Casado', 'Sin antecedentes importantes.', 'Obra Social 1'),
('Laura Sánchez', 23456789, '1990-08-15', 34, 'Femenino', '234-567-8901', 'Avenida 456, Ciudad B', 'laura.sanchez@ejemplo.com', 'Soltero', 'Alergia a penicilina.', 'Obra Social 2'),
('Ana Rodríguez', 34567890, '1975-02-20', 49, 'Femenino', '345-678-9012', 'Calle 789, Ciudad C', 'ana.rodriguez@ejemplo.com', 'Divorciado', 'Hipertensión controlada.', 'Obra Social 3'),
('Jorge López', 45678901, '1988-12-05', 35, 'Masculino', '456-789-0123', 'Pasaje 321, Ciudad D', 'jorge.lopez@ejemplo.com', 'Casado', 'Diabetes tipo 2.', 'Obra Social 4'),
('María Fernández', 56789012, '1995-07-25', 29, 'Femenino', '567-890-1234', 'Calle 654, Ciudad E', 'maria.fernandez@ejemplo.com', 'Soltero', 'Sin antecedentes.', 'Obra Social 5'),
('Pablo Díaz', 67890123, '2000-03-10', 24, 'Masculino', '678-901-2345', 'Avenida 987, Ciudad F', 'pablo.diaz@ejemplo.com', 'Soltero', 'Antecedente de asma.', 'Obra Social 6'),
('Lucía García', 78901234, '1970-09-30', 54, 'Femenino', '789-012-3456', 'Boulevard 111, Ciudad G', 'lucia.garcia@ejemplo.com', 'Viudo', 'Hipotiroidismo en tratamiento.', 'Obra Social 7'),
('Ricardo Méndez', 89012345, '1983-01-18', 41, 'Masculino', '890-123-4567', 'Callejón 222, Ciudad H', 'ricardo.mendez@ejemplo.com', 'Casado', 'Historial de migrañas.', 'Obra Social 8'),
('Elena Ruiz', 90123456, '1998-11-12', 25, 'Femenino', '901-234-5678', 'Ruta 333, Ciudad I', 'elena.ruiz@ejemplo.com', 'Soltero', 'Sin antecedentes.', 'Obra Social 9'),
('Miguel Torres', 11223344, '1987-05-05', 37, 'Masculino', '112-233-4455', 'Avenida 444, Ciudad J', 'miguel.torres@ejemplo.com', 'Casado', 'Colesterol elevado.', 'Obra Social 10');

CREATE TABLE medico (
    cod_medi INT AUTO_INCREMENT,
    nombre_medi VARCHAR(50) NOT NULL,
    matricula INT,
    especialidad VARCHAR(100),
    tel_medi VARCHAR(20),
    email_medi VARCHAR(100),
    fecha_registro_medi DATETIME DEFAULT CURRENT_TIMESTAMP,
    constraint pk_medico primary key (cod_medi)
);

INSERT INTO medico (nombre_medi, matricula, especialidad, tel_medi, email_medi)
VALUES 
('Diego Laso*', 45633, 'Kinesiologia *', '534-342-9078', 'diego.laso@hospital.com'),
('Monica Chapa**', 34234, 'Psiquiatría **', '534-342-9078', 'diego.laso@hospital.com'),
('Juan Pérez', 123456, 'Cardiología', '123-456-7890', 'juan.perez@hospital.com'),
('Ana García', 234567, 'Pediatría', '234-567-8901', 'ana.garcia@hospital.com'),
('Luis Rodríguez', 345678, 'Traumatología', '345-678-9012', 'luis.rodriguez@hospital.com'),
('María López', 456789, 'Ginecología', '456-789-0123', 'maria.lopez@hospital.com'),
('Carlos Fernández', 567890, 'Oftalmología', '567-890-1234', 'carlos.fernandez@hospital.com'),
('Laura Martínez', 678901, 'Dermatología', '678-901-2345', 'laura.martinez@hospital.com'),
('Javier Sánchez', 789012, 'Neurología', '789-012-3456', 'javier.sanchez@hospital.com'),
('Paula Gómez', 890123, 'Gastroenterología', '890-123-4567', 'paula.gomez@hospital.com'),
('Fernando Díaz', 901234, 'Endocrinología', '901-234-5678', 'fernando.diaz@hospital.com'),
('Sofía Ramírez', 112233, 'Neumonología', '112-233-4455', 'sofia.ramirez@hospital.com');


CREATE TABLE turnos (
    id_turno INT AUTO_INCREMENT PRIMARY KEY,
    consultorio INT,
    medico VARCHAR(50),
	especialidad VARCHAR(100),
    paciente INT,
    fecha DATE,
    hora_inicio TIME,
    hora_fin TIME,
    turno_periodo ENUM('mañana', 'tarde'),
    duracion INT,
    estado ENUM('disponible', 'reservado', 'cancelado')
    # CONSTRAINT fk_medico FOREIGN KEY (medico_id) REFERENCES medico (cod_medi)
    # CONSTRAINT fk_paciente FOREIGN KEY (paciente_id) REFERENCES paciente (cod_paci)
);

INSERT INTO turnos (consultorio, medico, especialidad, paciente, fecha, hora_inicio, hora_fin, turno_periodo, duracion, estado) 
VALUES
    (1, 'Dr. Juan Pérez', 'Cardiología', 1, '2024-11-01', '08:00:00', '08:30:00', 'mañana', '30', 'reservado'),
    (2, 'Dra. Carla López', 'Dermatología', 2, '2024-11-01', '09:00:00', '10:00:00', 'mañana', '60', 'disponible'),
    (1, 'Dr. Miguel Díaz', 'Neurología', 3, '2024-11-02', '14:00:00', '15:30:00', 'tarde', '90', 'cancelado'),
    (3, 'Dr. Luis Suárez', 'Pediatría', 4, '2024-11-03', '10:00:00', '10:30:00', 'mañana', '30', 'reservado'),
    (2, 'Dra. Patricia Ríos', 'Ginecología', 5, '2024-11-04', '16:00:00', '17:00:00', 'tarde', '60', 'disponible');
