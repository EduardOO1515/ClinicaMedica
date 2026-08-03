CREATE DATABASE ClinicaMedica;
GO

USE ClinicaMedica;
GO

-- 2. TABLA: Usuarios
CREATE TABLE Usuarios
(
    IdUsuario     INT             IDENTITY(1,1) NOT NULL,
    Usuario       VARCHAR(50)     NOT NULL,
    Contrasena    VARCHAR(255)    NOT NULL,
    CONSTRAINT PK_Usuarios PRIMARY KEY (IdUsuario),
    CONSTRAINT UQ_Usuarios_Usuario UNIQUE (Usuario)
);
GO

-- 3. TABLA: Especialidades
CREATE TABLE Especialidades
(
    IdEspecialidad  INT           IDENTITY(1,1) NOT NULL,
    Nombre          VARCHAR(80)   NOT NULL,
    Descripcion     VARCHAR(255)  NULL,
    CONSTRAINT PK_Especialidades PRIMARY KEY (IdEspecialidad),
    CONSTRAINT UQ_Especialidades_Nombre UNIQUE (Nombre)
);
GO

-- 4. TABLA: Doctores
CREATE TABLE Doctores
(
    IdDoctor        INT           IDENTITY(1,1) NOT NULL,
    Cedula          CHAR(11)      NOT NULL,
    Nombre          VARCHAR(60)   NOT NULL,
    Apellido        VARCHAR(60)   NOT NULL,
    IdEspecialidad  INT           NOT NULL,
    Telefono        VARCHAR(10)   NOT NULL,
    Email           VARCHAR(100)  NOT NULL,
    CONSTRAINT PK_Doctores PRIMARY KEY (IdDoctor),
    CONSTRAINT UQ_Doctores_Cedula UNIQUE (Cedula),
    CONSTRAINT UQ_Doctores_Email UNIQUE (Email),
    CONSTRAINT FK_Doctores_Especialidades FOREIGN KEY (IdEspecialidad) REFERENCES Especialidades (IdEspecialidad)
);
GO

-- 5. TABLA: Pacientes
CREATE TABLE Pacientes
(
    IdPaciente       INT           IDENTITY(1,1) NOT NULL,
    Cedula           CHAR(11)      NOT NULL,
    Nombre           VARCHAR(60)   NOT NULL,
    Apellido         VARCHAR(60)   NOT NULL,
    FechaNacimiento  DATE          NOT NULL,
    Telefono         VARCHAR(10)   NOT NULL,
    TieneSeguro      BIT           NOT NULL DEFAULT 0,
    CONSTRAINT PK_Pacientes PRIMARY KEY (IdPaciente),
    CONSTRAINT UQ_Pacientes_Cedula UNIQUE (Cedula),
    CONSTRAINT CK_Pacientes_FechaNacimiento CHECK (FechaNacimiento <= GETDATE())
);
GO

-- 6. TABLA: Citas
CREATE TABLE Citas
(
    IdCita              INT           IDENTITY(1,1) NOT NULL,
    IdPaciente          INT           NOT NULL,
    IdDoctor            INT           NOT NULL,
    FechaCita           DATETIME      NOT NULL,
    Estado              VARCHAR(15)   NOT NULL DEFAULT 'Pendiente',
    TipoConsulta        VARCHAR(15)   NOT NULL,
    Costo               DECIMAL(10,2) NOT NULL DEFAULT 0,
    RecordatorioEnviado BIT           NOT NULL DEFAULT 0,
    CONSTRAINT PK_Citas PRIMARY KEY (IdCita),
    CONSTRAINT FK_Citas_Pacientes FOREIGN KEY (IdPaciente)
        REFERENCES Pacientes (IdPaciente),
    CONSTRAINT FK_Citas_Doctores FOREIGN KEY (IdDoctor)
        REFERENCES Doctores (IdDoctor),
    CONSTRAINT CK_Citas_Estado CHECK (Estado IN ('Pendiente','Confirmada','Cancelada','Completada')),
    CONSTRAINT CK_Citas_TipoConsulta CHECK (TipoConsulta IN ('General','Especialista','Control','Emergencia')),
    CONSTRAINT CK_Citas_Costo CHECK (Costo >= 0)
);
GO

