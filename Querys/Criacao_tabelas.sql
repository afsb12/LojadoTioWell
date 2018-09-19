create table cliente
	(
		cod_cli smallint identity,
		nome_cli varchar(40) not null,
		email_cli varchar(40)null,
		celular_cli varchar(20) null,
		saldo_cli decimal not null,
		primary key(cod_cli));

create table produto
	(
		cod_prod	smallint identity,
		desc_prod	varchar(20)	not null,
		val_unit	decimal(9,2) not null,
		primary key(cod_prod));

create table pedido 
	(
		num_ped		smallint identity,
		valor_ped	decimal	not null,
		data_ped Date default getdate(),
		cd_cli		smallint	not null
		references cliente(cod_cli),
		primary key (num_ped));

create table item_pedido
	(
		num_ped	smallint	identity
	references pedido (num_ped),
		cd_prod		smallint not null
	references produto(cod_prod),
		qtd_ped	float		not null);
