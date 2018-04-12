-- Lista de Exercícios

-- funcionario(nome, cpf, sexo, cpf_supervisor, end, dptonro, salario)
-- departamento(dptonro, nome)
-- projeto(nroproj, dptonro, horas)
-- trabalha_em (projnro, cpf, horas)
-- dependente (cpffuncionario, nome, parentesco)

CREATE TABLE departamento(
	id INT AUTO_INCREMENT,
    nome VARCHAR(50),
    PRIMARY KEY (id)
);

CREATE TABLE projeto(
	id INT AUTO_INCREMENT,
    id_dpto INT,
    nome VARCHAR(50),
    horas INT,
    PRIMARY KEY(id),
    FOREIGN KEY(id_dpto) REFERENCES departamento(id)
);

CREATE TABLE funcionario(
	id 	INT AUTO_INCREMENT,
	id_departamento INT,
    nome VARCHAR(50),
    cpf INT(11),
    sexo VARCHAR(1),
    cpf_supervisor INT(11),
    endereco VARCHAR(30),
    salario FLOAT,
    PRIMARY KEY (id),
    FOREIGN KEY (id_departamento) REFERENCES departamento(id)
);

CREATE TABLE trabalha_em(
	id INT AUTO_INCREMENT,
    id_func INT,
    id_proj INT,
    horas INT,
    PRIMARY KEY(id),
    FOREIGN KEY(id_proj) REFERENCES projeto(id),
    FOREIGN KEY(id_func) REFERENCES funcionario(id)
);

CREATE TABLE dependente(
	id INT AUTO_INCREMENT,
    id_func INT,
    nome VARCHAR(50),
    parentesco VARCHAR(20),
    PRIMARY KEY(id),
    FOREIGN KEY (id_func) REFERENCES funcionario(id)
);

-- departamento
INSERT INTO departamento(nome) VALUES("Desenvolvimento");
INSERT INTO departamento(nome) VALUES("Administração");
INSERT INTO departamento(nome) VALUES("Contabilidade");
INSERT INTO departamento(nome) VALUES("Limpeza");

-- projeto
INSERT INTO projeto(id_dpto, nome, horas) VALUES(1, "Bank", 150);
INSERT INTO projeto(id_dpto, nome, horas) VALUES(1, "Telecom", 100);
INSERT INTO projeto(id_dpto, nome, horas) VALUES(2, "Cordenação", 50);
INSERT INTO projeto(id_dpto, nome, horas) VALUES(3, "Folha de pagamento", 20);
INSERT INTO projeto(id_dpto, nome, horas) VALUES(4, "Não sei", 30);

-- funcionario
INSERT INTO funcionario(id_departamento, nome, cpf, sexo, cpf_supervisor, endereco, salario) VALUES(1, "Lucas Gontijo", 1111111111, 'M', 222222222, 'Rua teste 123', 800.00);
INSERT INTO funcionario(id_departamento, nome, cpf, sexo, cpf_supervisor, endereco, salario) VALUES(1, "Vito Corleone", 222222222, 'F', null, 'Rua teste 312', 900.00);
INSERT INTO funcionario(id_departamento, nome, cpf, sexo, cpf_supervisor, endereco, salario) VALUES(2, "Luca Brasi", 333333333, 'M', 222222222, 'Rua teste 456', 850.00);
INSERT INTO funcionario(id_departamento, nome, cpf, sexo, cpf_supervisor, endereco, salario) VALUES(2, "Tom Hagen", 444444444, 'F', 666666666, 'Rua teste 654', 950.00);
INSERT INTO funcionario(id_departamento, nome, cpf, sexo, cpf_supervisor, endereco, salario) VALUES(3, "Sonny Corleone", 555555555, 'M', 222222222, 'Rua teste 789', 875.00);
INSERT INTO funcionario(id_departamento, nome, cpf, sexo, cpf_supervisor, endereco, salario) VALUES(3, "Salvatore Tessio", 666666666, 'F', null, 'Rua teste 987', 975.00);
INSERT INTO funcionario(id_departamento, nome, cpf, sexo, cpf_supervisor, endereco, salario) VALUES(4, "Jack Wolz", 777777777, 'M', 666666666, 'Rua teste 901', 1000.00);
INSERT INTO funcionario(id_departamento, nome, cpf, sexo, cpf_supervisor, endereco, salario) VALUES(4, "Bruno Tattaglia", 888888888, 'F',  666666666, 'Rua teste 190', 1050.00);

-- trabalha_em
INSERT INTO trabalha_em(id_proj, id_func, horas) VALUES(1, 1, 80);
INSERT INTO trabalha_em(id_proj, id_func, horas) VALUES(2, 1, 30);
INSERT INTO trabalha_em(id_proj, id_func, horas) VALUES(1, 2, 50);
INSERT INTO trabalha_em(id_proj, id_func, horas) VALUES(2, 3, 30);
INSERT INTO trabalha_em(id_proj, id_func, horas) VALUES(2, 4, 50);
INSERT INTO trabalha_em(id_proj, id_func, horas) VALUES(3, 5, 25);
INSERT INTO trabalha_em(id_proj, id_func, horas) VALUES(3, 6, 25);
INSERT INTO trabalha_em(id_proj, id_func, horas) VALUES(4, 7, 15);
INSERT INTO trabalha_em(id_proj, id_func, horas) VALUES(4, 8, 15);

