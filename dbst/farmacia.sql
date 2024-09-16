CREATE TABLE pais(
    id int AUTO_INCREMENT,
    nombre VARCHAR(50),
    CONSTRAINT Pk_idpais PRIMARY KEY(id)
);
CREATE TABLE departamento(
    id int AUTO_INCREMENT,
    nombre VARCHAR(50),
    idpaisFk int(11),
    CONSTRAINT Pk_iddepartamento PRIMARY KEY(id),
    CONSTRAINT FK_idpais FOREIGN KEY (idpaisFk) REFERENCES pais(id) 
);
CREATE TABLE ciudad(
    id int AUTO_INCREMENT,
    nombre VARCHAR(50),
    iddepartamentoFk int(11),
    CONSTRAINT Pk_idciudad PRIMARY KEY(id),
    CONSTRAINT FK_iddepartamento FOREIGN KEY (iddepartamentoFk) REFERENCES departamento(id) 
);
CREATE TABLE tipoPersona(
    id int AUTO_INCREMENT,
    nombre VARCHAR(50),
    CONSTRAINT Pk_idtipoPersona PRIMARY KEY(id)
);
CREATE TABLE presentacion(
    id int AUTO_INCREMENT,
    nombre VARCHAR(50),
    CONSTRAINT Pk_idpresentacion PRIMARY KEY(id)
);
CREATE TABLE rolPersona(
    id int AUTO_INCREMENT,
    nombre VARCHAR(50),
    CONSTRAINT Pk_idrolPersona PRIMARY KEY(id)
);
CREATE TABLE formaPago(
    id int AUTO_INCREMENT,
    nombre VARCHAR(50),
    CONSTRAINT Pk_idformaPago PRIMARY KEY(id)
);
CREATE TABLE tipoMovInventario(
    id int AUTO_INCREMENT,
    nombre VARCHAR(50),
    CONSTRAINT Pk_tipoMovInventario PRIMARY KEY(id)
);

CREATE TABLE tipoContacto(
    id int AUTO_INCREMENT,
    nombre VARCHAR(50),
    CONSTRAINT Pk_tipoContacto PRIMARY KEY(id)
);
CREATE TABLE marca (
    id int AUTO_INCREMENT,
    nombre VARCHAR(50),
    CONSTRAINT Pk_marca PRIMARY KEY(id)
);

CREATE TABLE producto(
    cod VARCHAR(10),
    nombreProd VARCHAR(100),
    idmarca int (11),
    CONSTRAINT Pk_producto PRIMARY KEY (cod),
    CONSTRAINT Fk_idmarca FOREIGN KEY (idmarca) REFERENCES marca(id)
);

CREATE TABLE tipoDocumento(
    id int AUTO_INCREMENT,
    nombre VARCHAR(50),
    CONSTRAINT Pk_tipoDocumento PRIMARY KEY(id)
);

CREATE TABLE persona(
    id VARCHAR (20),
    nombre VARCHAR (50),
    fechaRegistro DATE,
    idDocumento int (11),
    idRolPersona int(11),
    idTipoPersona int (11),
    CONSTRAINT Pk_persona PRIMARY KEY(id),
    CONSTRAINT Fk_idDocumento FOREIGN KEY (idDocumento) REFERENCES tipoDocumento (id),
    CONSTRAINT Fk_idRolPersona FOREIGN KEY (idRolPersona) REFERENCES rolPersona (id),
    CONSTRAINT Fk_idTipoPersona FOREIGN KEY (idTipoPersona) REFERENCES tipoPersona (id)

);
CREATE TABLE ubicacionPersona(
    idDireccion int AUTO_INCREMENT,
    tipoDeVia VARCHAR(50),
    numeroPri smallint,
    letra CHAR(2),
    bis CHAR(10),
    letraSec CHAR(2),
    cardinal CHAR(10),
    numeroSec smallint,
    letraTer CHAR(2),
    numeroTer smallint,
    cardinalSec CHAR(10),
    complemento VARCHAR(50),
    idPersona VARCHAR(20),
    idCiudad int(11),
    CONSTRAINT PK_direccion PRIMARY KEY(idDireccion),
    CONSTRAINT FK_idPersona FOREIGN KEY (idPersona) REFERENCES persona(id),
    CONSTRAINT FK_idCiudad FOREIGN KEy (idCiudad) REFERENCES ciudad(id)
);
CREATE TABLE contactoPersona(
    id int AUTO_INCREMENT,
    idPersona VARCHAR(20),
    idTipoContacto int (11),
    CONSTRAINT PK_contactoPersona PRIMARY KEY(id),
    CONSTRAINT FK_idPersonaContacto FOREIGN KEY (idPersona) REFERENCES persona(id),
    CONSTRAINT FK_idTipoContacto FOREIGN KEY (idTipoContacto) REFERENCES tipoContacto(id)
);
CREATE TABLE inventario(
    id VARCHAR(10),
    nombre VARCHAR(50),
    precio DOUBLE(11, 2),
    stock smallint,
    stockMin smallint,
    stockMax smallint,
    codProducto VARCHAR(10),
    idpresentacion INT(11),
    CONSTRAINT PK_idinventario PRIMARY KEY (id),
    CONSTRAINT FK_CodProducto FOREIGN KEY (codProducto) REFERENCES producto(cod),
    CONSTRAINT FK_idpresentacion FOREIGN KEY (idpresentacion) REFERENCES presentacion(id)
);
CREATE TABLE factura(
    id int AUTO_INCREMENT,
    facturaInicial int,
    facturaFinal int,
    facturaActual int,
    nroResolucion VARCHAR(10),
    CONSTRAINT PK_idfactura PRIMARY KEY (id)
);
CREATE TABLE movimientoInventario(
    id VARCHAR(10),
    idResponsable VARCHAR(20),
    idReceptor VARCHAR(20),
    fechaMovimiento DATE,
    fechaVencimiento DATE,
    idtipoMovInv int(11),
    CONSTRAINT PK_idMovInv PRIMARY KEY(id),
    CONSTRAINT FK_idResponsable FOREIGN KEY (idResponsable) REFERENCES persona(id),
    CONSTRAINT FK_idReceptor FOREIGN KEY (idReceptor) REFERENCES persona(id),
    CONSTRAINT fk_idTipoMovInv FOREIGN KEY (idtipoMovInv) REFERENCES tipoMovInventario(id)
);
CREATE TABLE detalleMovInventario(
    idInventario VARCHAR(10),
    idMovInv VARCHAR(10),
    cantidad TINYINT,
    precio DOUBLE(11, 2),
    CONSTRAINT PK_idinventario_idMovInv PRIMARY KEY (idInventario, idMovInv),
    CONSTRAINT FK_idInventario FOREIGN KEY (idInventario) REFERENCES inventario(id),
    CONSTRAINT FK_idMovInv FOREIGN KEY (idMovInv) REFERENCES movimientoInventario(id)
);
ALTER TABLE movimientoInventario 
ADD idFormaPago INT(11);
ALTER TABLE movimientoInventario
ADD FOREIGN KEY (idFormaPago) REFERENCES formaPago(id);

