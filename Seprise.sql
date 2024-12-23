
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
(30,'Empleado','1234',121),
(31,'Medico','1234',122);

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

('Carlos Gómez', 12345678, '1985-04-10', 39, 'Masculino', '123-456-7890', 'Calle 123, Ciudad A', 'carlos.gomez@ejemplo.com', 'Casado',
CONCAT(
        '\n\nREGISTRO DE ATENCIÓN MÉDICA DE FECHA: 04/11/2024', 
        '\n--------------------------------------------------------------', 
        '\n\nMotivo de la consulta:\nDolor en la parte baja de la espalda.', 
        '\n\nHistoria Médica:\nAntecedentes de lumbalgia crónica.', 
        '\n\nExamen Físico:\nSensibilidad y dolor moderado en la zona lumbar.', 
        '\n\nDiagnóstico:\nLumbalgia crónica.', 
        '\n\nTratamiento:\nFisioterapia y ejercicios de estiramiento.', 
        '\n\nNotas:\nConsulta de seguimiento en dos semanas.', 
        '\n\nMédico: Dr. María López', 
        '\nHora: 15:30'
    ), 'Obra Social Salud Integral - Tel: 0800-123-4567'),
('Laura Sánchez', 23456789, '1990-08-15', 34, 'Femenino', '234-567-8901', 'Avenida 456, Ciudad B', 'laura.sanchez@ejemplo.com', 'Soltero', CONCAT(
        '\n\nREGISTRO DE ATENCIÓN MÉDICA DE FECHA: 04/11/2024', 
        '\n--------------------------------------------------------------', 
        '\n\nMotivo de la consulta:\nTos persistente y dificultad para respirar.', 
        '\n\nHistoria Médica:\nAntecedentes de asma.', 
        '\n\nExamen Físico:\nRespiración sibilante y aumento de la frecuencia respiratoria.', 
        '\n\nDiagnóstico:\nExacerbación asmática.', 
        '\n\nTratamiento:\nAumento en el uso del inhalador.', 
        '\n\nNotas:\nConsulta de seguimiento en una semana.', 
        '\n\nMédico: Dr. Juan Pérez', 
        '\nHora: 10:45'
    ), 'Obra Social Vida Saludable - Tel: 0800-234-5678'),
('Ana Rodríguez', 34567890, '1975-02-20', 49, 'Femenino', '345-678-9012', 'Calle 789, Ciudad C', 'ana.rodriguez@ejemplo.com', 'Divorciado', CONCAT(
        '\n\nREGISTRO DE ATENCIÓN MÉDICA DE FECHA: 04/11/2024', 
        '\n--------------------------------------------------------------', 
        '\n\nMotivo de la consulta:\nDolor de cabeza recurrente.', 
        '\n\nHistoria Médica:\nBajo estrés laboral.', 
        '\n\nExamen Físico:\nPresión arterial normal.', 
        '\n\nDiagnóstico:\nCefalea tensional.', 
        '\n\nTratamiento:\nAnalgésicos y técnicas de relajación.', 
        '\n\nNotas:\nConsulta de seguimiento en cuatro semanas.', 
        '\n\nMédico: Dra. Ana Torres', 
        '\nHora: 16:00'
    ), 'Obra Social Bienestar Total - Tel: 0800-345-6789'),
('Jorge López', 45678901, '1988-12-05', 35, 'Masculino', '456-789-0123', 'Pasaje 321, Ciudad D', 'jorge.lopez@ejemplo.com', 'Casado', CONCAT(
        '\n\nREGISTRO DE ATENCIÓN MÉDICA DE FECHA: 04/11/2024', 
        '\n--------------------------------------------------------------', 
        '\n\nMotivo de la consulta:\nFiebre y tos seca.', 
        '\n\nHistoria Médica:\nSin antecedentes significativos.', 
        '\n\nExamen Físico:\nFiebre de 38.5 °C.', 
        '\n\nDiagnóstico:\nInfección respiratoria viral probable.', 
        '\n\nTratamiento:\nReposo y medicamentos para la fiebre.', 
        '\n\nNotas:\nConsulta de seguimiento si no mejora.', 
        '\n\nMédico: Dr. Carlos Gómez', 
        '\nHora: 11:30'
    ), 'Obra Social Salud Activa - Tel: 0800-456-7890'),
