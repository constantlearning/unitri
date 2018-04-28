-- CREATE DATABASE vt01;

-- drop table chamado_boleto CASCADE CONSTRAINTS;
-- drop table chamado_veiculo CASCADE CONSTRAINTS;
-- drop table motorista_boleto CASCADE CONSTRAINTS;
-- drop table motorista_endereco CASCADE CONSTRAINTS;
-- drop table motorista_veiculo CASCADE CONSTRAINTS;
-- drop table chamado CASCADE CONSTRAINTS;
-- drop table habilitacao CASCADE CONSTRAINTS;
-- drop table boleto CASCADE CONSTRAINTS;
-- drop table motorista CASCADE CONSTRAINTS;
-- drop table veiculo CASCADE CONSTRAINTS;
-- drop table conveniada CASCADE CONSTRAINTS;

-- Chamado
CREATE TABLE chamado (
  id               INT,
  local_origem     VARCHAR(100),
  local_destino    VARCHAR(100),
  telefone_contato VARCHAR(11),
  data             DATE,
  PRIMARY KEY (id)
);

-- Motorista
CREATE TABLE motorista (
  id              INT,
  nome            VARCHAR(50),
  sexo            VARCHAR(1),
  telefone        VARCHAR(11),
  data_nascimento DATE,
  PRIMARY KEY (id)
);

-- Veiculo
CREATE TABLE veiculo (
  id             INT,
  placa          VARCHAR(20),
  marca          VARCHAR(20),
  ano_modelo     DATE,
  ano_fabricacao DATE,
  PRIMARY KEY (id)
);

-- Empresa Conveniada
CREATE TABLE conveniada (
  id   INT,
  nome VARCHAR(20),
  PRIMARY KEY (id)
);

-- Boleto
CREATE TABLE boleto (
  id                 INT,
  empresa_conveniada INT,
  valor              FLOAT,
  PRIMARY KEY (id),
  FOREIGN KEY (empresa_conveniada) REFERENCES conveniada (id)
);

-- endereco_motorista
CREATE TABLE motorista_endereco (
  id           INT,
  id_motorista INT,
  numero       INT,
  logradouro   VARCHAR(50),
  cep          VARCHAR(8),
  bairro       VARCHAR(20),
  cidade       VARCHAR(30),
  PRIMARY KEY (id),
  FOREIGN KEY (id_motorista) REFERENCES motorista (id)
);

-- Carteira habilitacao
CREATE TABLE habilitacao (
  id            INT,
  id_motorista  INT,
  categoria_cnh VARCHAR(1),
  data_emissao  DATE,
  data_validade DATE,
  PRIMARY KEY (id),
  FOREIGN KEY (id_motorista) REFERENCES motorista (id)
);

-- chamado indica veiculo
CREATE TABLE chamado_veiculo (
  id_chamado INT,
  id_veiculo INT,
  PRIMARY KEY (id_chamado, id_veiculo),
  FOREIGN KEY (id_chamado) REFERENCES chamado (id),
  FOREIGN KEY (id_veiculo) REFERENCES veiculo (id)
);

-- chamado gera boleto
CREATE TABLE chamado_boleto (
  id_chamado INT,
  id_boleto  INT,
  PRIMARY KEY (id_chamado, id_boleto),
  FOREIGN KEY (id_chamado) REFERENCES chamado (id),
  FOREIGN KEY (id_boleto) REFERENCES boleto (id)
);

-- motorista recebe boleto
CREATE TABLE motorista_boleto (
  id_motorista INT,
  id_boleto    INT,
  PRIMARY KEY (id_motorista, id_boleto),
  FOREIGN KEY (id_motorista) REFERENCES motorista (id),
  FOREIGN KEY (id_boleto) REFERENCES boleto (id)
);

-- motorista dirige veículo
CREATE TABLE motorista_veiculo (
  id_motorista INT,
  id_veiculo   INT,
  PRIMARY KEY (id_motorista, id_veiculo),
  FOREIGN KEY (id_motorista) REFERENCES motorista (id),
  FOREIGN KEY (id_veiculo) REFERENCES veiculo (id)
);

-- Populando as tabelas.

-- Conveniada
INSERT INTO conveniada VALUES (1, 'Conveniada 1');
INSERT INTO conveniada VALUES (2, 'Conveniada 2');

