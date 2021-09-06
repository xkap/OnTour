--PROCEDIMIENTOS ON TOUR

CREATE OR REPLACE PROCEDURE sp_login
(puser IN VARCHAR2, ppass IN VARCHAR2,  pexito OUT VARCHAR2, ptipo OUT NUMBER )
AS
lfila NUMBER;
ltipo number;
BEGIN

SELECT COUNT(*)
INTO lfila
FROM usuario
WHERE user_login = puser AND pass_login = ppass;

SELECT idtipo_user
INTO ltipo
FROM usuario
WHERE user_login = puser AND pass_login = ppass;

IF lfila = 0 THEN pexito:='F';
ELSE pexito:='T';
END IF;

IF ltipo IS NULL THEN ptipo:=NULL;
ELSE ptipo:=ltipo;
END IF;


END;
/


CREATE OR REPLACE PROCEDURE sp_regapoderado
(prun_apo VARCHAR2,pnombres VARCHAR2 , pappaterno VARCHAR2, papmaterno VARCHAR2,  pfecnac DATE, pcorreo VARCHAR2, pidecivil NUMBER,
pidgenero NUMBER, prun_eje VARCHAR2, pcurso varchar2, pcantalum number,pcolegio varchar2, ppass VARCHAR2)
AS
lcurso number;
BEGIN
INSERT INTO curso VALUES(sq_curso.NEXTVAL,pcurso, pcolegio,pcantalum, NULL);

INSERT INTO usuario VALUES(prun_apo,ppass,1);

INSERT INTO apoderado VALUES(prun_apo,pnombres,pappaterno, papmaterno, pfecnac,pcorreo,pidecivil,pidgenero,prun_apo,prun_eje,sq_curso.currval);

END;
/


CREATE OR REPLACE PROCEDURE sp_llenardepositos(resul OUT SYS_REFCURSOR) 
IS 
BEGIN   
OPEN resul FOR SELECT iddeposito,mail_desti,fec_transf,monto_transf
FROM deposito; 
END sp_llenardepositos;
/

CREATE OR REPLACE PROCEDURE sp_combocontacto
(reje IN varchar2, resul OUT SYS_REFCURSOR)
IS
BEGIN

OPEN resul FOR SELECT run_apo
FROM apoderado WHERE run_eje = reje;
END sp_combocontacto;
/

CREATE OR REPLACE PROCEDURE sp_combopaquetes
(resul OUT SYS_REFCURSOR)
IS
BEGIN

OPEN resul FOR SELECT idpaq
FROM paquete;
END sp_combopaquetes;
/

CREATE OR REPLACE PROCEDURE sp_combocurso
(resul OUT SYS_REFCURSOR)
IS
BEGIN

OPEN resul FOR SELECT idcurso
FROM curso;
END sp_combocurso;
/

CREATE OR REPLACE PROCEDURE sp_informar
(prun_apo VARCHAR2, prun_eje VARCHAR2,pmsg varchar2)
AS
BEGIN

INSERT INTO INFORMACION VALUES(sq_info.nextval,pmsg,prun_eje,prun_apo);

END;
/

CREATE OR REPLACE PROCEDURE sp_pubinfo
(prun_eje VARCHAR2,pmsg varchar2)
AS
BEGIN

INSERT INTO INFORMACION VALUES(sq_info.nextval,pmsg,prun_eje,null);

END;
/

CREATE OR REPLACE PROCEDURE sp_contpaq
(ppaq NUMBER, pcurso NUMBER)
IS
BEGIN

UPDATE curso SET idpaq = ppaq WHERE idcurso = pcurso;

END;
/
SELECT valor_paq, (select mensaje from informacion where idinfor =654)from paquete;
CREATE OR REPLACE PROCEDURE sp_informaciones
















