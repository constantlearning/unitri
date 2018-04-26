# CREATE DATABASE vt01;

# drop table chamado_boleto CASCADE ;
# drop table chamado_veiculo CASCADE ;
# drop table motorista_boleto CASCADE ;
# drop table motorista_endereco CASCADE ;
# drop table motorista_veiculo CASCADE ;
# drop table chamado CASCADE ;
# drop table habilitacao CASCADE;
# drop table boleto CASCADE ;
# drop table motorista CASCADE ;
# drop table veiculo CASCADE ;
# drop table conveniada CASCADE ;

-- Chamado
CREATE TABLE chamado(
  id INT AUTO_INCREMENT,
  local_origem VARCHAR(100),
  local_destino VARCHAR(100),
  telefone_contato VARCHAR(11),
  data DATE,
  PRIMARY KEY(id)
);

-- Motorista
CREATE TABLE motorista(
  id INT AUTO_INCREMENT,
  nome VARCHAR(50),
  sexo VARCHAR(1),
  telefone VARCHAR(11),
  data_nascimento DATE,
  PRIMARY KEY(id)
);

-- Veiculo
CREATE TABLE veiculo(
  id INT AUTO_INCREMENT,
  placa VARCHAR(20),
  marca VARCHAR(20),
  ano_modelo DATE,
  ano_fabricacao DATE,
  PRIMARY KEY(id)
);

-- Empresa Conveniada
CREATE TABLE conveniada(
  id INT AUTO_INCREMENT,
  nome VARCHAR(20),
  PRIMARY KEY(id)
);

-- Boleto
CREATE TABLE boleto(
  id INT AUTO_INCREMENT,
  empresa_conveniada INT,
  valor FLOAT,
  PRIMARY KEY(id),
  FOREIGN KEY(empresa_conveniada) REFERENCES conveniada(id)
);

-- endereco_motorista
CREATE TABLE motorista_endereco(
  id INT AUTO_INCREMENT,
  id_motorista INT,
  numero INT,
  logradouro VARCHAR(50),
  cep VARCHAR(8),
  bairro VARCHAR(20),
  cidade VARCHAR(30),
  PRIMARY KEY(id),
  FOREIGN KEY (id_motorista) REFERENCES motorista(id)
);

-- Carteira habilitacao
CREATE TABLE habilitacao(
  id INT AUTO_INCREMENT,
  id_motorista INT,
  categoria_cnh VARCHAR(1),
  data_emissao DATE,
  data_validade DATE,
  PRIMARY KEY(id),
  FOREIGN KEY(id_motorista) REFERENCES motorista(id)
);

-- chamado indica veiculo
CREATE TABLE chamado_veiculo(
  id_chamado INT,
  id_veiculo INT,
  PRIMARY KEY(id_chamado, id_veiculo),
  FOREIGN KEY(id_chamado) REFERENCES chamado(id),
  FOREIGN KEY(id_veiculo) REFERENCES veiculo(id)
);

-- chamado gera boleto
CREATE TABLE chamado_boleto(
  id_chamado INT,
  id_boleto INT,
  PRIMARY KEY(id_chamado, id_boleto),
  FOREIGN KEY(id_chamado) REFERENCES chamado(id),
  FOREIGN KEY(id_boleto) REFERENCES boleto(id)
);

-- motorista recebe boleto
CREATE TABLE motorista_boleto(
  id_motorista INT,
  id_boleto INT,
  PRIMARY KEY(id_motorista, id_boleto),
  FOREIGN KEY(id_motorista) REFERENCES motorista(id),
  FOREIGN KEY(id_boleto) REFERENCES boleto(id)
);

-- motorista dirige veículo
CREATE TABLE motorista_veiculo(
  id_motorista INT,
  id_veiculo INT,
  PRIMARY KEY(id_motorista, id_veiculo),
  FOREIGN KEY(id_motorista) REFERENCES motorista(id),
  FOREIGN KEY(id_veiculo) REFERENCES veiculo(id)
);

-- Populando as tabelas.

-- Conveniada
INSERT INTO conveniada(nome) VALUES ('Conveniada 1');
INSERT INTO conveniada(nome) VALUES ('Conveniada 2');