-- Chamado
INSERT INTO chamado VALUES (1, 'Rua a', 'Rua b', '1234-1111', TO_DATE('2018-01-01', 'yyyy/mm/dd'));
INSERT INTO chamado VALUES (2, 'Rua b', 'Rua c', '1234-2222', TO_DATE('2018-02-01', 'yyyy/mm/dd'));
INSERT INTO chamado VALUES (3, 'Rua c', 'Rua d', '1234-3333', TO_DATE('2018-03-01', 'yyyy/mm/dd'));
INSERT INTO chamado VALUES (4, 'Rua d', 'Rua e', '1234-4444', TO_DATE('2018-04-01', 'yyyy/mm/dd'));
INSERT INTO chamado VALUES (5, 'Rua e', 'Rua f', '1234-5555', TO_DATE('2018-05-01', 'yyyy/mm/dd'));
INSERT INTO chamado VALUES (6, 'Rua f', 'Rua g', '1234-6666', TO_DATE('2018-06-01', 'yyyy/mm/dd'));
INSERT INTO chamado VALUES (7, 'Rua g', 'Rua h', '1234-7777', TO_DATE('2018-07-01', 'yyyy/mm/dd'));
INSERT INTO chamado VALUES (8, 'Rua h', 'Rua i', '1234-8888', TO_DATE('2018-08-01', 'yyyy/mm/dd'));
INSERT INTO chamado VALUES (9, 'Rua i', 'Rua j', '1234-9999', TO_DATE('2018-09-01', 'yyyy/mm/dd'));
INSERT INTO chamado VALUES (10, 'Rua j', 'Rua k', '1234-0000', TO_DATE('2018-10-01', 'yyyy/mm/dd'));
INSERT INTO chamado VALUES (11, 'Rua k', 'Rua l', '1234-1212', TO_DATE('2018-11-01', 'yyyy/mm/dd'));
INSERT INTO chamado VALUES (12, 'Rua l', 'Rua m', '1234-1313', TO_DATE('2018-12-01', 'yyyy/mm/dd'));
INSERT INTO chamado VALUES (13, 'Rua m', 'Rua n', '1234-1414', TO_DATE('2018-01-01', 'yyyy/mm/dd'));
INSERT INTO chamado VALUES (14, 'Rua n', 'Rua o', '1234-1515', TO_DATE('2018-02-01', 'yyyy/mm/dd'));
INSERT INTO chamado VALUES (15, 'Rua o', 'Rua p', '1234-1616', TO_DATE('2018-03-01', 'yyyy/mm/dd'));
INSERT INTO chamado VALUES (16, 'Rua p', 'Rua q', '1234-1717', TO_DATE('2018-04-01', 'yyyy/mm/dd'));
INSERT INTO chamado VALUES (17, 'Rua q', 'Rua r', '1234-1818', TO_DATE('2018-05-01', 'yyyy/mm/dd'));
INSERT INTO chamado VALUES (18, 'Rua r', 'Rua s', '1234-1919', TO_DATE('2018-06-01', 'yyyy/mm/dd'));
INSERT INTO chamado VALUES (19, 'Rua s', 'Rua t', '1234-2020', TO_DATE('2018-07-01', 'yyyy/mm/dd'));
INSERT INTO chamado VALUES (20, 'Rua t', 'Rua u', '1234-2121', TO_DATE('2018-08-01', 'yyyy/mm/dd'));
INSERT INTO chamado VALUES (21, 'Rua a', 'Rua b', '1234-1111', TO_DATE('2018-01-01', 'yyyy/mm/dd'));
INSERT INTO chamado VALUES (22, 'Rua b', 'Rua c', '1234-2222', TO_DATE('2018-02-01', 'yyyy/mm/dd'));
INSERT INTO chamado VALUES (23, 'Rua c', 'Rua d', '1234-3333', TO_DATE('2018-03-01', 'yyyy/mm/dd'));
INSERT INTO chamado VALUES (24, 'Rua d', 'Rua e', '1234-4444', TO_DATE('2018-04-01', 'yyyy/mm/dd'));
INSERT INTO chamado VALUES (25, 'Rua e', 'Rua f', '1234-5555', TO_DATE('2018-05-01', 'yyyy/mm/dd'));
INSERT INTO chamado VALUES (26, 'Rua f', 'Rua g', '1234-6666', TO_DATE('2018-06-01', 'yyyy/mm/dd'));
INSERT INTO chamado VALUES (27, 'Rua g', 'Rua h', '1234-7777', TO_DATE('2018-07-01', 'yyyy/mm/dd'));
INSERT INTO chamado VALUES (28, 'Rua h', 'Rua i', '1234-8888', TO_DATE('2018-08-01', 'yyyy/mm/dd'));
INSERT INTO chamado VALUES (29, 'Rua i', 'Rua j', '1234-9999', TO_DATE('2018-09-01', 'yyyy/mm/dd'));
INSERT INTO chamado VALUES (30, 'Rua j', 'Rua k', '1234-0000', TO_DATE('2018-10-01', 'yyyy/mm/dd'));
INSERT INTO chamado VALUES (31, 'Rua k', 'Rua l', '1234-1212', TO_DATE('2018-11-01', 'yyyy/mm/dd'));
INSERT INTO chamado VALUES (32, 'Rua l', 'Rua m', '1234-1313', TO_DATE('2018-12-01', 'yyyy/mm/dd'));
INSERT INTO chamado VALUES (33, 'Rua m', 'Rua n', '1234-1414', TO_DATE('2018-01-01', 'yyyy/mm/dd'));
INSERT INTO chamado VALUES (34, 'Rua n', 'Rua o', '1234-1515', TO_DATE('2018-02-01', 'yyyy/mm/dd'));
INSERT INTO chamado VALUES (35, 'Rua o', 'Rua p', '1234-1616', TO_DATE('2018-03-01', 'yyyy/mm/dd'));
INSERT INTO chamado VALUES (36, 'Rua p', 'Rua q', '1234-1717', TO_DATE('2018-04-01', 'yyyy/mm/dd'));
INSERT INTO chamado VALUES (37, 'Rua q', 'Rua r', '1234-1818', TO_DATE('2018-05-01', 'yyyy/mm/dd'));
INSERT INTO chamado VALUES (38, 'Rua r', 'Rua s', '1234-1919', TO_DATE('2018-06-01', 'yyyy/mm/dd'));
INSERT INTO chamado VALUES (39, 'Rua s', 'Rua t', '1234-2020', TO_DATE('2018-07-01', 'yyyy/mm/dd'));
INSERT INTO chamado VALUES (40, 'Rua t', 'Rua u', '1234-2121', TO_DATE('2018-08-01', 'yyyy/mm/dd'));