-- 7. TABLA: Expedientes
CREATE TABLE Expedientes
(
    IdExpediente   INT           IDENTITY(1,1) NOT NULL,
    IdPaciente     INT           NOT NULL,
    IdCita         INT           NOT NULL,
    Diagnostico    VARCHAR(500)  NOT NULL,
    Tratamiento    VARCHAR(500)  NULL,
    FechaRegistro  DATETIME      NOT NULL DEFAULT GETDATE(),
    CONSTRAINT PK_Expedientes PRIMARY KEY (IdExpediente),
    CONSTRAINT UQ_Expedientes_Cita UNIQUE (IdCita),
    CONSTRAINT FK_Expedientes_Pacientes FOREIGN KEY (IdPaciente)
        REFERENCES Pacientes (IdPaciente),
    CONSTRAINT FK_Expedientes_Citas FOREIGN KEY (IdCita)
        REFERENCES Citas (IdCita)
);
GO

-- 8. TABLA: Proveedores
CREATE TABLE Proveedores
(
    IdProveedor  INT           IDENTITY(1,1) NOT NULL,
    Nombre       VARCHAR(100)  NOT NULL,
    Telefono     VARCHAR(10)   NOT NULL,
    Email        VARCHAR(100)  NOT NULL,
    CONSTRAINT PK_Proveedores PRIMARY KEY (IdProveedor),
    CONSTRAINT UQ_Proveedores_Email UNIQUE (Email)
);
GO

-- 9. TABLA: Medicamentos
CREATE TABLE Medicamentos
(
    IdMedicamento     INT           IDENTITY(1,1) NOT NULL,
    IdProveedor       INT           NOT NULL,
    Nombre            VARCHAR(100)  NOT NULL,
    Presentacion      VARCHAR(50)   NOT NULL,
    Concentracion     VARCHAR(50)   NOT NULL,
    Stock             INT           NOT NULL DEFAULT 0,
    Precio            DECIMAL(10,2) NOT NULL DEFAULT 0,
    FechaVencimiento  DATE          NOT NULL,
    CONSTRAINT PK_Medicamentos PRIMARY KEY (IdMedicamento),
    CONSTRAINT FK_Medicamentos_Proveedores FOREIGN KEY (IdProveedor)
        REFERENCES Proveedores (IdProveedor),
    CONSTRAINT CK_Medicamentos_Stock CHECK (Stock >= 0),
    CONSTRAINT CK_Medicamentos_Precio CHECK (Precio >= 0)
);
GO

-- 10. TABLA: Recetas
CREATE TABLE Recetas
(
    IdReceta      INT           IDENTITY(1,1) NOT NULL,
    IdCita        INT           NOT NULL,
    Fecha         DATETIME      NOT NULL DEFAULT GETDATE(),
    Indicaciones  VARCHAR(500)  NULL,
    CONSTRAINT PK_Recetas PRIMARY KEY (IdReceta),
    CONSTRAINT UQ_Recetas_Cita UNIQUE (IdCita),
    CONSTRAINT FK_Recetas_Citas FOREIGN KEY (IdCita) REFERENCES Citas (IdCita)
);
GO

-- 11. TABLA: DetalleReceta
CREATE TABLE DetalleReceta
(
    IdDetalle      INT           IDENTITY(1,1) NOT NULL,
    IdReceta       INT           NOT NULL,
    IdMedicamento  INT           NOT NULL,
    Dosis          VARCHAR(50)   NOT NULL,
    Frecuencia     VARCHAR(50)   NOT NULL,
    Duracion       VARCHAR(50)   NOT NULL,
    Observaciones  VARCHAR(255)  NULL,
    CONSTRAINT PK_DetalleReceta PRIMARY KEY (IdDetalle),
    CONSTRAINT FK_DetalleReceta_Recetas FOREIGN KEY (IdReceta)
        REFERENCES Recetas (IdReceta),
    CONSTRAINT FK_DetalleReceta_Medicamentos FOREIGN KEY (IdMedicamento) REFERENCES Medicamentos (IdMedicamento)
);
GO


--12. DATOS DE PRUEBA
    

INSERT INTO Especialidades (Nombre, Descripcion) VALUES
('Medicina General', 'Consultas generales y chequeos de rutina'),
('Pediatria', 'Atencion medica infantil'),
('Cardiologia', 'Enfermedades del corazon y sistema circulatorio'),
('Dermatologia', 'Enfermedades de la piel'),
('Ginecologia', 'Salud reproductiva femenina');
GO