-- Chamado
INSERT INTO chamado(local_origem, local_destino, telefone_contato, data) VALUES ('Rua a', 'Rua b', '1234-1111', '2018-01-01 00:00:01');
INSERT INTO chamado(local_origem, local_destino, telefone_contato, data) VALUES ('Rua b', 'Rua c', '1234-2222', '2018-02-01 00:00:01');
INSERT INTO chamado(local_origem, local_destino, telefone_contato, data) VALUES ('Rua c', 'Rua d', '1234-3333', '2018-03-01 00:00:01');
INSERT INTO chamado(local_origem, local_destino, telefone_contato, data) VALUES ('Rua d', 'Rua e', '1234-4444', '2018-04-01 00:00:01');
INSERT INTO chamado(local_origem, local_destino, telefone_contato, data) VALUES ('Rua e', 'Rua f', '1234-5555', '2018-05-01 00:00:01');
INSERT INTO chamado(local_origem, local_destino, telefone_contato, data) VALUES ('Rua f', 'Rua g', '1234-6666', '2018-06-01 00:00:01');
INSERT INTO chamado(local_origem, local_destino, telefone_contato, data) VALUES ('Rua g', 'Rua h', '1234-7777', '2018-07-01 00:00:01');
INSERT INTO chamado(local_origem, local_destino, telefone_contato, data) VALUES ('Rua h', 'Rua i', '1234-8888', '2018-08-01 00:00:01');
INSERT INTO chamado(local_origem, local_destino, telefone_contato, data) VALUES ('Rua i', 'Rua j', '1234-9999', '2018-09-01 00:00:01');
INSERT INTO chamado(local_origem, local_destino, telefone_contato, data) VALUES ('Rua j', 'Rua k', '1234-0000', '2018-10-01 00:00:01');

INSERT INTO chamado(local_origem, local_destino, telefone_contato, data) VALUES ('Rua k', 'Rua l', '1234-1212', '2018-11-01 00:00:01');
INSERT INTO chamado(local_origem, local_destino, telefone_contato, data) VALUES ('Rua l', 'Rua m', '1234-1313', '2018-12-01 00:00:01');
INSERT INTO chamado(local_origem, local_destino, telefone_contato, data) VALUES ('Rua m', 'Rua n', '1234-1414', '2018-01-01 00:00:01');
INSERT INTO chamado(local_origem, local_destino, telefone_contato, data) VALUES ('Rua n', 'Rua o', '1234-1515', '2018-02-01 00:00:01');
INSERT INTO chamado(local_origem, local_destino, telefone_contato, data) VALUES ('Rua o', 'Rua p', '1234-1616', '2018-03-01 00:00:01');
INSERT INTO chamado(local_origem, local_destino, telefone_contato, data) VALUES ('Rua p', 'Rua q', '1234-1717', '2018-04-01 00:00:01');
INSERT INTO chamado(local_origem, local_destino, telefone_contato, data) VALUES ('Rua q', 'Rua r', '1234-1818', '2018-05-01 00:00:01');
INSERT INTO chamado(local_origem, local_destino, telefone_contato, data) VALUES ('Rua r', 'Rua s', '1234-1919', '2018-06-01 00:00:01');
INSERT INTO chamado(local_origem, local_destino, telefone_contato, data) VALUES ('Rua s', 'Rua t', '1234-2020', '2018-07-01 00:00:01');
INSERT INTO chamado(local_origem, local_destino, telefone_contato, data) VALUES ('Rua t', 'Rua u', '1234-2121', '2018-08-01 00:00:01');


INSERT INTO chamado(local_origem, local_destino, telefone_contato, data) VALUES ('Rua a', 'Rua b', '1234-1111', '2018-01-01 00:00:01');
INSERT INTO chamado(local_origem, local_destino, telefone_contato, data) VALUES ('Rua b', 'Rua c', '1234-2222', '2018-02-01 00:00:01');
INSERT INTO chamado(local_origem, local_destino, telefone_contato, data) VALUES ('Rua c', 'Rua d', '1234-3333', '2018-03-01 00:00:01');
INSERT INTO chamado(local_origem, local_destino, telefone_contato, data) VALUES ('Rua d', 'Rua e', '1234-4444', '2018-04-01 00:00:01');
INSERT INTO chamado(local_origem, local_destino, telefone_contato, data) VALUES ('Rua e', 'Rua f', '1234-5555', '2018-05-01 00:00:01');
INSERT INTO chamado(local_origem, local_destino, telefone_contato, data) VALUES ('Rua f', 'Rua g', '1234-6666', '2018-06-01 00:00:01');
INSERT INTO chamado(local_origem, local_destino, telefone_contato, data) VALUES ('Rua g', 'Rua h', '1234-7777', '2018-07-01 00:00:01');
INSERT INTO chamado(local_origem, local_destino, telefone_contato, data) VALUES ('Rua h', 'Rua i', '1234-8888', '2018-08-01 00:00:01');
INSERT INTO chamado(local_origem, local_destino, telefone_contato, data) VALUES ('Rua i', 'Rua j', '1234-9999', '2018-09-01 00:00:01');
INSERT INTO chamado(local_origem, local_destino, telefone_contato, data) VALUES ('Rua j', 'Rua k', '1234-0000', '2018-10-01 00:00:01');