('María Fernández', 56789012, '1995-07-25', 29, 'Femenino', '567-890-1234', 'Calle 654, Ciudad E', 'maria.fernandez@ejemplo.com', 'Soltero', CONCAT(
        '\n\nREGISTRO DE ATENCIÓN MÉDICA DE FECHA: 04/11/2024', 
        '\n--------------------------------------------------------------', 
        '\n\nMotivo de la consulta:\nDolor en el pecho.', 
        '\n\nHistoria Médica:\nHipertensión controlada.', 
        '\n\nExamen Físico:\nPresión arterial de 145/90 mmHg.', 
        '\n\nDiagnóstico:\nDolor torácico de origen no cardíaco.', 
        '\n\nTratamiento:\nEstudios adicionales y antihipertensivos.', 
        '\n\nNotas:\nConsulta de seguimiento si hay signos de alerta.', 
        '\n\nMédico: Dra. Claudia Méndez', 
        '\nHora: 14:00'
    ), 'Obra Social Cuidado Completo - Tel: 0800-567-8901'),
('Pedro Martínez', 67890123, '1982-03-15', 42, 'Masculino', '678-901-2345', 'Calle 101, Ciudad F', 'pedro.martinez@ejemplo.com', 'Casado', CONCAT(
        '\n\nREGISTRO DE ATENCIÓN MÉDICA DE FECHA: 04/11/2024', 
        '\n--------------------------------------------------------------', 
        '\n\nMotivo de la consulta:\nSíntomas de alergia estacional.', 
        '\n\nHistoria Médica:\nSin antecedentes médicos importantes.', 
        '\n\nExamen Físico:\nCongestión nasal y estornudos.', 
        '\n\nDiagnóstico:\nRinitis alérgica.', 
        '\n\nTratamiento:\nAntihistamínicos y recomendaciones ambientales.', 
        '\n\nNotas:\nSeguimiento si no mejora en 10 días.', 
        '\n\nMédico: Dr. Felipe Suárez', 
        '\nHora: 09:15'
    ), 'Obra Social Salud y Vida - Tel: 0800-678-9012'),
('Sofía Ruiz', 78901234, '1993-06-20', 31, 'Femenino', '789-012-3456', 'Boulevard 202, Ciudad G', 'sofia.ruiz@ejemplo.com', 'Soltero', CONCAT(
        '\n\nREGISTRO DE ATENCIÓN MÉDICA DE FECHA: 04/11/2024', 
        '\n--------------------------------------------------------------', 
        '\n\nMotivo de la consulta:\nDolor articular en rodillas.', 
        '\n\nHistoria Médica:\nAntecedentes de artritis.', 
        '\n\nExamen Físico:\nInflamación en ambas rodillas.', 
        '\n\nDiagnóstico:\nArtritis leve.', 
        '\n\nTratamiento:\nMedicamentos antiinflamatorios y terapia física.', 
        '\n\nNotas:\nConsulta de seguimiento en un mes.', 
        '\n\nMédico: Dr. Andrés Ramírez', 
        '\nHora: 13:00'
    ), 'Obra Social Mejor Salud - Tel: 0800-789-0123'),
('Ricardo Gómez', 89012345, '1980-09-12', 44, 'Masculino', '890-123-4567', 'Avenida 303, Ciudad H', 'ricardo.gomez@ejemplo.com', 'Divorciado', CONCAT(
        '\n\nREGISTRO DE ATENCIÓN MÉDICA DE FECHA: 04/11/2024', 
        '\n--------------------------------------------------------------', 
        '\n\nMotivo de la consulta:\nProblemas gastrointestinales.', 
        '\n\nHistoria Médica:\nSin antecedentes relevantes.', 
        '\n\nExamen Físico:\nSensibilidad abdominal leve.', 
        '\n\nDiagnóstico:\nGastroenteritis leve.', 
        '\n\nTratamiento:\nHidratación y dieta blanda.', 
        '\n\nNotas:\nConsulta si los síntomas persisten.', 
        '\n\nMédico: Dr. Mario Torres', 
        '\nHora: 11:00'
    ), 'Obra Social Salud y Bienestar - Tel: 0800-890-1234'),
