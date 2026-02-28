
CREATE DATABASE CASO_PRACTICO_RESERVACIONES

GO

USE CASO_PRACTICO_RESERVACIONES

GO

CREATE TABLE HABITACIONES (
    Id int identity (1,1) not null,
    CodigoDeHabitacion varchar(7) not null,
    NombreDeHabitacion varchar(30) not null,
	CantidadDeHuespedesPermitidos int not null,
	CantidadDeCamas int not null,
	CantidadDeBanos int not null,
	Ubicacion varchar(10) not null,
	EncargadoDeLimpieza varchar(100) not null,
	TipoDeHabitacion int not null,
	CostoDeLimpieza decimal(18,2) not null,
	CostoDeReserva decimal(18,2) not null,
	FechaDeRegistro datetime not null,
	FechaDeModificacion datetime,
	Estado bit,
);

go

CREATE TABLE RESERVACIONES (
    Id int identity (1,1) not null,
    NombreDeLaPersona varchar(150) not null,
    Identificacion varchar(30) not null,
	Telefono varchar(10) not null,
	Correo varchar(50) not null,
	FechaNacimiento datetime not null,
	Direccion varchar(200) not null,
	MontoTotal decimal(18,2) not null,
	FechaInicioReserva datetime not null,
	FechaFinReserva datetime not null,
	FechaDeRegistro datetime not null,
	IdHabitacion int not null,
);

INSERT INTO HABITACIONES 
(CodigoDeHabitacion, NombreDeHabitacion, CantidadDeHuespedesPermitidos, CantidadDeCamas, CantidadDeBanos, Ubicacion, EncargadoDeLimpieza, TipoDeHabitacion, CostoDeLimpieza, CostoDeReserva, FechaDeRegistro, Estado)
VALUES 
('HAB-101', 'Junior Standard', 2, 1, 1, 'Piso 1', 'Ana Martinez', 1, 15.00, 50.00, GETDATE(), 1),
('HAB-102', 'Junior Standard', 2, 1, 1, 'Piso 1', 'Ana Martinez', 1, 15.00, 50.00, GETDATE(), 1),
('HAB-103', 'Junior Twin', 2, 2, 1, 'Piso 1', 'Juan Perez', 1, 18.00, 60.00, GETDATE(), 1),
('HAB-201', 'Superior Queen', 3, 2, 1, 'Piso 2', 'Juan Perez', 2, 25.00, 85.00, GETDATE(), 1),
('HAB-202', 'Superior Queen', 3, 2, 1, 'Piso 2', 'Carla Gomez', 2, 25.00, 85.00, GETDATE(), 1),
('HAB-203', 'Superior King', 2, 1, 1, 'Piso 2', 'Carla Gomez', 2, 25.00, 95.00, GETDATE(), 1),
('HAB-204', 'Superior Family', 4, 2, 2, 'Piso 2', 'Pedro Ruiz', 2, 30.00, 110.00, GETDATE(), 1),
('HAB-301', 'Presidential Suite', 4, 2, 2, 'Piso 3', 'Marta Lopez', 3, 50.00, 250.00, GETDATE(), 0),
('HAB-302', 'Executive Suite', 2, 1, 2, 'Piso 3', 'Marta Lopez', 3, 45.00, 200.00, GETDATE(), 0),
('HAB-303', 'Honeymoon Suite', 2, 1, 1, 'Piso 3', 'Pedro Ruiz', 3, 60.00, 300.00, GETDATE(), 0);

INSERT INTO RESERVACIONES 
(NombreDeLaPersona, Identificacion, Telefono, Correo, FechaNacimiento, Direccion, MontoTotal, FechaInicioReserva, FechaFinReserva, FechaDeRegistro, IdHabitacion)
VALUES 
('Carlos Rodriguez', '1-1234-5678', '88881111', 'carlos@email.com', '1985-05-12', 'San Jose, Centro', 100.00, '2024-03-01', '2024-03-03', GETDATE(), 1),
('Maria Delgado', '2-0987-0654', '87654321', 'maria@email.com', '1992-10-20', 'Alajuela, San Rafael', 120.00, '2024-03-05', '2024-03-07', GETDATE(), 3),
('Jose Smith', 'PASS-998877', '70701010', 'jose.smith@email.com', '1978-01-15', 'New York, USA', 170.00, '2024-03-10', '2024-03-12', GETDATE(), 4),
('Laura Chinchilla', '3-0444-0555', '83445566', 'laura@email.com', '1990-07-25', 'Cartago, Paraiso', 170.00, '2024-03-15', '2024-03-17', GETDATE(), 5),
('Roberto Gomez', '1-0555-0666', '85554433', 'roberto@email.com', '1980-11-30', 'Heredia, Belen', 500.00, '2024-04-01', '2024-04-03', GETDATE(), 8),
('Elena Valerio', '6-0222-0333', '60604040', 'elena@email.com', '1995-03-18', 'Puntarenas, Garabito', 400.00, '2024-04-10', '2024-04-12', GETDATE(), 9),
('Andres Castro', '4-0111-0222', '71112233', 'andres@email.com', '1988-12-05', 'Limon, Guapiles', 600.00, '2024-04-20', '2024-04-22', GETDATE(), 10),
('Sofia Mendez', '1-0888-0999', '89897878', 'sofia@email.com', '1993-09-09', 'San Jose, Escazu', 95.00, '2024-05-01', '2024-05-02', GETDATE(), 6),
('Luis Torres', '2-0333-0444', '82223344', 'luis@email.com', '1975-06-22', 'Alajuela, Grecia', 220.00, '2024-05-05', '2024-05-07', GETDATE(), 7),
('Patricia Solis', '5-0666-0777', '72728282', 'patty@email.com', '1982-04-14', 'Guanacaste, Liberia', 50.00, '2024-05-10', '2024-05-11', GETDATE(), 2);