DML
INSERT (CREAR NUEVOS REGISTROS)
INSERT INTO [TABLA](C1,C2,TC..) VALUES ();
VC -> ''
FECHA -> ''
NUMERICOS -> 4345
pais
INSERT INTO pais(nombre) VALUES ('Peru'),('Ecuador'),('Panama'); 
DELETE
UPDATE

DQL 
SELECT id, nombre
FROM pais;
ALTER TABLE pais ADD UNIQUE(nombre);

INSERT INTO departamento(nombre,idpaisFk) VALUES ('Santander',1);
+------------------+-------------+------+-----+---------+----------------+
| Field            | Type        | Null | Key | Default | Extra          |
+------------------+-------------+------+-----+---------+----------------+
| id               | int         | NO   | PRI | NULL    | auto_increment |
| nombre           | varchar(50) | YES  |     | NULL    |                |
| iddepartamentoFk | int         | YES  | MUL | NULL    |                |
+------------------+-------------+------+-----+---------+----------------+
INSERT INTO ciudad(nombre,iddepartamentoFk) VALUES ('Bucaramanga',1),('Giron',1),('Piedecuesta',1)
,('Floridablanca',1);

SELECT C1,C2,C3.....
FROM TABLA
INNER JOIN TBL1 ON PK = FK

SELECT p.id,p.nombre As NombrePais ,d.nombre As NombreDep
FROM pais AS p
JOIN departamento AS d ON p.id = d.idpaisFk;

SELECT p.id,p.nombre As NombrePais ,d.nombre As NombreDep,
c.nombre AS NombreCiud
FROM pais AS p
JOIN departamento AS d ON p.id = d.idpaisFk
JOIN ciudad AS c ON d.id = c.iddepartamentoFk
ORDER BY c.nombre ASC;

CLAUSULAS
- WHERE -> CONDICIONES DE CONSULTA
OPERADORES COMPARACION
=, <, >, >=, <=, <>
OPERADORES DE PATRON 
like '%xxx%'
     '%xxx'
     'xxx%'
OPERADORES LOGICOS
AND, OR, NOT

SELECT p.id,p.nombre As NombrePais ,d.nombre As NombreDep,
c.nombre AS NombreCiud
FROM pais AS p
JOIN departamento AS d ON p.id = d.idpaisFk
JOIN ciudad AS c ON d.id = c.iddepartamentoFk
WHERE c.nombre LIKE 'MANGA%';

SELECT p.id,p.nombre As NombrePais ,d.nombre As NombreDep,
c.nombre AS NombreCiud
FROM pais AS p
JOIN departamento AS d ON p.id = d.idpaisFk
JOIN ciudad AS c ON d.id = c.iddepartamentoFk
WHERE c.nombre LIKE '%MANGA';

SELECT p.id,p.nombre As NombrePais ,d.nombre As NombreDep,
c.nombre AS NombreCiud
FROM pais AS p
JOIN departamento AS d ON p.id = d.idpaisFk
JOIN ciudad AS c ON d.id = c.iddepartamentoFk
WHERE c.nombre LIKE '%MANGA%';

------------------------------------------------------
UPDATE
UPDATE {TBL} SET C=V WHERE CONDICION
INSERT INTO pais(nombre) VALUES ('Benezuela');
UPDATE pais SET nombre='Venezuela' WHERE id = 6;
------------------------------------------------------
DELETE
DELETE FROM TBL WHERE CONDICION
DELETE FROM pais WHERE id = 6;


