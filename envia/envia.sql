-- Se crea Base de Datos
CREATE DATABASE envia;
-- Se muestra la Base de Datos
SHOW DATABASES;
-- Se usa la Base de Datos
USE envia;
-- Se crea la tabla Persona
CREATE TABLE persona (
    -> persona_id INT PRIMARY KEY,
    -> nombre VARCHAR(50),
    -> apellido VARCHAR(50),
    -> tipo_documento_id INT,
    -> numero_documento INT,
    -> fkrol_id INT,
    -> FOREIGN KEY (fkrol_id) REFERENCES rol (rol_id)
    -> );
-- Se crea la tabla Tipo Documento
CREATE TABLE tipo_documento (
    -> tipo_documento_id INT PRIMARY KEY,
    -> nombre VARCHAR(50)
    -> );
-- Se crea la tabla Rol
CREATE TABLE rol (
    -> rol_id INT PRIMARY KEY,
    -> nombre VARCHAR(50)
    -> );
-- Se crea la tabla Paquete
CREATE TABLE paquete (
    -> paquete_id INT PRIMARY KEY,
    -> nombre VARCHAR(50),
    -> descripcion_paquete VARCHAR(100),
    -> fkpersona_id INT,
    -> FOREIGN KEY (fkpersona_id) REFERENCES persona (persona_id)
    -> );
-- Se crea la tabla Paquete Registro
CREATE TABLE paquete_registro (
    -> paquete_registro_id INT PRIMARY KEY,
    -> fkpaquete_id INT,
    -> FOREIGN KEY (fkpaquete_id) REFERENCES paquete (paquete_id),
    -> fecha_registro DATE,
    -> numero_guia INT,
    -> fkdireccion_id INT,
    -> FOREIGN KEY (fkdireccion_id) REFERENCES direccion (direccion_id)
    -> );
-- Se crea la tabla Paquete Envio
CREATE TABLE paquete_envio (
    -> paquete_envio_id INT PRIMARY KEY,
    -> fkpaquetes_registro_id INT,
    -> FOREIGN KEY (fkpaquetes_registro_id) REFERENCES paquete_registro (paquete_registro_id),
    -> fecha_evio DATE,
    -> fecha_entrega DATE,
    -> costo_envio DOUBLE,
    -> fkestado_paquete_id INT,
    -> FOREIGN KEY (fkestado_paquete_id) REFERENCES estado_paquete (estado_paquete_id)
    -> );
-- Se crea la tabla Estado Paquete
CREATE TABLE estado_paquete (
    -> estado_paquete_id INT PRIMARY KEY,
    -> descripcion VARCHAR(100)
    -> );
-- Se crea la tabla Direccion
CREATE TABLE direccion (
    -> direccion_id INT PRIMARY KEY,
    -> descripcion VARCHAR(100)
    -> fkcontinente_id INT,
    -> FOREIGN KEY (fkcontinente_id) REFERENCES continente (continente_id),
    -> fkpais_id INT,
    -> FOREIGN KEY (fkpais_id) REFERENCES pais (pais_id),
    -> fkdepartamento_id INT,
    -> FOREIGN KEY (fkdepartamento_id) REFERENCES departamento (departamento_id),
    -> fkprovincia_id INT,
    -> FOREIGN KEY (fkprovincia_id) REFERENCES provincia (provincia_id),
    -> fkciudad_id INT,
    -> FOREIGN KEY (fkciudad_id) REFERENCES ciudad (ciudad_id),
    -> fkpueblo_id INT,
    -> FOREIGN KEY (fkpueblo_id) REFERENCES pueblo (pueblo_id),
    -> fkvereda_id INT,
    -> FOREIGN KEY (fkvereda_id) REFERENCES vereda (vereda_id),
    -> fkbarrio_id INT,
    -> FOREIGN KEY (fkbarrio_id) REFERENCES barrio (barrio_id),
    -> fkcodigo_postal_id INT,
    -> FOREIGN KEY (fkcodigo_postal_id) REFERENCES codigo_postal (codigo_postal_id),
    -> fktipo_vivienda_id INT,
    -> FOREIGN KEY (fktipo_vivienda_id) REFERENCES tipo_vivienda (tipo_vivienda_id),
    -> fktipo_direccion_id INT,
    -> FOREIGN KEY (fktipo_direccion_id) REFERENCES tipo_direccion (tipo_direccion_id),
    -> fknumero_direccion_id INT,
    -> FOREIGN KEY (fknumero_direccion_id) REFERENCES numero_direccion (numero_direccion_id)
    -> );
-- Se crea la tabla Continente
CREATE TABLE continente (
    -> continente_id INT PRIMARY KEY,
    -> nombre VARCHAR(50),
    -> );
-- Se crea la tabla Pais
CREATE TABLE pais (
    -> pais_id INT PRIMARY KEY,
    -> nombre VARCHAR(50),
    -> fkcontinente_id INT,
    -> FOREIGN KEY (fkcontinente_id) REFERENCES continente (continente_id)
    -> );