INSERT INTO chamado(local_origem, local_destino, telefone_contato, data) VALUES ('Rua k', 'Rua l', '1234-1212', '2018-11-01 00:00:01');
INSERT INTO chamado(local_origem, local_destino, telefone_contato, data) VALUES ('Rua l', 'Rua m', '1234-1313', '2018-12-01 00:00:01');
INSERT INTO chamado(local_origem, local_destino, telefone_contato, data) VALUES ('Rua m', 'Rua n', '1234-1414', '2018-01-01 00:00:01');
INSERT INTO chamado(local_origem, local_destino, telefone_contato, data) VALUES ('Rua n', 'Rua o', '1234-1515', '2018-02-01 00:00:01');
INSERT INTO chamado(local_origem, local_destino, telefone_contato, data) VALUES ('Rua o', 'Rua p', '1234-1616', '2018-03-01 00:00:01');
INSERT INTO chamado(local_origem, local_destino, telefone_contato, data) VALUES ('Rua p', 'Rua q', '1234-1717', '2018-04-01 00:00:01');
INSERT INTO chamado(local_origem, local_destino, telefone_contato, data) VALUES ('Rua q', 'Rua r', '1234-1818', '2018-05-01 00:00:01');
INSERT INTO chamado(local_origem, local_destino, telefone_contato, data) VALUES ('Rua r', 'Rua s', '1234-1919', '2018-06-01 00:00:01');
INSERT INTO chamado(local_origem, local_destino, telefone_contato, data) VALUES ('Rua s', 'Rua t', '1234-2020', '2018-07-01 00:00:01');
INSERT INTO chamado(local_origem, local_destino, telefone_contato, data) VALUES ('Rua t', 'Rua u', '1234-2121', '2018-08-01 00:00:01');

-- Boleto
INSERT INTO boleto(empresa_conveniada, valor) VALUES (1, 50.00);
INSERT INTO boleto(empresa_conveniada, valor) VALUES (1, 80.00);
INSERT INTO boleto(empresa_conveniada, valor) VALUES (1, 100.00);
INSERT INTO boleto(empresa_conveniada, valor) VALUES (1, 35.00);
INSERT INTO boleto(empresa_conveniada, valor) VALUES (1, 22.00);
INSERT INTO boleto(empresa_conveniada, valor) VALUES (1, 89.80);
INSERT INTO boleto(empresa_conveniada, valor) VALUES (1, 39.97);
INSERT INTO boleto(empresa_conveniada, valor) VALUES (1, 68.00);
INSERT INTO boleto(empresa_conveniada, valor) VALUES (1, 77.98);
INSERT INTO boleto(empresa_conveniada, valor) VALUES (1, 63.01);
INSERT INTO boleto(empresa_conveniada, valor) VALUES (1, 50.00);
INSERT INTO boleto(empresa_conveniada, valor) VALUES (1, 80.00);
INSERT INTO boleto(empresa_conveniada, valor) VALUES (1, 100.00);
INSERT INTO boleto(empresa_conveniada, valor) VALUES (1, 35.00);
INSERT INTO boleto(empresa_conveniada, valor) VALUES (1, 22.00);
INSERT INTO boleto(empresa_conveniada, valor) VALUES (1, 89.80);
INSERT INTO boleto(empresa_conveniada, valor) VALUES (1, 39.97);
INSERT INTO boleto(empresa_conveniada, valor) VALUES (1, 68.00);
INSERT INTO boleto(empresa_conveniada, valor) VALUES (1, 77.98);
INSERT INTO boleto(empresa_conveniada, valor) VALUES (1, 63.01);

