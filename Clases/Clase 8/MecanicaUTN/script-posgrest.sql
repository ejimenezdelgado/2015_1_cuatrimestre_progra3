﻿CREATE TABLE repuesto
(
	id serial primary key NOT NULL,
	nombre varchar(100) NOT NULL,
	modelo varchar(100) NOT NULL,
	marca varchar(100) NOT NULL,
	cantidad decimal(18,2) NOT NULL,
	precio decimal(18,2) NOT NULL,
	impuesto decimal(18,2) NOT NULL,
	gravado boolean NOT NULL
)
