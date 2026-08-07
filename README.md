# ClinicaMedica

Sistema de escritorio para la gestión de una clínica médica, desarrollado en C# con Windows Forms, siguiendo una arquitectura en capas.

## Descripción

ClinicaMedica es una aplicación de escritorio que permite administrar la información de una clínica: pacientes, doctores, especialidades, citas, expedientes, proveedores, medicamentos y recetas. El sistema cuenta con inicio de sesión, un formulario principal de navegación y módulos separados de entrada y consulta de datos.

## Arquitectura

El proyecto está organizado en tres capas:

- **ClinicaMedica.Datos** — Acceso a la base de datos (SQL Server) mediante Microsoft.Data.SqlClient.
- **ClinicaMedica.Negocio** — Lógica de negocio, clases del dominio (herencia, clase abstracta, interfaces).
- **ClinicaMedica.Presentacion** — Interfaz gráfica (Windows Forms).

## Base de datos

Motor: SQL Server. Base de datos `ClinicaMedica` con las siguientes tablas principales:

- Usuarios
- Especialidades
- Doctores
- Pacientes
- Citas
- Expedientes
- Proveedores
- Medicamentos
- Recetas
- DetalleReceta

Incluye claves foráneas, restricciones CHECK y datos de prueba (seed data). El script SQL se encuentra en la raíz del repositorio.

## Funcionalidades principales

- Inicio de sesión con contraseña enmascarada, validado contra la base de datos.
- Formulario principal con menú de navegación (mínimo 5 opciones principales).
- Módulos de **Entrada** (registro de datos) y **Consulta** (visualización de datos) para cada entidad: pacientes, doctores, citas, expedientes, proveedores y medicamentos.
- Sección "Sistema" con la opción "Acerca de", donde se listan los integrantes del grupo.
- Manejo de errores con try/catch para evitar cierres forzados de la aplicación.

## Aspectos técnicos

- Arquitectura en capas (Datos / Negocio / Presentación).
- Herencia y clase abstracta en el modelo de dominio.
- Interfaces y métodos abstractos/virtuales.
- Llamadas asíncronas (async/await) para operaciones de base de datos.
- Formularios diseñados con Windows Forms Designer.
- Código comentado explicando la funcionalidad de cada parte.

## Tecnologías

- C# / .NET 9 (net9.0-windows para Presentación, net9.0 para Datos y Negocio)
- Windows Forms
- SQL Server
- Microsoft.Data.SqlClient

## Integrantes del grupo

- Logan
- Isma
- Rosembert
- Eduardo Paulino
- Rhyan Duquesne