('Valentina Castro', 90123456, '1991-05-30', 33, 'Femenino', '901-234-5678', 'Calle 111, Ciudad I', 'valentina.castro@ejemplo.com', 'Soltero', CONCAT(
        '\n\nREGISTRO DE ATENCIÓN MÉDICA DE FECHA: 04/11/2024', 
        '\n--------------------------------------------------------------', 
        '\n\nMotivo de la consulta:\nCansancio extremo y debilidad.', 
        '\n\nHistoria Médica:\nSin antecedentes relevantes.', 
        '\n\nExamen Físico:\nPérdida de peso y palpitaciones.', 
        '\n\nDiagnóstico:\nPosible hipotiroidismo.', 
        '\n\nTratamiento:\nExámenes de sangre y consulta con endocrinología.', 
        '\n\nNotas:\nConsulta de seguimiento en dos semanas.', 
        '\n\nMédico: Dra. Patricia López', 
        '\nHora: 12:15'
    ), 'Obra Social Equilibrio Total - Tel: 0800-901-2345'),

('Lucas Martínez', 87654321, '2005-03-18', 19, 'Masculino', '1123456789', 'Av. Siempreviva 123, Springfield', 'lucasmartinez@gmail.com', 'Soltero',
CONCAT(
    '\n\nREGISTRO DE ATENCIÓN MÉDICA DE FECHA: 06/11/2024',
    '\n--------------------------------------------------------------',
    '\n\nMotivo de la consulta:\nDolor de rodilla tras practicar fútbol.',
    '\n\nHistoria Médica:\nAlergia al polen, fractura de muñeca a los 10 años.',
    '\n\nExamen Físico:\nEdema e inflamación en la rodilla derecha.',
    '\n\nDiagnóstico:\nEsguince de rodilla.',
    '\n\nTratamiento:\nReposo, hielo, compresión y elevación.',
    '\n\nNotas:\nControl en una semana.',
    '\n\nMédico: Dr. Juan Pérez',
    '\nHora: 15:00'
), 'Swiss Medical - Tel: 0810-222-6733'),

('Sofía González', 19348678, '1962-05-15', 62, 'Femenino', '1145678901', 'Calle Las Heras 456, Buenos Aires', 'sofiagonzalez@hotmail.com', 'Viudo',
    CONCAT(
        '\n\nREGISTRO DE ATENCIÓN MÉDICA DE FECHA: 06/11/2024',
        '\n--------------------------------------------------------------',
        '\n\nMotivo de la consulta:\nDificultad para respirar y tos crónica.',
        '\n\nHistoria Médica:\nHipertensión arterial, fumador activo, cirugía de cataratas.',
        '\n\nExamen Físico:\nRuidos respiratorios anormales.',
        '\n\nDiagnóstico:\nEnfermedad pulmonar obstructiva crónica (EPOC).',
        '\n\nTratamiento:\nBroncodilatadores, oxigenoterapia.',
        '\n\nNotas:\nControl periódico y seguimiento con neumólogo.',
        '\n\nMédico: Dra. María López',
        '\nHora: 10:30'
    ), 'Galeno - Tel: 0800-123-4567'),
    ('Diego Fernández', 98765432, '1975-11-25', 49, 'Masculino', '1134567890', 'Calle Corrientes 123, Buenos Aires', 'diego.fernandez@gmail.com', 'Casado',
    CONCAT(
        '\n\nREGISTRO DE ATENCIÓN MÉDICA DE FECHA: 07/11/2024',
        '\n--------------------------------------------------------------',
        '\n\nMotivo de la consulta:\nDolor de pecho y dificultad para respirar.',
        '\n\nHistoria Médica:\nHipertensión arterial, colesterol alto, padre con infarto a los 55 años.',
        '\n\nExamen Físico:\nRuidos cardíacos anormales.',
        '\n\nDiagnóstico:\nAngina de pecho.',
        '\n\nTratamiento:\nNitroglicerina sublingual, aspirina, betabloqueantes.',
        '\n\nNotas:\nDerivación a cardiología para cateterismo.',
        '\n\nMédico: Dr. Carlos Ramírez',
        '\nHora: 11:00'
    ), 'Swiss Medical - Tel: 0810-222-6733');





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
    pago ENUM ('Particular', 'Obra Social', ""),
    estado ENUM('disponible', 'reservado', 'cancelado', 'ratificado', 'vencido', 'en curso', 'atendido')
);

