-- Crear base de datos
IF DB_ID('DBCRUD') IS NULL
    CREATE DATABASE DBCRUD;
GO
USE DBCRUD;
GO

-- Tabla Empresa
IF OBJECT_ID('dbo.Empresa','U') IS NOT NULL DROP TABLE dbo.Empresa;
CREATE TABLE dbo.Empresa (
    IdEmpresa INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(150) NOT NULL,
    CUIT NVARCHAR(20) NOT NULL,
    Direccion NVARCHAR(255) NOT NULL
);

-- Tabla Empleado
IF OBJECT_ID('dbo.Empleado','U') IS NOT NULL DROP TABLE dbo.Empleado;
CREATE TABLE dbo.Empleado (
    IdEmpleado INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    Apellido NVARCHAR(100) NOT NULL,
    FechaNacimiento DATE NOT NULL,
    Cargo NVARCHAR(100) NOT NULL,
    Sueldo DECIMAL(10,2) NOT NULL,
    Telefono NVARCHAR(50) NOT NULL,
    Email NVARCHAR(150) NOT NULL,
    FechaIngreso DATE NOT NULL,
    IdEmpresa INT NOT NULL,
    Estado NVARCHAR(50) NOT NULL,
    CONSTRAINT FK_Empleado_Empresa FOREIGN KEY (IdEmpresa) REFERENCES Empresa(IdEmpresa)
);

-- Datos de ejemplo
INSERT INTO Empresa (Nombre, CUIT, Direccion) VALUES
('TechCorp', '30-11223344-5', 'Av. Mitre 123'),
('AgroPlus', '30-55667788-9', 'Ruta 3 Km 45');

INSERT INTO Empleado (Nombre, Apellido, FechaNacimiento, Cargo, Sueldo, Telefono, Email, FechaIngreso, IdEmpresa, Estado)
VALUES
('Juan', 'Pérez', '1990-05-12', 'Desarrollador', 750000, '11-2222-3333', 'juan@techcorp.com', '2020-01-01', 1, 'Activo'),
('Lucía', 'Gómez', '1992-08-30', 'Analista', 680000, '11-3333-4444', 'lucia@agroplus.com', '2021-05-15', 2, 'Activo');


create function fn_departamentos()
returns table
as
return
	select IdDepartamento,Nombre from Departamento

go

create function fn_empleados()
returns table
as
return
(
	select e.IdEmpleado,e.NombreCompleto,
	d.IdDepartamento,d.Nombre,
	e.Sueldo,convert(char(10),e.FechaContrato,103)[FechaContrato]
	from Empleado e
	inner join Departamento d on d.IdDepartamento = e.IdDepartamento
)

go

create function fn_empleado(@idEmpleado int)
returns table
as
return
(
	select e.IdEmpleado,e.NombreCompleto,
	d.IdDepartamento,d.Nombre,
	e.Sueldo,convert(char(10),e.FechaContrato,103)[FechaContrato]
	from Empleado e
	inner join Departamento d on d.IdDepartamento = e.IdDepartamento
	where e.IdEmpleado = @idEmpleado
)

go

create procedure sp_CrearEmpleado(
@NombreCompleto varchar(50),
@IdDepartamento int,
@Sueldo decimal(10,2),
@FechaContrato varchar(10)
)
as
begin
	set dateformat dmy
	insert into Empleado(NombreCompleto,IdDepartamento,Sueldo,FechaContrato)
	values(@NombreCompleto,@IdDepartamento,@Sueldo,convert(date,@FechaContrato))
end

go

create procedure sp_EditarEmpleado(
@IdEmpleado int,
@NombreCompleto varchar(50),
@IdDepartamento int,
@Sueldo decimal(10,2),
@FechaContrato varchar(10)
)
as
begin
	set dateformat dmy
	update Empleado set
	NombreCompleto = @NombreCompleto,
	IdDepartamento = @IdDepartamento,
	Sueldo = @Sueldo,
	FechaContrato = convert(date,@FechaContrato)
	where IdEmpleado = @IdEmpleado
end

go 

create procedure sp_EliminarEmpleado(
@IdEmpleado int
)
as
begin
	delete from Empleado where IdEmpleado = @IdEmpleado
end