INSERT INTO boleto(empresa_conveniada, valor) VALUES (2, 80.81);
INSERT INTO boleto(empresa_conveniada, valor) VALUES (2, 34.84);
INSERT INTO boleto(empresa_conveniada, valor) VALUES (2, 85.02);
INSERT INTO boleto(empresa_conveniada, valor) VALUES (2, 76.92);
INSERT INTO boleto(empresa_conveniada, valor) VALUES (2, 77.10);
INSERT INTO boleto(empresa_conveniada, valor) VALUES (2, 75.95);
INSERT INTO boleto(empresa_conveniada, valor) VALUES (2, 99.05);
INSERT INTO boleto(empresa_conveniada, valor) VALUES (2, 71.06);
INSERT INTO boleto(empresa_conveniada, valor) VALUES (2, 88.03);
INSERT INTO boleto(empresa_conveniada, valor) VALUES (2, 99.51);
INSERT INTO boleto(empresa_conveniada, valor) VALUES (2, 80.81);
INSERT INTO boleto(empresa_conveniada, valor) VALUES (2, 34.84);
INSERT INTO boleto(empresa_conveniada, valor) VALUES (2, 85.02);
INSERT INTO boleto(empresa_conveniada, valor) VALUES (2, 76.92);
INSERT INTO boleto(empresa_conveniada, valor) VALUES (2, 77.10);
INSERT INTO boleto(empresa_conveniada, valor) VALUES (2, 75.95);
INSERT INTO boleto(empresa_conveniada, valor) VALUES (2, 99.05);
INSERT INTO boleto(empresa_conveniada, valor) VALUES (2, 71.06);
INSERT INTO boleto(empresa_conveniada, valor) VALUES (2, 88.03);
INSERT INTO boleto(empresa_conveniada, valor) VALUES (2, 99.51);


-- Motorista
INSERT INTO motorista(nome, sexo, telefone, data_nascimento) values ('Motorista 1', 'M', '1111-1111', '1990-01-01 00:00:01');
INSERT INTO motorista(nome, sexo, telefone, data_nascimento) values ('Motorista 2', 'F', '2222-2222', '1991-02-01 00:00:01');
INSERT INTO motorista(nome, sexo, telefone, data_nascimento) values ('Motorista 3', 'M', '3333-3333', '1992-03-01 00:00:01');
INSERT INTO motorista(nome, sexo, telefone, data_nascimento) values ('Motorista 4', 'F', '4444-4444', '1993-04-01 00:00:01');
INSERT INTO motorista(nome, sexo, telefone, data_nascimento) values ('Motorista 5', 'M', '5555-5555', '1994-05-01 00:00:01');
INSERT INTO motorista(nome, sexo, telefone, data_nascimento) values ('Motorista 6', 'F', '6666-6666', '1995-06-01 00:00:01');

-- endereco_motorista
INSERT INTO motorista_endereco(id_motorista, numero, logradouro, cep, bairro, cidade) VALUES (1, 111, 'Rua 1', '1', 'Bairro 1', 'Cidade 1');
INSERT INTO motorista_endereco(id_motorista, numero, logradouro, cep, bairro, cidade) VALUES (2, 222, 'Rua 2', '2', 'Bairro 2', 'Cidade 2');
INSERT INTO motorista_endereco(id_motorista, numero, logradouro, cep, bairro, cidade) VALUES (3, 333, 'Rua 3', '3', 'Bairro 3', 'Cidade 3');
INSERT INTO motorista_endereco(id_motorista, numero, logradouro, cep, bairro, cidade) VALUES (4, 444, 'Rua 4', '4', 'Bairro 4', 'Cidade 4');
INSERT INTO motorista_endereco(id_motorista, numero, logradouro, cep, bairro, cidade) VALUES (5, 555, 'Rua 5', '5', 'Bairro 5', 'Cidade 5');
INSERT INTO motorista_endereco(id_motorista, numero, logradouro, cep, bairro, cidade) VALUES (6, 666, 'Rua 6', '6', 'Bairro 6', 'Cidade 6');

-- Veiculo
INSERT INTO veiculo (placa, marca, ano_modelo, ano_fabricacao) VALUES ('AAA-1981', 'Honda', '2002-01-01', '2001-01-01');
INSERT INTO veiculo (placa, marca, ano_modelo, ano_fabricacao) VALUES ('BBB-5431', 'Chevrolet', '2006-01-01', '2005-01-01');
INSERT INTO veiculo (placa, marca, ano_modelo, ano_fabricacao) VALUES ('CCC-8764', 'Renault', '2009-01-01', '2008-01-01');
INSERT INTO veiculo (placa, marca, ano_modelo, ano_fabricacao) VALUES ('DDD-9864', 'Audi', '1999-01-01', '1998-01-01');
INSERT INTO veiculo (placa, marca, ano_modelo, ano_fabricacao) VALUES ('EEE-8741', 'Kia', '2010-01-01', '2009-01-01');
INSERT INTO veiculo (placa, marca, ano_modelo, ano_fabricacao) VALUES ('FFF-3441', 'Citroen', '2016-01-01','2015-01-01');
INSERT INTO veiculo (placa, marca, ano_modelo, ano_fabricacao) VALUES ('JJJ-1439', 'Land Rover', '2018-01-01', '2017-01-01');