INSERT INTO turnos (consultorio, medico, especialidad, paciente, fecha, hora_inicio, hora_fin, turno_periodo, duracion, pago, estado) 
VALUES

    (1, 'Diego Laso', 'Kinesiologia *', 12345678, CURDATE(), '08:00:00', '09:00:00', 'mañana', 60, '', 'reservado'),
    (1, 'Diego Laso', 'Kinesiologia *', 23456789, CURDATE(), '09:00:00', '10:00:00', 'mañana', 60, '', 'reservado'),
    (1, 'Diego Laso', 'Kinesiologia *', 0, CURDATE(), '10:00:00', '11:00:00', 'mañana', 60, '', 'disponible'),
    (1, 'Diego Laso', 'Kinesiologia *', 0, CURDATE(), '11:00:00', '12:00:00', 'mañana', 60, '', 'disponible'),
    (1, 'Diego Laso', 'Kinesiologia *', 0, CURDATE(), '12:00:00', '13:00:00', 'mañana', 60, '', 'disponible'),
    (1, 'Diego Laso', 'Kinesiologia *', 0, CURDATE(), '13:00:00', '14:00:00', 'mañana', 60, '', 'disponible'),


    (4, 'Luis Rodríguez', 'Traumatología', 0, CURDATE(), '08:00:00', '08:30:00', 'mañana', 30, '', 'disponible'),
    (4, 'Luis Rodríguez', 'Traumatología', 0, CURDATE(), '08:30:00', '09:00:00', 'mañana', 30, '', 'disponible'),
    (4, 'Luis Rodríguez', 'Traumatología', 0, CURDATE(), '09:00:00', '09:30:00', 'mañana', 30, '', 'disponible'),
    (4, 'Luis Rodríguez', 'Traumatología', 0, CURDATE(), '09:30:00', '10:00:00', 'mañana', 30, '', 'disponible'),
    (4, 'Luis Rodríguez', 'Traumatología', 0, CURDATE(), '10:00:00', '10:30:00', 'mañana', 30, '', 'disponible'),
    (4, 'Luis Rodríguez', 'Traumatología', 78901234, CURDATE(), '10:30:00', '11:00:00', 'mañana', 30, '', 'reservado'),
    (4, 'Luis Rodríguez', 'Traumatología', 89012345, CURDATE(), '11:00:00', '11:30:00', 'mañana', 30, '', 'reservado'),
    (4, 'Luis Rodríguez', 'Traumatología', 0, CURDATE(), '11:30:00', '12:00:00', 'mañana', 30, '', 'disponible'),
    (4, 'Luis Rodríguez', 'Traumatología', 0, CURDATE(), '12:00:00', '12:30:00', 'mañana', 30, '', 'disponible'),
    (4, 'Luis Rodríguez', 'Traumatología', 0, CURDATE(), '12:30:00', '13:00:00', 'mañana', 30, '', 'disponible'),
    (4, 'Luis Rodríguez', 'Traumatología', 0, CURDATE(), '13:00:00', '13:30:00', 'mañana', 30, '', 'disponible'),
    (4, 'Luis Rodríguez', 'Traumatología', 0, CURDATE(), '13:30:00', '14:00:00', 'mañana', 30, '', 'disponible'),

    (5, 'María López', 'Ginecología', 90123456, CURDATE(), '08:00:00', '08:30:00', 'mañana', 30, '', 'reservado'),
    (5, 'María López', 'Ginecología', 0, CURDATE(), '08:30:00', '09:00:00', 'mañana', 30, '', 'disponible'),
    (5, 'María López', 'Ginecología', 0, CURDATE(), '09:00:00', '09:30:00', 'mañana', 30, '', 'disponible'),
    (5, 'María López', 'Ginecología', 0, CURDATE(), '09:30:00', '10:00:00', 'mañana', 30, '', 'disponible'),
    (5, 'María López', 'Ginecología', 0, CURDATE(), '10:00:00', '10:30:00', 'mañana', 30, '', 'disponible'),
    (5, 'María López', 'Ginecología', 0, CURDATE(), '10:30:00', '11:00:00', 'mañana', 30, '', 'disponible'),
    (5, 'María López', 'Ginecología', 12345678, CURDATE(), '11:00:00', '11:30:00', 'mañana', 30, '', 'reservado'),
    (5, 'María López', 'Ginecología', 0, CURDATE(), '11:30:00', '12:00:00', 'mañana', 30, '', 'disponible'),
    (5, 'María López', 'Ginecología', 0, CURDATE(), '12:00:00', '12:30:00', 'mañana', 30, '', 'disponible'),
    (5, 'María López', 'Ginecología', 0, CURDATE(), '12:30:00', '13:00:00', 'mañana', 30, '', 'disponible'),
    (5, 'María López', 'Ginecología', 0, CURDATE(), '13:00:00', '13:30:00', 'mañana', 30, '', 'disponible'),
    (5, 'María López', 'Ginecología', 0, CURDATE(), '13:30:00', '14:00:00', 'mañana', 30, '', 'disponible'),

  
    (2, 'Javier Sánchez', 'Neurología', 56789012, CURDATE(), '14:00:00', '14:30:00', 'tarde', 30, '', 'cancelado'),
    (2, 'Javier Sánchez', 'Neurología', 23456789, CURDATE(), '14:00:00', '14:30:00', 'tarde', 30, '', 'ratificado'),
    (2, 'Javier Sánchez', 'Neurología', 0, CURDATE(), '14:30:00', '15:00:00', 'tarde', 30, '', 'disponible'),
    (2, 'Javier Sánchez', 'Neurología', 0, CURDATE(), '15:00:00', '15:30:00', 'tarde', 30, '', 'disponible'),
    (2, 'Javier Sánchez', 'Neurología', 45678901, CURDATE(), '15:30:00', '16:00:00', 'tarde', 30, '', 'reservado'),
    (2, 'Javier Sánchez', 'Neurología', 0, CURDATE(), '16:00:00', '16:30:00', 'tarde', 30, '', 'disponible'),
    (2, 'Javier Sánchez', 'Neurología', 12345678, CURDATE(), '16:30:00', '17:00:00', 'tarde', 30, '', 'reservado'),
    (2, 'Javier Sánchez', 'Neurología', 0, CURDATE(), '17:00:00', '17:30:00', 'tarde', 30, '', 'disponible'),
    (2, 'Javier Sánchez', 'Neurología', 0, CURDATE(), '17:30:00', '18:00:00', 'tarde', 30, '', 'disponible'),
    (2, 'Javier Sánchez', 'Neurología', 0, CURDATE(), '18:00:00', '18:30:00', 'tarde', 30, '', 'disponible'),
    (2, 'Javier Sánchez', 'Neurología', 0, CURDATE(), '18:30:00', '19:00:00', 'tarde', 30, '', 'disponible'),
    (2, 'Javier Sánchez', 'Neurología', 0, CURDATE(), '19:00:00', '19:30:00', 'tarde', 30, '', 'disponible'),
    (2, 'Javier Sánchez', 'Neurología', 0, CURDATE(), '19:30:00', '20:00:00', 'tarde', 30, '', 'disponible');