-- Boleto
INSERT INTO boleto VALUES (1, 1, 50.00);
INSERT INTO boleto VALUES (2, 1, 80.00);
INSERT INTO boleto VALUES (3, 1, 100.00);
INSERT INTO boleto VALUES (4, 1, 35.00);
INSERT INTO boleto VALUES (5, 1, 22.00);
INSERT INTO boleto VALUES (6, 1, 89.80);
INSERT INTO boleto VALUES (7, 1, 39.97);
INSERT INTO boleto VALUES (8, 1, 68.00);
INSERT INTO boleto VALUES (9, 1, 77.98);
INSERT INTO boleto VALUES (10, 1, 63.01);
INSERT INTO boleto VALUES (11, 1, 50.00);
INSERT INTO boleto VALUES (12, 1, 80.00);
INSERT INTO boleto VALUES (13, 1, 100.00);
INSERT INTO boleto VALUES (14, 1, 35.00);
INSERT INTO boleto VALUES (15, 1, 22.00);
INSERT INTO boleto VALUES (16, 1, 89.80);
INSERT INTO boleto VALUES (17, 1, 39.97);
INSERT INTO boleto VALUES (18, 1, 68.00);
INSERT INTO boleto VALUES (19, 1, 77.98);
INSERT INTO boleto VALUES (20, 1, 63.01);
INSERT INTO boleto VALUES (21, 2, 80.81);
INSERT INTO boleto VALUES (22, 2, 34.84);
INSERT INTO boleto VALUES (23, 2, 85.02);
INSERT INTO boleto VALUES (24, 2, 76.92);
INSERT INTO boleto VALUES (25, 2, 77.10);
INSERT INTO boleto VALUES (26, 2, 75.95);
INSERT INTO boleto VALUES (27, 2, 99.05);
INSERT INTO boleto VALUES (28, 2, 71.06);
INSERT INTO boleto VALUES (29, 2, 88.03);
INSERT INTO boleto VALUES (30, 2, 99.51);
INSERT INTO boleto VALUES (31, 2, 80.81);
INSERT INTO boleto VALUES (32, 2, 34.84);
INSERT INTO boleto VALUES (33, 2, 85.02);
INSERT INTO boleto VALUES (34, 2, 76.92);
INSERT INTO boleto VALUES (35, 2, 77.10);
INSERT INTO boleto VALUES (36, 2, 75.95);
INSERT INTO boleto VALUES (37, 2, 99.05);
INSERT INTO boleto VALUES (38, 2, 71.06);
INSERT INTO boleto VALUES (39, 2, 88.03);
INSERT INTO boleto VALUES (40, 2, 99.51);

