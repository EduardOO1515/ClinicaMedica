CREATE DATABASE ClinicaMedica;
GO
USE ClinicaMedica;
GO

CREATE TABLE Especialidades (
    IdEspecialidad INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(100) NOT NULL,
    Descripcion NVARCHAR(255)
);

CREATE TABLE Doctores (
    IdDoctor INT PRIMARY KEY IDENTITY,
    Cedula NVARCHAR(11) NOT NULL UNIQUE,
    Nombre NVARCHAR(100) NOT NULL,
    Apellido NVARCHAR(100) NOT NULL,
    IdEspecialidad INT FOREIGN KEY REFERENCES Especialidades(IdEspecialidad),
    Telefono NVARCHAR(15),
    Email NVARCHAR(100)
);

CREATE TABLE Pacientes (
    IdPaciente INT PRIMARY KEY IDENTITY,
    Cedula NVARCHAR(11) NOT NULL UNIQUE,
    Nombre NVARCHAR(100) NOT NULL,
    Apellido NVARCHAR(100) NOT NULL,
    FechaNacimiento DATE,
    Telefono NVARCHAR(15),
    TieneSeguro BIT NOT NULL DEFAULT 0
);

CREATE TABLE Citas (
    IdCita INT PRIMARY KEY IDENTITY,
    IdPaciente INT FOREIGN KEY REFERENCES Pacientes(IdPaciente),
    IdDoctor INT FOREIGN KEY REFERENCES Doctores(IdDoctor),
    FechaCita DATETIME NOT NULL,
    Estado NVARCHAR(20) DEFAULT 'Pendiente',
    TipoConsulta NVARCHAR(20) DEFAULT 'General',
    Costo DECIMAL(10,2)
);

CREATE TABLE Expedientes (
    IdExpediente INT PRIMARY KEY IDENTITY,
    IdPaciente INT FOREIGN KEY REFERENCES Pacientes(IdPaciente),
    IdCita INT FOREIGN KEY REFERENCES Citas(IdCita),
    Diagnostico NVARCHAR(500),
    Tratamiento NVARCHAR(500),
    FechaRegistro DATETIME DEFAULT GETDATE()
);

CREATE TABLE Usuarios (
    IdUsuario INT PRIMARY KEY IDENTITY,
    Usuario NVARCHAR(50) NOT NULL UNIQUE,
    Contrasena NVARCHAR(100) NOT NULL,
    Rol NVARCHAR(20) DEFAULT 'Recepcionista'
);

-- Datos de prueba
INSERT INTO Especialidades VALUES ('Medicina General', 'Consultas generales');
INSERT INTO Especialidades VALUES ('Cardiología', 'Enfermedades del corazón');
INSERT INTO Especialidades VALUES ('Pediatría', 'Atención a niños');

INSERT INTO Usuarios VALUES ('admin', 'admin123', 'Administrador');
INSERT INTO Usuarios VALUES ('recepcion', 'recep123', 'Recepcionista');

INSERT INTO Doctores VALUES ('00112233445', 'Carlos', 'Pérez', 1, '8091234567', 'carlos@clinica.com');
INSERT INTO Doctores VALUES ('00998877665', 'María', 'Santos', 2, '8097654321', 'maria@clinica.com');

INSERT INTO Pacientes VALUES ('00111222333', 'Juan', 'Rodríguez', '1990-05-15', '8091112233', 1);
INSERT INTO Pacientes VALUES ('00444555666', 'Ana', 'Martínez', '1985-08-20', '8094445566', 0);
GO