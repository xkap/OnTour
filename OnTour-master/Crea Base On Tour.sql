--  Borrado de objetos

DROP TABLE apoderado CASCADE CONSTRAINTS;
DROP TABLE ejecutivo CASCADE CONSTRAINTS;
DROP TABLE curso CASCADE CONSTRAINTS;
DROP TABLE alumno CASCADE CONSTRAINTS;
DROP TABLE estado_civil CASCADE CONSTRAINTS;
DROP TABLE genero CASCADE CONSTRAINTS;
DROP TABLE paquete CASCADE CONSTRAINTS;
DROP TABLE tipo_user CASCADE CONSTRAINTS;
DROP TABLE usuario CASCADE CONSTRAINTS;
DROP TABLE deposito CASCADE CONSTRAINTS;
DROP TABLE contrato CASCADE CONSTRAINTS;
DROP TABLE informacion CASCADE CONSTRAINTS;

--SECUENCIAS
DROP SEQUENCE sq_curso;
DROP SEQUENCE sq_info;
CREATE SEQUENCE sq_info;
CREATE SEQUENCE sq_curso;


--creación de tablas

CREATE TABLE estado_civil (
idecivil NUMBER (5) NOT NULL,
descripcion VARCHAR2 (10) NOT NULL,
CONSTRAINT pk_estado_civil PRIMARY KEY (idecivil)
);
CREATE TABLE genero (
idgenero NUMBER (5) NOT NULL,
descripcion VARCHAR2 (15) NOT NULL,
CONSTRAINT pk_genero PRIMARY KEY (idgenero)
);


CREATE TABLE apoderado (
run_apo VARCHAR2 (10) NOT NULL,
nom_apo VARCHAR2 (70) NOT NULL,
app_apo VARCHAR2 (30) NOT NULL,
apm_apo VARCHAR2 (30) NOT NULL,
fecnac date not null,
correo VARCHAR2 (70) NOT NULL,
idecivil NUMBER (5) NOT NULL,
idgenero NUMBER (5)NOT NULL,
user_login VARCHAR2 (10) NOT NULL,
run_eje VARCHAR2(10) NOT NULL,
idcurso number(5) not null,
CONSTRAINT pk_apoderado PRIMARY KEY (run_apo)
);

CREATE TABLE paquete (
idpaq NUMBER (5) NULL,
nombre_paq VARCHAR2 (30) NOT NULL,
destino_paq VARCHAR2 (80) NOT NULL,
valor_paq NUMBER (15) NOT NULL,
CONSTRAINT pk_paquete PRIMARY KEY (idpaq)
);

CREATE TABLE curso(
idcurso NUMBER (5) NOT NULL,
nivel varchar2(30) not null,
colegio VARCHAR2(100) NOT NULL,
cant_alumnos NUMBER (3) NOT NULL,
idpaq NUMBER (5) NULL,
CONSTRAINT pk_curso PRIMARY KEY (idcurso)
);
 

CREATE TABLE alumno(
num_lista NUMBER (3) NOT NULL,
idcurso NUMBER (5) NOT NULL,
CONSTRAINT pk_alumno PRIMARY KEY (num_lista)
);


CREATE TABLE ejecutivo (
run_eje VARCHAR2 (10) NOT NULL,
nom_eje VARCHAR2 (70) NOT NULL,
apellido_eje VARCHAR2 (30) NOT NULL,
fono_eje VARCHAR2 (15) NOT NULL,
mail_eje VARCHAR2 (70)NOT NULL,
user_login VARCHAR (10) NOT NULL,
CONSTRAINT pk_ejecutivo PRIMARY KEY (run_eje)
);


CREATE TABLE tipo_user (
idtipo_user NUMBER (5) NOT NULL,
descripcion VARCHAR (20) NOT NULL,
CONSTRAINT pk_tipo_user PRIMARY KEY (idtipo_user)
);


CREATE TABLE usuario (
user_login VARCHAR2 (10) NOT NULL,
pass_login VARCHAR2 (25) NOT NULL,
idtipo_user NUMBER (5) NOT NULL,
CONSTRAINT pk_usuario PRIMARY KEY (user_login)
);


CREATE TABLE deposito (
iddeposito NUMBER (5) NOT NULL,
mail_desti VARCHAR (80) NOT NULL,
fec_transf DATE NOT NULL,
monto_transf NUMBER (10) NOT NULL,
CONSTRAINT pk_deposito PRIMARY KEY (iddeposito)
);

CREATE TABLE contrato(
idcontrato NUMBER (5) NOT NULL,
nombre VARCHAR2(80)NOT NULL,
archivos BFILE NULL,
idpaq NUMBER (5) NOT NULL,
CONSTRAINT pk_contratos PRIMARY KEY (idcontrato)
);


CREATE TABLE informacion (
idinfor NUMBER (5) NOT NULL,
mensaje VARCHAR (250),
run_eje VARCHAR2 (10) NOT NULL,
run_apo varchar2(10),
CONSTRAINT pk_informacion PRIMARY KEY (idinfor)
);




--creacion de llaves foraneas

