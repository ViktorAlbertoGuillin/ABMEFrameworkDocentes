Create database Docentes;
use Docentes;

-- Crear la tabla Alumno
CREATE TABLE Docentes (
    Id int IDENTITY(1,1) PRIMARY KEY,
    Nombre varchar(100),
    Edad int,
	Materia varchar(100),
    Ciudad varchar(100)
);

-- Insertar datos en la tabla Alumno
INSERT INTO Docentes (Nombre, Edad, Materia, Ciudad)
VALUES ('Juan P�rez', 20, 'Matematica','Ciudad de M�xico');

INSERT INTO Docentes (Nombre, Edad, Materia, Ciudad)
VALUES ('Mar�a Garc�a', 22, 'Historia','Madrid');

INSERT INTO Docentes (Nombre, Edad, Materia, Ciudad)
VALUES ('Carlos L�pez', 21, 'Literatura','Buenos Aires');

select * from Docentes
