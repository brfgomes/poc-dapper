CREATE TABLE IF NOT EXISTS persons (
	pers_id UUID PRIMARY KEY NOT NULL,
	pers_name VARCHAR(50) NOT NULL,
	pers_years INT NOT NULL,
	pers_email VARCHAR(150) not null,
	pers_cnpj VARCHAR(244) not null,
	pers_creation_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);
CREATE TABLE IF NOT EXISTS products (
	prod_id UUID PRIMARY KEY NOT NULL,
	prod_description VARCHAR(255) NOT NULL,
	prod_quantity INT NOT NULL,
	prod_price DECIMAL NOT NULL,
	pers_creation_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);
CREATE TABLE IF NOT EXISTS orders (
	ords_id UUID PRIMARY KEY NOT NULL,
	ords_pers_id UUID NOT NULL,
	ords_prod_id UUID NOT NULL,
	ords_sequence UUID NOT NULL,
	pers_creation_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);