-- Carteira habilitacao
INSERT INTO habilitacao(id_motorista, categoria_cnh, data_emissao, data_validade) VALUES (1, 'B', '2013-04-01', '2018-05-01');
INSERT INTO habilitacao(id_motorista, categoria_cnh, data_emissao, data_validade) VALUES (2, 'B', '2013-04-01', '2018-05-01');
INSERT INTO habilitacao(id_motorista, categoria_cnh, data_emissao, data_validade) VALUES (3, 'B', '2014-03-01', '2019-03-01');
INSERT INTO habilitacao(id_motorista, categoria_cnh, data_emissao, data_validade) VALUES (4, 'B', '2015-05-01', '2020-05-01');
INSERT INTO habilitacao(id_motorista, categoria_cnh, data_emissao, data_validade) VALUES (5, 'B', '2013-09-01', '2018-09-01');
INSERT INTO habilitacao(id_motorista, categoria_cnh, data_emissao, data_validade) VALUES (6, 'B', '2014-03-01', '2019-03-01');

-- motorista dirige veículo
INSERT INTO motorista_veiculo(id_motorista, id_veiculo) values (1, 1);
INSERT INTO motorista_veiculo(id_motorista, id_veiculo) values (2, 2);
INSERT INTO motorista_veiculo(id_motorista, id_veiculo) values (3, 3);
INSERT INTO motorista_veiculo(id_motorista, id_veiculo) values (4, 4);
INSERT INTO motorista_veiculo(id_motorista, id_veiculo) values (5, 5);
INSERT INTO motorista_veiculo(id_motorista, id_veiculo) values (6, 6);
INSERT INTO motorista_veiculo(id_motorista, id_veiculo) values (1, 7);

-- chamado indica veiculo
INSERT INTO chamado_veiculo(id_chamado, id_veiculo) VALUES (1, 1);
INSERT INTO chamado_veiculo(id_chamado, id_veiculo) VALUES (2, 2);
INSERT INTO chamado_veiculo(id_chamado, id_veiculo) VALUES (3, 3);
INSERT INTO chamado_veiculo(id_chamado, id_veiculo) VALUES (4, 4);
INSERT INTO chamado_veiculo(id_chamado, id_veiculo) VALUES (5, 5);
INSERT INTO chamado_veiculo(id_chamado, id_veiculo) VALUES (6, 6);
INSERT INTO chamado_veiculo(id_chamado, id_veiculo) VALUES (7, 1);
INSERT INTO chamado_veiculo(id_chamado, id_veiculo) VALUES (8, 2);
INSERT INTO chamado_veiculo(id_chamado, id_veiculo) VALUES (9, 3);
INSERT INTO chamado_veiculo(id_chamado, id_veiculo) VALUES (10, 4);
INSERT INTO chamado_veiculo(id_chamado, id_veiculo) VALUES (11, 5);
INSERT INTO chamado_veiculo(id_chamado, id_veiculo) VALUES (12, 6);
INSERT INTO chamado_veiculo(id_chamado, id_veiculo) VALUES (13, 1);
INSERT INTO chamado_veiculo(id_chamado, id_veiculo) VALUES (14, 2);
INSERT INTO chamado_veiculo(id_chamado, id_veiculo) VALUES (15, 3);
INSERT INTO chamado_veiculo(id_chamado, id_veiculo) VALUES (16, 4);
INSERT INTO chamado_veiculo(id_chamado, id_veiculo) VALUES (17, 5);
INSERT INTO chamado_veiculo(id_chamado, id_veiculo) VALUES (18, 6);
INSERT INTO chamado_veiculo(id_chamado, id_veiculo) VALUES (19, 7);
INSERT INTO chamado_veiculo(id_chamado, id_veiculo) VALUES (20, 1);
INSERT INTO chamado_veiculo(id_chamado, id_veiculo) VALUES (21, 7);
INSERT INTO chamado_veiculo(id_chamado, id_veiculo) VALUES (22, 6);
INSERT INTO chamado_veiculo(id_chamado, id_veiculo) VALUES (23, 5);
INSERT INTO chamado_veiculo(id_chamado, id_veiculo) VALUES (24, 4);
INSERT INTO chamado_veiculo(id_chamado, id_veiculo) VALUES (25, 3);
INSERT INTO chamado_veiculo(id_chamado, id_veiculo) VALUES (26, 2);
INSERT INTO chamado_veiculo(id_chamado, id_veiculo) VALUES (27, 1);
INSERT INTO chamado_veiculo(id_chamado, id_veiculo) VALUES (28, 7);
INSERT INTO chamado_veiculo(id_chamado, id_veiculo) VALUES (29, 6);
INSERT INTO chamado_veiculo(id_chamado, id_veiculo) VALUES (30, 5);
INSERT INTO chamado_veiculo(id_chamado, id_veiculo) VALUES (31, 4);
INSERT INTO chamado_veiculo(id_chamado, id_veiculo) VALUES (32, 3);
INSERT INTO chamado_veiculo(id_chamado, id_veiculo) VALUES (33, 2);
INSERT INTO chamado_veiculo(id_chamado, id_veiculo) VALUES (34, 1);
INSERT INTO chamado_veiculo(id_chamado, id_veiculo) VALUES (35, 6);
INSERT INTO chamado_veiculo(id_chamado, id_veiculo) VALUES (36, 5);
INSERT INTO chamado_veiculo(id_chamado, id_veiculo) VALUES (37, 4);
INSERT INTO chamado_veiculo(id_chamado, id_veiculo) VALUES (38, 3);
INSERT INTO chamado_veiculo(id_chamado, id_veiculo) VALUES (39, 2);
INSERT INTO chamado_veiculo(id_chamado, id_veiculo) VALUES (40, 1);