INSERT INTO Usuarios (Usuario, Contrasena) VALUES
('admin', 'admin123'),
('recepcion1', 'recep2024'),
('drmartinez', 'doc12345');
GO

INSERT INTO Doctores (Cedula, Nombre, Apellido, IdEspecialidad, Telefono, Email) VALUES
('40212345671', 'Carlos', 'Martinez', 1, '8091234567', 'cmartinez@clinica.com'),
('40298765432', 'Ana', 'Rodriguez', 2, '8092345678', 'arodriguez@clinica.com'),
('40255566677', 'Luis', 'Fernandez', 3, '8093456789', 'lfernandez@clinica.com'),
('40211122233', 'Maria', 'Gomez', 4, '8094567890', 'mgomez@clinica.com'),
('40244455566', 'Sofia', 'Perez', 5, '8095678901', 'sperez@clinica.com');
GO

INSERT INTO Pacientes (Cedula, Nombre, Apellido, FechaNacimiento, Telefono, TieneSeguro) VALUES
('00112345678', 'Pedro', 'Gonzalez', '1990-05-14', '8291112233', 1),
('00187654321', 'Laura', 'Diaz', '1985-11-02', '8292223344', 0),
('00156789012', 'Jose', 'Ramirez', '2000-01-30', '8293334455', 1),
('00198765123', 'Carla', 'Torres', '1995-07-19', '8294445566', 0),
('00165432198', 'Miguel', 'Santos', '1978-03-25', '8295556677', 1);
GO

INSERT INTO Proveedores (Nombre, Telefono, Email) VALUES
('Farmaquimica Dominicana', '8096001122', 'ventas@farmaquimica.com'),
('Distribuidora Medica RD', '8096003344', 'contacto@distmedica.com'),
('Laboratorios del Caribe', '8096005566', 'info@labcaribe.com');
GO

INSERT INTO Medicamentos (IdProveedor, Nombre, Presentacion, Concentracion, Stock, Precio, FechaVencimiento) VALUES
(1, 'Paracetamol', 'Tableta', '500mg', 200, 45.50, '2027-06-30'),
(1, 'Amoxicilina', 'Capsula', '500mg', 150, 120.00, '2026-12-15'),
(2, 'Ibuprofeno', 'Tableta', '400mg', 180, 60.00, '2027-03-20'),
(2, 'Loratadina', 'Tableta', '10mg', 100, 75.25, '2026-10-10'),
(3, 'Omeprazol', 'Capsula', '20mg', 90, 95.00, '2027-01-05');
GO

INSERT INTO Citas (IdPaciente, IdDoctor, FechaCita, Estado, TipoConsulta, Costo, RecordatorioEnviado) VALUES
(1, 1, '2026-08-01 09:00', 'Confirmada', 'General', 1500.00, 0),
(2, 3, '2026-08-02 10:30', 'Pendiente', 'Especialista', 3000.00, 0),
(3, 2, '2026-08-03 11:00', 'Completada', 'Control', 1200.00, 1),
(4, 4, '2026-08-04 14:00', 'Cancelada', 'General', 1500.00, 0),
(5, 5, '2026-08-05 15:30', 'Completada', 'Emergencia', 3500.00, 1);
GO

INSERT INTO Expedientes (IdPaciente, IdCita, Diagnostico, Tratamiento) VALUES
(3, 3, 'Hipertension controlada', 'Continuar tratamiento actual y control mensual'),
(5, 5, 'Infeccion respiratoria aguda', 'Reposo, hidratacion y antibiotico');
GO

INSERT INTO Recetas (IdCita, Indicaciones) VALUES
(3, 'Tomar medicamento en ayunas cada manana'),
(5, 'Completar el tratamiento antibiotico segun lo indicado');
GO

INSERT INTO DetalleReceta (IdReceta, IdMedicamento, Dosis, Frecuencia, Duracion, Observaciones) VALUES
(1, 5, '1 capsula', 'Cada 24 horas', '30 dias', 'Tomar antes del desayuno'),
(2, 2, '1 capsula', 'Cada 8 horas', '7 dias', 'Completar el ciclo completo'),
(2, 1, '1 tableta', 'Cada 6 horas si hay fiebre', '5 dias', 'No exceder 4 tomas al dia');
GO