-- Motorista
INSERT INTO motorista values (1, 'Motorista 1', 'M', '1111-1111', TO_DATE('1990-01-01', 'yyyy/mm/dd'));
INSERT INTO motorista values (2, 'Motorista 2', 'F', '2222-2222', TO_DATE('1991-02-01', 'yyyy/mm/dd'));
INSERT INTO motorista values (3, 'Motorista 3', 'M', '3333-3333', TO_DATE('1992-03-01', 'yyyy/mm/dd'));
INSERT INTO motorista values (4, 'Motorista 4', 'F', '4444-4444', TO_DATE('1993-04-01', 'yyyy/mm/dd'));
INSERT INTO motorista values (5, 'Motorista 5', 'M', '5555-5555', TO_DATE('1994-05-01', 'yyyy/mm/dd'));
INSERT INTO motorista values (6, 'Motorista 6', 'F', '6666-6666', TO_DATE('1995-06-01', 'yyyy/mm/dd'));

-- endereco_motorista
INSERT INTO motorista_endereco VALUES (1, 1, 111, 'Rua 1', '1', 'Bairro 1', 'Cidade 1');
INSERT INTO motorista_endereco VALUES (2, 2, 222, 'Rua 2', '2', 'Bairro 2', 'Cidade 2');
INSERT INTO motorista_endereco VALUES (3, 3, 333, 'Rua 3', '3', 'Bairro 3', 'Cidade 3');
INSERT INTO motorista_endereco VALUES (4, 4, 444, 'Rua 4', '4', 'Bairro 4', 'Cidade 4');
INSERT INTO motorista_endereco VALUES (5, 5, 555, 'Rua 5', '5', 'Bairro 5', 'Cidade 5');
INSERT INTO motorista_endereco VALUES (6, 6, 666, 'Rua 6', '6', 'Bairro 6', 'Cidade 6');

-- Veiculo
INSERT INTO veiculo
VALUES (1, 'AAA-1981', 'Honda', TO_DATE('2002-01-01', 'yyyy/mm/dd'), TO_DATE('2001-01-01', 'yyyy/mm/dd'));
INSERT INTO veiculo
VALUES (2, 'BBB-5431', 'Chevrolet', TO_DATE('2006-01-01', 'yyyy/mm/dd'), TO_DATE('2005-01-01', 'yyyy/mm/dd'));
INSERT INTO veiculo
VALUES (3, 'CCC-8764', 'Renault', TO_DATE('2009-01-01', 'yyyy/mm/dd'), TO_DATE('2008-01-01', 'yyyy/mm/dd'));
INSERT INTO veiculo
VALUES (4, 'DDD-9864', 'Audi', TO_DATE('1999-01-01', 'yyyy/mm/dd'), TO_DATE('1998-01-01', 'yyyy/mm/dd'));
INSERT INTO veiculo
VALUES (5, 'EEE-8741', 'Kia', TO_DATE('2010-01-01', 'yyyy/mm/dd'), TO_DATE('2009-01-01', 'yyyy/mm/dd'));
INSERT INTO veiculo
VALUES (6, 'FFF-3441', 'Citroen', TO_DATE('2016-01-01', 'yyyy/mm/dd'), TO_DATE('2015-01-01', 'yyyy/mm/dd'));
INSERT INTO veiculo
VALUES (7, 'JJJ-1439', 'Land Rover', TO_DATE('2018-01-01', 'yyyy/mm/dd'), TO_DATE('2017-01-01', 'yyyy/mm/dd'));

