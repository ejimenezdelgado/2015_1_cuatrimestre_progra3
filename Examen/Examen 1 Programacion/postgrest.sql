
CREATE TABLE codigo_electoral
(
  codelec character varying(30) NOT NULL PRIMARY KEY,
  provincia character varying(30) NOT NULL,
  canton character varying(30) NOT NULL,
  distrito character varying(30) NOT NULL
);

CREATE TABLE persona
(
  cedula character varying(30) NOT NULL,
  nombrecompleto character varying(200) NOT NULL,
  sexo integer NOT NULL,
  codelec character varying(30) NOT NULL,
  CONSTRAINT persona_pkey PRIMARY KEY (cedula),
  CONSTRAINT fk_persona_codigo_electoral FOREIGN KEY (codelec)
      REFERENCES codigo_electoral (codelec) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION
)