CREATE DATABASE steam;
USE steam;

CREATE TABLE jogos(
	id_jogo INT PRIMARY KEY AUTO_INCREMENT,
	nome VARCHAR(100),
    preco FLOAT
);

CREATE TABLE usuarios(
	id_usuario INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100),
	email VARCHAR(100),
    senha VARCHAR(100)
);
CREATE TABLE compras(
	id_usuario INT,
	id_jogo INT
);

INSERT INTO jogos(id_jogo,nome,preco)
VALUES
(1,"The Witcher 3: Wild Hunt",99.99),
(2,"Cyberpunk 2077",149.90),
(3,"Red Dead Redemption 2",199.99),
(4,"Elden Ring",249.99),
(5,"Stardew Valley",29.99);

INSERT INTO usuarios(id_usuario,nome,email,senha)
VALUES
(1,"Ana Silva","ana.silva@email.com","senha_hash_ana"),
(2,"Bruno Costa","bruno.costa@email.com","senha_hash_bruno"),
(3,"Carla Dias","carla.dias@email.com","senha_hash_carla");

INSERT INTO compras(id_usuario,id_jogo)
VALUES
(1,1),
(1,5),
(2,2),
(3,3),
(3,4),
(3,1);

ALTER TABLE compras
ADD CONSTRAINT fk_compras
FOREIGN KEY (id_usuario)
REFERENCES usuarios (id_usuario);

ALTER TABLE compras
ADD CONSTRAINT fk_compras2
FOREIGN KEY (id_jogo)
REFERENCES jogos (id_jogo);

SELECT * FROM jogos;
SELECT * FROM usuarios;
SELECT * FROM compras;

SELECT
    u.nome AS Nome_Usuario,
    j.nome AS Nome_Jogo,
    j.preco AS Preco_Jogo
FROM
    compras c
JOIN
    usuarios u ON c.id_usuario = u.id_usuario
JOIN
    jogos j ON c.id_jogo = j.id_jogo;