-- Carteira habilitacao
INSERT INTO habilitacao VALUES (1, 1, 'B', TO_DATE('2013-04-01', 'yyyy/mm/dd'), TO_DATE('2018-05-01', 'yyyy/mm/dd'));
INSERT INTO habilitacao VALUES (2, 2, 'B', TO_DATE('2013-04-01', 'yyyy/mm/dd'), TO_DATE('2018-05-01', 'yyyy/mm/dd'));
INSERT INTO habilitacao VALUES (3, 3, 'B', TO_DATE('2014-03-01', 'yyyy/mm/dd'), TO_DATE('2019-03-01', 'yyyy/mm/dd'));
INSERT INTO habilitacao VALUES (4, 4, 'B', TO_DATE('2015-05-01', 'yyyy/mm/dd'), TO_DATE('2020-05-01', 'yyyy/mm/dd'));
INSERT INTO habilitacao VALUES (5, 5, 'B', TO_DATE('2013-09-01', 'yyyy/mm/dd'), TO_DATE('2018-09-01', 'yyyy/mm/dd'));
INSERT INTO habilitacao VALUES (6, 6, 'B', TO_DATE('2014-03-01', 'yyyy/mm/dd'), TO_DATE('2019-03-01', 'yyyy/mm/dd'));

-- motorista dirige veículo
INSERT INTO motorista_veiculo VALUES (1, 1);
INSERT INTO motorista_veiculo VALUES (2, 2);
INSERT INTO motorista_veiculo VALUES (3, 3);
INSERT INTO motorista_veiculo VALUES (4, 4);
INSERT INTO motorista_veiculo VALUES (5, 5);
INSERT INTO motorista_veiculo VALUES (6, 6);
INSERT INTO motorista_veiculo VALUES (1, 7);

-- chamado indica veiculo
INSERT INTO chamado_veiculo VALUES (1, 1);
INSERT INTO chamado_veiculo VALUES (2, 2);
INSERT INTO chamado_veiculo VALUES (3, 3);
INSERT INTO chamado_veiculo VALUES (4, 4);
INSERT INTO chamado_veiculo VALUES (5, 5);
INSERT INTO chamado_veiculo VALUES (6, 6);
INSERT INTO chamado_veiculo VALUES (7, 1);
INSERT INTO chamado_veiculo VALUES (8, 2);
INSERT INTO chamado_veiculo VALUES (9, 3);
INSERT INTO chamado_veiculo VALUES (10, 4);
INSERT INTO chamado_veiculo VALUES (11, 5);
INSERT INTO chamado_veiculo VALUES (12, 6);
INSERT INTO chamado_veiculo VALUES (13, 1);
INSERT INTO chamado_veiculo VALUES (14, 2);
INSERT INTO chamado_veiculo VALUES (15, 3);
INSERT INTO chamado_veiculo VALUES (16, 4);
INSERT INTO chamado_veiculo VALUES (17, 5);
INSERT INTO chamado_veiculo VALUES (18, 6);
INSERT INTO chamado_veiculo VALUES (19, 7);
INSERT INTO chamado_veiculo VALUES (20, 1);
INSERT INTO chamado_veiculo VALUES (21, 7);
INSERT INTO chamado_veiculo VALUES (22, 6);
INSERT INTO chamado_veiculo VALUES (23, 5);
INSERT INTO chamado_veiculo VALUES (24, 4);
INSERT INTO chamado_veiculo VALUES (25, 3);
INSERT INTO chamado_veiculo VALUES (26, 2);
INSERT INTO chamado_veiculo VALUES (27, 1);
INSERT INTO chamado_veiculo VALUES (28, 7);
INSERT INTO chamado_veiculo VALUES (29, 6);
INSERT INTO chamado_veiculo VALUES (30, 5);
INSERT INTO chamado_veiculo VALUES (31, 4);
INSERT INTO chamado_veiculo VALUES (32, 3);
INSERT INTO chamado_veiculo VALUES (33, 2);
INSERT INTO chamado_veiculo VALUES (34, 1);
INSERT INTO chamado_veiculo VALUES (35, 6);
INSERT INTO chamado_veiculo VALUES (36, 5);
INSERT INTO chamado_veiculo VALUES (37, 4);
INSERT INTO chamado_veiculo VALUES (38, 3);
INSERT INTO chamado_veiculo VALUES (39, 2);
INSERT INTO chamado_veiculo VALUES (40, 1);