-- dependente
INSERT INTO dependente(id_func, nome, parentesco) VALUES(1, "Luquinhas", "Filho");
INSERT INTO dependente(id_func, nome, parentesco) VALUES(2, "Dependente 0", "Cônjuge");
INSERT INTO dependente(id_func, nome, parentesco) VALUES(4, "Dependente 1", "Filho");
INSERT INTO dependente(id_func, nome, parentesco) VALUES(5, "Dependente 2", "Pai");
INSERT INTO dependente(id_func, nome, parentesco) VALUES(6, "Dependente 3", "Mãe");

-- 01) Recupere os números de todos os funcionários que não possuem supervisores.
SELECT * FROM funcionario where cpf_supervisor IS NULL;

-- 02) Recupere os nomes dos funcionários que não possuem nenhum dependente.
SELECT func.nome FROM funcionario AS func
LEFT JOIN dependente AS dep ON func.id = dep.id_func
WHERE dependente.id_func IS NULL;

-- 03) Escreva uma VIEW que contenha o nome do funcionário, nome do projeto e o número de horas que o funcionário trabalha em cada projeto.
CREATE VIEW detalhes_funcionario AS
SELECT func.nome AS nome_do_funcionario, proj.nome AS nome_do_projeto, trab.horas AS numero_de_horas FROM funcionario AS func
INNER JOIN trabalha_em AS trab ON func.id = trab.id_func
INNER JOIN projeto AS proj ON trab.id_proj = proj.id
ORDER BY 1 ASC;

SELECT * FROM detalhes_funcionario;

-- 04) Escreva uma VIEW que contenha o nome, nº de funcionários e total dos salários de cada departamento.

CREATE VIEW detalhes_departamento AS 
SELECT depto.nome AS nome_departamento, COUNT(func.id_departamento) AS quantidade_funcionarios,
SUM(func.salario) AS total_salario FROM funcionario AS func
INNER JOIN departamento AS depto WHERE depto.id = func.id_departamento
GROUP BY depto.nome;

SELECT * FROM detalhes_departamento;

-- 05) Recupere na VIEW criada em (04) o nome de todos os funcionários que trabalham no "PROJETO X".
SELECT * FROM detalhes_funcionario
WHERE nome_do_projeto = 'Bank';

-- 06) Altere o nome do "PROJETO X" para "PROJETO Y" na VIEW criada em (04).
	

-- 07) Exclua a VIEW (04).
DROP VIEW detalhes_funcionario;

-- 08) Crie uma asserção onde o salário do funcionário não pode ser maior que o salário de seu gerente.
DELIMITER $
CREATE TRIGGER valida_salario
BEFORE INSERT ON funcionario
FOR EACH ROW
BEGIN
	IF ((SELECT salario FROM funcionario WHERE cpf = NEW.cpf_supervisor) < NEW.salario ) THEN
		SIGNAL SQLSTATE '45000'
		SET MESSAGE_TEXT = 'TENTANDO INSERIR FUNCIONARIO COM SALARIO MAIOR QUE O GERENTE.';
    END IF;
END$
DELIMITER ;

INSERT INTO funcionario(id_departamento, nome, cpf, sexo, cpf_supervisor, endereco, salario) VALUES(1, "Teste insert", 91919191, 'M', 222222222, 'Rua teste 1', 9000);

-- 09) Para cada departamento, recupere o seu número, o número de funcionários que nele trabalham, a média total de seus salários.
SELECT depto.id AS numero, count(func.id_departamento) AS quantidade_funcionarios, AVG(func.salario) AS media_salarios
FROM departamento AS depto
INNER JOIN funcionario AS func ON func.id_departamento = depto.id
GROUP BY depto.id;

-- 10) Inclua um novo atributo na tabela DPTO chamado SAL_TOTAL. Crie uma TRIGGER para atualizar o valor total dos salários do departamento em que um novo funcionário é incluído.
ALTER TABLE departamento
ADD COLUMN sal_total FLOAT NOT NULL;

DELIMITER $
CREATE TRIGGER atualiza_salario_total AFTER INSERT
ON funcionario
FOR EACH ROW
BEGIN
	UPDATE departamento SET sal_total = sal_total + NEW.salario
    WHERE departamento.id = NEW.id_departamento;
END$
DELIMITER ;

SELECT SUM(func.salario) FROM departamento AS depto
INNER JOIN funcionario AS func ON func.id_departamento = depto.id
WHERE depto.id = 1;

INSERT INTO funcionario(id_departamento, nome, cpf, sexo, cpf_supervisor, endereco, salario)
VALUES (1, "Frank Sinatra", 999999999, 'M', 222222222, "Rua teste 999", 1000.00);

SELECT * FROM departamento;