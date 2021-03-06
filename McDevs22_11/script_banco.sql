drop table if exists pedido cascade;
drop table if exists funcionario cascade;
drop table if exists cliente cascade;
drop table if exists produto cascade;

drop sequence if exists id_cli_seq cascade;
drop sequence if exists id_func_seq cascade;
drop sequence if exists id_pedido_seq cascade;
drop sequence if exists id_prod_seq cascade;

CREATE SEQUENCE id_cli_seq
START 1
MINVALUE 1
MAXVALUE 9223372036854775807
CACHE 1;
CREATE TABLE cliente (
	id_cliente integer NOT NULL DEFAULT NEXTVAL('id_cli_seq'),
	nome_cliente varchar(150) NOT NULL,
	cpf_cliente varchar(15) NOT NULL UNIQUE,
	senha_cli character varying(100) NOT NULL,
	email_cli character varying(150) NOT NULL,
	excluido bool NOT NULL DEFAULT 'FALSE',
	CONSTRAINT "cliente_pk" PRIMARY KEY ("id_cliente")
);
insert into cliente values (
	DEFAULT,'Andre','123.456.789-10','123456789','andbicudo@gmail.com', DEFAULT
);

CREATE SEQUENCE id_func_seq
START 1
MINVALUE 1
MAXVALUE 9223372036854775807
CACHE 1;
CREATE TABLE funcionario (
	id_func integer NOT NULL DEFAULT NEXTVAL('id_func_seq'),
	nome_func varchar(150) NOT NULL,
	cpf_func varchar(14) NOT NULL UNIQUE,
	rg_func varchar(12) NOT NULL UNIQUE,
	endereco_func varchar(150) NOT NULL,
	genero_func varchar(20) NOT NULL,
	data_nasc_func DATE NOT NULL,
	email_func varchar(100) NOT NULL UNIQUE,
	senha_func character varying(100) NOT NULL,
	excluido bool NOT NULL DEFAULT 'FALSE',
	CONSTRAINT "funcionario_pk" PRIMARY KEY ("id_func")
);
insert into funcionario values (
	DEFAULT,'Admin','111.111.111-11','55.555.555-5','Rua Feliz','Masculino',NOW(),'admin@mcdevs.com','mcdevs', DEFAULT
);

CREATE SEQUENCE id_pedido_seq
START 1
MINVALUE 1
MAXVALUE 9223372036854775807
CACHE 1;
CREATE TABLE pedido(
	id_pedido integer NOT NULL DEFAULT NEXTVAL('id_pedido_seq'),
	id_pedido_cli integer NOT NULL,
	data_pedido DATE NOT NULL,
	total_pedido DECIMAL NOT NULL,
	excluido bool NOT NULL DEFAULT 'FALSE',
	CONSTRAINT "pedido_pk" PRIMARY KEY ("id_pedido"),
	FOREIGN KEY (id_pedido_cli) REFERENCES cliente (id_cliente)
);

CREATE SEQUENCE id_prod_seq
START 1
MINVALUE 1
MAXVALUE 9223372036854775807
CACHE 1;
CREATE TABLE produto (
	id_prod integer NOT NULL DEFAULT NEXTVAL('id_prod_seq'),
	nome_prod varchar(100) NOT NULL,
	categoria varchar(100) NOT NULL,
	preco_prod DECIMAL NOT NULL,
	excluido bool NOT NULL DEFAULT 'FALSE',
	CONSTRAINT "produto_pk" PRIMARY KEY ("id_prod")
);
insert into produto values 
	(DEFAULT, 'DevFritas','Acompanhamento', 12.00, DEFAULT),
	(DEFAULT, 'McFri','Bebida', 12.00, DEFAULT)
;