-- chamado gera boleto
INSERT INTO chamado_boleto(id_chamado, id_boleto) VALUES (1, 1);
INSERT INTO chamado_boleto(id_chamado, id_boleto) VALUES (2, 2);
INSERT INTO chamado_boleto(id_chamado, id_boleto) VALUES (3, 3);
INSERT INTO chamado_boleto(id_chamado, id_boleto) VALUES (4, 4);
INSERT INTO chamado_boleto(id_chamado, id_boleto) VALUES (5, 5);
INSERT INTO chamado_boleto(id_chamado, id_boleto) VALUES (6, 6);
INSERT INTO chamado_boleto(id_chamado, id_boleto) VALUES (7, 7);
INSERT INTO chamado_boleto(id_chamado, id_boleto) VALUES (8, 8);
INSERT INTO chamado_boleto(id_chamado, id_boleto) VALUES (9, 9);
INSERT INTO chamado_boleto(id_chamado, id_boleto) VALUES (10, 10);
INSERT INTO chamado_boleto(id_chamado, id_boleto) VALUES (11, 11);
INSERT INTO chamado_boleto(id_chamado, id_boleto) VALUES (12, 12);
INSERT INTO chamado_boleto(id_chamado, id_boleto) VALUES (13, 13);
INSERT INTO chamado_boleto(id_chamado, id_boleto) VALUES (14, 14);
INSERT INTO chamado_boleto(id_chamado, id_boleto) VALUES (15, 15);
INSERT INTO chamado_boleto(id_chamado, id_boleto) VALUES (16, 16);
INSERT INTO chamado_boleto(id_chamado, id_boleto) VALUES (17, 17);
INSERT INTO chamado_boleto(id_chamado, id_boleto) VALUES (18, 18);
INSERT INTO chamado_boleto(id_chamado, id_boleto) VALUES (19, 19);
INSERT INTO chamado_boleto(id_chamado, id_boleto) VALUES (20, 20);
INSERT INTO chamado_boleto(id_chamado, id_boleto) VALUES (21, 21);
INSERT INTO chamado_boleto(id_chamado, id_boleto) VALUES (22, 22);
INSERT INTO chamado_boleto(id_chamado, id_boleto) VALUES (23, 23);
INSERT INTO chamado_boleto(id_chamado, id_boleto) VALUES (24, 24);
INSERT INTO chamado_boleto(id_chamado, id_boleto) VALUES (25, 25);
INSERT INTO chamado_boleto(id_chamado, id_boleto) VALUES (26, 26);
INSERT INTO chamado_boleto(id_chamado, id_boleto) VALUES (27, 27);
INSERT INTO chamado_boleto(id_chamado, id_boleto) VALUES (28, 28);
INSERT INTO chamado_boleto(id_chamado, id_boleto) VALUES (29, 29);
INSERT INTO chamado_boleto(id_chamado, id_boleto) VALUES (30, 30);
INSERT INTO chamado_boleto(id_chamado, id_boleto) VALUES (31, 31);
INSERT INTO chamado_boleto(id_chamado, id_boleto) VALUES (32, 32);
INSERT INTO chamado_boleto(id_chamado, id_boleto) VALUES (33, 33);
INSERT INTO chamado_boleto(id_chamado, id_boleto) VALUES (34, 34);
INSERT INTO chamado_boleto(id_chamado, id_boleto) VALUES (35, 35);
INSERT INTO chamado_boleto(id_chamado, id_boleto) VALUES (36, 36);
INSERT INTO chamado_boleto(id_chamado, id_boleto) VALUES (37, 37);
INSERT INTO chamado_boleto(id_chamado, id_boleto) VALUES (38, 38);
INSERT INTO chamado_boleto(id_chamado, id_boleto) VALUES (39, 39);
INSERT INTO chamado_boleto(id_chamado, id_boleto) VALUES (40, 40);