-- Se crea la tabla Departamento
CREATE TABLE departamento (
    -> departamento_id INT PRIMARY KEY,
    -> nombre VARCHAR(50),
    -> fkpais_id INT,
    -> FOREIGN KEY (fkpais_id) REFERENCES pais (pais_id)
    -> );
-- Se crea la tabla Provincia
CREATE TABLE provincia (
    -> provincia_id INT PRIMARY KEY,
    -> nombre VARCHAR(50),
    -> fkpais_id INT,
    -> FOREIGN KEY (fkpais_id) REFERENCES pais (pais_id)
    -> );
-- Se crea la tabla Ciudad
CREATE TABLE ciudad (
    -> ciudad_id INT PRIMARY KEY,
    -> nombre VARCHAR(50),
    -> fkdepartamento_id INT,
    -> FOREIGN KEY (fkdepartamento_id) REFERENCES departamento (departamento_id)
    -> );
-- Se crea la tabla Pueblo
CREATE TABLE pueblo (
    -> pueblo_id INT PRIMARY KEY,
    -> nombre VARCHAR(50),
    -> fkdepartamento_id INT,
    -> FOREIGN KEY (fkdepartamento_id) REFERENCES departamento (departamento_id)
    -> );
-- Se crea la tabla Vereda
CREATE TABLE vereda (
    -> vereda_id INT PRIMARY KEY,
    -> nombre VARCHAR(50),
    -> fkdepartamento_id INT,
    -> FOREIGN KEY (fkdepartamento_id) REFERENCES departamento (departamento_id)
    -> );
-- Se crea la tabla Barrio
CREATE TABLE barrio (
    -> barrio_id INT PRIMARY KEY,
    -> nombre VARCHAR(50),
    -> fkciudad_id INT,
    -> FOREIGN KEY (fkciudad_id) REFERENCES ciudad (ciudad_id),
    -> fkpueblo_id INT,
    -> FOREIGN KEY (fkpueblo_id) REFERENCES pueblo (pueblo_id)
    -> );
-- Se crea la tabla Codigo Postal
CREATE TABLE codigo_postal (
    -> codigo_postal_id INT PRIMARY KEY,
    -> nombre VARCHAR(50),
    -> fkciudad_id INT,
    -> FOREIGN KEY (fkciudad_id) REFERENCES ciudad (ciudad_id),
    -> fkpueblo_id INT,
    -> FOREIGN KEY (fkpueblo_id) REFERENCES pueblo (pueblo_id)
    -> );
-- Se crea la tabla Tipo Vivienda
CREATE TABLE tipo_vivienda (
    -> tipo_vivienda_id INT PRIMARY KEY,
    -> nombre VARCHAR(50),
    -> fkbarrio_id INT,
    -> FOREIGN KEY (fkbarrio_id) REFERENCES barrio (barrio_id)
    -> );
-- Se crea la tabla Tipo Direccion
CREATE TABLE tipo_direccion (
    -> tipo_direccion_id INT PRIMARY KEY,
    -> nombre VARCHAR(50),
    -> fktipo_vivienda_id INT,
    -> FOREIGN KEY (fktipo_vivienda_id) REFERENCES tipo_vivienda (tipo_vivienda_id)
    -> );
-- Se crea la tabla Numero Direccion
CREATE TABLE numero_direccion (
    -> numero_direccion_id INT PRIMARY KEY,
    -> numero INT,
    -> bis INT,
    -> fktipo_direccion_id INT,
    -> FOREIGN KEY (fktipo_direccion_id) REFERENCES tipo_direccion (tipo_direccion_id)
    -> );
-- Se crea la tabla Piso
CREATE TABLE piso (
    -> piso_id INT PRIMARY KEY,
    -> numero INT,
    -> fknumero_direccion_id INT,
    -> FOREIGN KEY (fknumero_direccion_id) REFERENCES numero_direccion (numero_direccion_id)
    -> );
-- Se crea la tabla Numero Casa
CREATE TABLE numero_casa (
    -> numero_casa_id INT PRIMARY KEY,
    -> numero INT,
    -> fknumero_direccion_id INT,
    -> FOREIGN KEY (fknumero_direccion_id) REFERENCES numero_direccion (numero_direccion_id)
    -> );
-- Se crea la tabla Numero Puerta
CREATE TABLE numero_puerta (
    -> numero_puerta_id INT PRIMARY KEY,
    -> numero INT,
    -> fknumero_direccion_id INT,
    -> FOREIGN KEY (fknumero_direccion_id) REFERENCES numero_direccion (numero_direccion_id)
    -> );
-- Se crea la tabla Kilometro
CREATE TABLE kilometro (
    -> kilometro_id INT PRIMARY KEY,
    -> numero INT,
    -> fknumero_direccion_id INT,
    -> FOREIGN KEY (fknumero_direccion_id) REFERENCES numero_direccion (numero_direccion_id)
    -> );