-- chamado gera boleto
INSERT INTO chamado_boleto VALUES (1, 1);
INSERT INTO chamado_boleto VALUES (2, 2);
INSERT INTO chamado_boleto VALUES (3, 3);
INSERT INTO chamado_boleto VALUES (4, 4);
INSERT INTO chamado_boleto VALUES (5, 5);
INSERT INTO chamado_boleto VALUES (6, 6);
INSERT INTO chamado_boleto VALUES (7, 7);
INSERT INTO chamado_boleto VALUES (8, 8);
INSERT INTO chamado_boleto VALUES (9, 9);
INSERT INTO chamado_boleto VALUES (10, 10);
INSERT INTO chamado_boleto VALUES (11, 11);
INSERT INTO chamado_boleto VALUES (12, 12);
INSERT INTO chamado_boleto VALUES (13, 13);
INSERT INTO chamado_boleto VALUES (14, 14);
INSERT INTO chamado_boleto VALUES (15, 15);
INSERT INTO chamado_boleto VALUES (16, 16);
INSERT INTO chamado_boleto VALUES (17, 17);
INSERT INTO chamado_boleto VALUES (18, 18);
INSERT INTO chamado_boleto VALUES (19, 19);
INSERT INTO chamado_boleto VALUES (20, 20);
INSERT INTO chamado_boleto VALUES (21, 21);
INSERT INTO chamado_boleto VALUES (22, 22);
INSERT INTO chamado_boleto VALUES (23, 23);
INSERT INTO chamado_boleto VALUES (24, 24);
INSERT INTO chamado_boleto VALUES (25, 25);
INSERT INTO chamado_boleto VALUES (26, 26);
INSERT INTO chamado_boleto VALUES (27, 27);
INSERT INTO chamado_boleto VALUES (28, 28);
INSERT INTO chamado_boleto VALUES (29, 29);
INSERT INTO chamado_boleto VALUES (30, 30);
INSERT INTO chamado_boleto VALUES (31, 31);
INSERT INTO chamado_boleto VALUES (32, 32);
INSERT INTO chamado_boleto VALUES (33, 33);
INSERT INTO chamado_boleto VALUES (34, 34);
INSERT INTO chamado_boleto VALUES (35, 35);
INSERT INTO chamado_boleto VALUES (36, 36);
INSERT INTO chamado_boleto VALUES (37, 37);
INSERT INTO chamado_boleto VALUES (38, 38);
INSERT INTO chamado_boleto VALUES (39, 39);
INSERT INTO chamado_boleto VALUES (40, 40);

-- motorista recebe boleto
INSERT INTO motorista_boleto VALUES (1, 1);
INSERT INTO motorista_boleto VALUES (2, 2);
INSERT INTO motorista_boleto VALUES (3, 3);
INSERT INTO motorista_boleto VALUES (4, 4);
INSERT INTO motorista_boleto VALUES (5, 5);
INSERT INTO motorista_boleto VALUES (6, 6);
INSERT INTO motorista_boleto VALUES (1, 7);
INSERT INTO motorista_boleto VALUES (2, 8);
INSERT INTO motorista_boleto VALUES (3, 9);
INSERT INTO motorista_boleto VALUES (4, 10);
INSERT INTO motorista_boleto VALUES (5, 11);
INSERT INTO motorista_boleto VALUES (6, 12);
INSERT INTO motorista_boleto VALUES (1, 13);
INSERT INTO motorista_boleto VALUES (2, 14);
INSERT INTO motorista_boleto VALUES (3, 15);
INSERT INTO motorista_boleto VALUES (4, 16);
INSERT INTO motorista_boleto VALUES (5, 17);
INSERT INTO motorista_boleto VALUES (6, 18);
INSERT INTO motorista_boleto VALUES (1, 19);
INSERT INTO motorista_boleto VALUES (2, 20);
INSERT INTO motorista_boleto VALUES (6, 21);
INSERT INTO motorista_boleto VALUES (5, 22);
INSERT INTO motorista_boleto VALUES (4, 23);
INSERT INTO motorista_boleto VALUES (3, 24);
INSERT INTO motorista_boleto VALUES (2, 25);
INSERT INTO motorista_boleto VALUES (1, 26);
INSERT INTO motorista_boleto VALUES (6, 27);
INSERT INTO motorista_boleto VALUES (5, 28);
INSERT INTO motorista_boleto VALUES (4, 29);
INSERT INTO motorista_boleto VALUES (3, 30);
INSERT INTO motorista_boleto VALUES (2, 31);
INSERT INTO motorista_boleto VALUES (1, 32);
INSERT INTO motorista_boleto VALUES (6, 33);
INSERT INTO motorista_boleto VALUES (5, 34);
INSERT INTO motorista_boleto VALUES (4, 35);
INSERT INTO motorista_boleto VALUES (3, 36);
INSERT INTO motorista_boleto VALUES (2, 37);
INSERT INTO motorista_boleto VALUES (1, 38);
INSERT INTO motorista_boleto VALUES (6, 39);
INSERT INTO motorista_boleto VALUES (5, 40);