-- motorista recebe boleto
INSERT INTO motorista_boleto(id_motorista, id_boleto) VALUES (1, 1);
INSERT INTO motorista_boleto(id_motorista, id_boleto) VALUES (2, 2);
INSERT INTO motorista_boleto(id_motorista, id_boleto) VALUES (3, 3);
INSERT INTO motorista_boleto(id_motorista, id_boleto) VALUES (4, 4);
INSERT INTO motorista_boleto(id_motorista, id_boleto) VALUES (5, 5);
INSERT INTO motorista_boleto(id_motorista, id_boleto) VALUES (6, 6);
INSERT INTO motorista_boleto(id_motorista, id_boleto) VALUES (1, 7);
INSERT INTO motorista_boleto(id_motorista, id_boleto) VALUES (2, 8);
INSERT INTO motorista_boleto(id_motorista, id_boleto) VALUES (3, 9);
INSERT INTO motorista_boleto(id_motorista, id_boleto) VALUES (4, 10);
INSERT INTO motorista_boleto(id_motorista, id_boleto) VALUES (5, 11);
INSERT INTO motorista_boleto(id_motorista, id_boleto) VALUES (6, 12);
INSERT INTO motorista_boleto(id_motorista, id_boleto) VALUES (1, 13);
INSERT INTO motorista_boleto(id_motorista, id_boleto) VALUES (2, 14);
INSERT INTO motorista_boleto(id_motorista, id_boleto) VALUES (3, 15);
INSERT INTO motorista_boleto(id_motorista, id_boleto) VALUES (4, 16);
INSERT INTO motorista_boleto(id_motorista, id_boleto) VALUES (5, 17);
INSERT INTO motorista_boleto(id_motorista, id_boleto) VALUES (6, 18);
INSERT INTO motorista_boleto(id_motorista, id_boleto) VALUES (1, 19);
INSERT INTO motorista_boleto(id_motorista, id_boleto) VALUES (2, 20);
INSERT INTO motorista_boleto(id_motorista, id_boleto) VALUES (6, 21);
INSERT INTO motorista_boleto(id_motorista, id_boleto) VALUES (5, 22);
INSERT INTO motorista_boleto(id_motorista, id_boleto) VALUES (4, 23);
INSERT INTO motorista_boleto(id_motorista, id_boleto) VALUES (3, 24);
INSERT INTO motorista_boleto(id_motorista, id_boleto) VALUES (2, 25);
INSERT INTO motorista_boleto(id_motorista, id_boleto) VALUES (1, 26);
INSERT INTO motorista_boleto(id_motorista, id_boleto) VALUES (6, 27);
INSERT INTO motorista_boleto(id_motorista, id_boleto) VALUES (5, 28);
INSERT INTO motorista_boleto(id_motorista, id_boleto) VALUES (4, 29);
INSERT INTO motorista_boleto(id_motorista, id_boleto) VALUES (3, 30);
INSERT INTO motorista_boleto(id_motorista, id_boleto) VALUES (2, 31);
INSERT INTO motorista_boleto(id_motorista, id_boleto) VALUES (1, 32);
INSERT INTO motorista_boleto(id_motorista, id_boleto) VALUES (6, 33);
INSERT INTO motorista_boleto(id_motorista, id_boleto) VALUES (5, 34);
INSERT INTO motorista_boleto(id_motorista, id_boleto) VALUES (4, 35);
INSERT INTO motorista_boleto(id_motorista, id_boleto) VALUES (3, 36);
INSERT INTO motorista_boleto(id_motorista, id_boleto) VALUES (2, 37);
INSERT INTO motorista_boleto(id_motorista, id_boleto) VALUES (1, 38);
INSERT INTO motorista_boleto(id_motorista, id_boleto) VALUES (6, 39);
INSERT INTO motorista_boleto(id_motorista, id_boleto) VALUES (5, 40);