ALTER TABLE  apoderado
ADD CONSTRAINT fk_apoderado_estado_civil FOREIGN  KEY (idecivil)  REFERENCES estado_civil(idecivil);
ALTER TABLE apoderado
ADD CONSTRAINT fk_apoderado_genero FOREIGN  KEY (idgenero)  REFERENCES genero(idgenero);
ALTER TABLE apoderado
ADD CONSTRAINT fk_apoderado_usuario FOREIGN KEY (user_login) REFERENCES usuario (user_login);
ALTER TABLE apoderado 
ADD CONSTRAINT fk_apoderado_ejecutivo FOREIGN KEY (run_eje) REFERENCES ejecutivo (run_eje);
ALTER TABLE apoderado
ADD CONSTRAINT fk_apoderado_curso FOREIGN KEY (idcurso) REFERENCES curso (idcurso);

ALTER TABLE curso
ADD CONSTRAINT fk_curso_paquete FOREIGN KEY (idpaq) REFERENCES paquete (idpaq);

ALTER TABLE ejecutivo
ADD CONSTRAINT fk_ejecutico_usuario FOREIGN KEY (user_login) REFERENCES usuario (user_login);

ALTER TABLE usuario
ADD CONSTRAINT fk_usuario_tipouser FOREIGN  KEY (idtipo_user)  REFERENCES tipo_user(idtipo_user);


ALTER TABLE informacion
ADD CONSTRAINT fk_inforamcion_ejecutivo FOREIGN KEY (run_eje) REFERENCES ejecutivo (run_eje);

ALTER TABLE informacion
ADD CONSTRAINT fk_inforamcion_apoderado FOREIGN KEY (run_apo) REFERENCES apoderado (run_apo);

--insercion de datos
--INSERT TIPO USER
INSERT INTO tipo_user (
idtipo_user,
descripcion)
VALUES (1,'Apoderado');

INSERT INTO tipo_user (
idtipo_user,
descripcion)
VALUES (2,'Ejecutivo');
--------------------------------------------------------------
--INSERT USUARIO
INSERT INTO usuario (
user_login,
pass_login,
idtipo_user)
VALUES ('12345678-k','hola',2);

INSERT INTO usuario (
user_login,
pass_login,
idtipo_user)
VALUES ('1904k','chao',1);

INSERT INTO usuario (
user_login,
pass_login,
idtipo_user)
VALUES ('123','x',2);

-------------------------------------------------------------
-------------------------------------------------------------
--INSERT ESTADO CIVIL
INSERT INTO estado_civil(
idecivil,
descripcion) VALUES (1,'Soltero'
);

INSERT INTO estado_civil(
idecivil,
descripcion) VALUES (2,'Casado'
);

INSERT INTO estado_civil(
idecivil,
descripcion) VALUES (3,'Divorciado'
);

INSERT INTO estado_civil(
idecivil,
descripcion) VALUES (4,'Viudo'
);
------------------------------------------------------------
--INSERT GENERO
INSERT INTO genero(
idgenero,
descripcion )VALUES(2,'Femenino');

INSERT INTO genero(
idgenero,
descripcion )VALUES(1,'Masculino');

-----------------------------------------------------------
-----------------------------------------------------------
-- PAQUETES DE VIAJES
--PAQ1
INSERT INTO paquete (
idpaq,
nombre_paq,
destino_paq,
valor_paq
)VALUES (1,'PACK 1','Rusia',975000);
---------------------------------------------------------------
---------------------------------------------------------------
-- TRANSFERENCIAS
--trans 1
INSERT INTO deposito (
iddeposito,
mail_desti,
fec_transf,
monto_transf
)VALUES (75315,'ejecutivo@ejeontour.xxx',(TO_DATE('02/07/2018', 'DD/MM/YYYY')),650000);
---------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------
--EJE1
INSERT INTO ejecutivo (
run_eje,
nom_eje,
apellido_eje,
fono_eje,
mail_eje,
user_login)
VALUES('12345678-k','Pato','Bustos','1234567891','PaCarlos.Bustos@gmail.com','12345678-k');

--EJE2
INSERT INTO ejecutivo (
run_eje,
nom_eje,
apellido_eje,
fono_eje,
mail_eje,
user_login)
VALUES('123','Pedro','Jerez','+556985562','Ppeterpan@gmail.com','123');

--ttcurso1
INSERT INTO curso(
idcurso,
nivel,
colegio,
cant_alumnos,
idpaq
)
VALUES (sq_curso.nextval,'IV ° A','Las Carmelitas',27,null);
--APO1
INSERT INTO apoderado  (
run_apo ,
nom_apo ,
app_apo ,
apm_apo ,
fecnac ,
correo ,
idecivil ,
idgenero ,
user_login ,
run_eje,
idcurso)
VALUES('1904k','Diego','Morin','Morren','23/08/1996','diegont@hotmail.com',1,1,'1904k','12345678-k',1);


--alumn1
INSERT INTO alumno(
num_lista,
idcurso)
VALUES (4,88);

--contr 1
INSERT INTO contrato(
idcontrato,
nombre,
archivos,
idpaq
)VALUES(854,'Contrato OnTour',null,75);
--info 1
INSERT INTO informacion (
idinfor,
mensaje,
run_eje,
run_apo
)VALUES(654,'Ofertas por esta semana 30% de descuento','12345678-k','1904k');