-- Consultas

-- 01) Listar cada veículo e o nome do motorista.
SELECT
  m.nome,
  v.marca,
  v.placa
FROM motorista_veiculo
  INNER JOIN motorista m ON motorista_veiculo.id_motorista = m.id
  INNER JOIN veiculo v ON motorista_veiculo.id_veiculo = v.id;

-- 02) Listar a relação dos motoristas aniversariantes do mês (Todos os meses).
SELECT
  nome,
  to_char(data_nascimento, 'MONTH') mes_aniversario
FROM motorista;

-- 03) Emitir um relatório com o fechamento (valor total mensal) da fatura para conveniada
SELECT
  c.nome                    nome_conveniada,
  to_char(ch.data, 'MONTH') mes,
  sum(b.valor)              total
FROM boleto b
  JOIN conveniada c on b.empresa_conveniada = c.id
  JOIN chamado_boleto cb on b.id = cb.id_boleto
  JOIN chamado ch on cb.id_chamado = ch.id
GROUP BY b.id, ch.data, c.nome
ORDER BY ch.data ASC;

-- 04) Agrupar os chamados das conveniadas, contando quantos houve em cada mês.
SELECT
  co.nome,
  count(co.id) AS          quantidade,
  to_char(c.data, 'MONTH') mes
FROM boleto b
  JOIN chamado_boleto cb on b.id = cb.id_boleto
  JOIN chamado c on cb.id_chamado = c.id
  JOIN conveniada co on b.empresa_conveniada = co.id
GROUP BY co.id, c.data, co.nome
ORDER BY c.data ASC;

-- 05) Listar nome dos cinco motoristas com maior faturamento mensal.
SELECT
  m.nome,
  to_char(c.data, 'MONTH') mes,
  sum(b.valor)             faturamento
FROM motorista m
  JOIN motorista_boleto mb on m.id = mb.id_motorista
  JOIN boleto b on mb.id_boleto = b.id
  JOIN chamado_boleto ON b.id = chamado_boleto.id_boleto
  JOIN chamado c on chamado_boleto.id_chamado = c.id
GROUP BY m.id, c.data, m.nome
ORDER BY sum(b.valor) DESC
-- FALTA LIMIT;

-- 06) Listar a média de faturamento mensal de cada motorista.
SELECT
  m.nome                   nome_motorista,
  avg(valor)               media_faturamento,
  to_char(c.data, 'MONTH') mes
FROM motorista m
  JOIN motorista_boleto mb on m.id = mb.id_motorista
  JOIN boleto b on mb.id_boleto = b.id
  JOIN chamado_boleto cb on b.id = cb.id_boleto
  JOIN chamado c on cb.id_chamado = c.id
GROUP BY m.id, c.data, m.nome
ORDER BY c.data ASC;

-- 07) Listar os motoristas com carteira de habilitação a vencer em 30 dias.
SELECT
  m.nome,
  (h.data_validade- CURRENT_DATE()) AS expira_em_dias
FROM motorista m
  INNER JOIN habilitacao h ON m.id = h.id_motorista
WHERE (h.data_validade - CURRENT_DATE()) < 30;

-- 08) Crie uma view para listar:
-- 	1- Nome do motorista
--	2- Modelo de automóvel
--	3- Ano de Fabricação / Ano do Modeo (2017 / 2018)
-- 	4- Placa
--	5- CNH
--	6- Data Vencimento CNH

CREATE VIEW v_motorista_veiculo AS
  SELECT
    m.nome  nome_motorista,
    v.marca modelo_automovel,
    v.ano_fabricacao,
    v.placa,
    h.data_validade
  FROM motorista m
    INNER JOIN motorista_veiculo mv on m.id = mv.id_motorista
    INNER JOIN veiculo v on mv.id_veiculo = v.id
    INNER JOIN habilitacao h on m.id = h.id_motorista;

SELECT * FROM v_motorista_veiculo;