-- Consultas

-- 01) Listar cada veículo e o nome do motorista.
SELECT m.nome, v.marca, v.placa
FROM motorista_veiculo
  INNER JOIN motorista m ON motorista_veiculo.id_motorista = m.id
  INNER JOIN veiculo v ON motorista_veiculo.id_veiculo = v.id;

-- 02) Listar a relação dos motoristas aniversariantes do mês (Todos os meses).
SELECT nome, monthname(data_nascimento) mes_aniversario  FROM motorista;

-- 03) Emitir um relatório com o fechamento (valor total mensal) da fatura para conveniada
SELECT
  c.nome             AS nome_conveniada,
  monthname(ch.data) AS mes,
  truncate(sum(b.valor), 2)       AS total
FROM boleto b
  JOIN conveniada c on b.empresa_conveniada = c.id
  JOIN chamado_boleto boleto2 on b.id = boleto2.id_boleto
  JOIN chamado ch on boleto2.id_chamado = ch.id
GROUP BY b.id, ch.data
ORDER BY ch.data ASC;

-- 04) Agrupar os chamados das conveniadas, contando quantos houve em cada mês.
SELECT co.nome, count(co.id) AS quantidade, monthname(c.data) AS mes
FROM boleto b
  JOIN chamado_boleto cb on b.id = cb.id_boleto
  JOIN chamado c on cb.id_chamado = c.id
  JOIN conveniada co on b.empresa_conveniada = co.id
GROUP BY co.id, c.data
ORDER BY c.data ASC;

-- 05) Listar nome dos cinco motoristas com maior faturamento mensal.
SELECT
  m.nome,
  monthname(c.data) AS mes,
  truncate(sum(b.valor),2)      AS faturamento
FROM motorista AS m
  JOIN motorista_boleto mb on m.id = mb.id_motorista
  JOIN boleto b on mb.id_boleto = b.id
  JOIN chamado_boleto ON b.id = chamado_boleto.id_boleto
  JOIN chamado c on chamado_boleto.id_chamado = c.id
GROUP BY m.id, c.data
ORDER BY sum(b.valor) DESC
LIMIT 5;

-- 06) Listar a média de faturamento mensal de cada motorista.
SELECT m.nome AS nome_motorista, truncate(avg(valor), 2) AS media_faturamento, monthname(c.data) AS mes
FROM motorista m
  JOIN motorista_boleto mb on m.id = mb.id_motorista
  JOIN boleto b on mb.id_boleto = b.id
  JOIN chamado_boleto cb on b.id = cb.id_boleto
  JOIN chamado c on cb.id_chamado = c.id
GROUP BY m.id, c.data
ORDER BY c.data ASC;

-- 07) Listar os motoristas com carteira de habilitação a vencer em 30 dias.
SELECT
  m.nome,
  datediff(h.data_validade, curdate()) AS expira_em_dias
FROM motorista AS m
  INNER JOIN habilitacao h ON m.id = h.id_motorista
WHERE datediff(h.data_validade, curdate()) < 30;

-- 08) Crie uma view para listar:
-- 	1- Nome do motorista
--	2- Modelo de automóvel
--	3- Ano de Fabricação / Ano do Modeo (2017 / 2018)
-- 	4- Placa
--	5- CNH
--	6- Data Vencimento CNH

CREATE VIEW v_motorista_veiculo AS
  SELECT
    m.nome  as nome_motorista,
    v.marca as modelo_automovel,
    v.ano_fabricacao,
    v.placa,
    h.data_validade
  FROM motorista AS m
    INNER JOIN motorista_veiculo mv on m.id = mv.id_motorista
    INNER JOIN veiculo v on mv.id_veiculo = v.id
    INNER JOIN habilitacao h on m.id = h.id_motorista;

SELECT * FROM v_motorista_veiculo;
