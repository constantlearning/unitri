-- RELATÓRIOS
-- Pedido entre duas datas.
SELECT * FROM pedido
WHERE data_pedido BETWEEN '6/10/2018' AND '6/20/2018';

-- Pedidos por filial.
SELECT * FROM pedido
WHERE pedido.id_atendente = '1023';

-- Pedidos por Atendente
SELECT * FROM pedido
WHERE pedido.id_filial = '12';

-- GRAFICOS

-- Contar pedidos por atendente
SELECT atendente.nome, COUNT(id_atendente) AS quantidade FROM pedido
INNER JOIN atendente ON atendente.Id = pedido.id_atendente
GROUP BY id_atendente, atendente.nome;

-- Faturamento por filial (Total) (TÁ ERRADO)
SELECT filial.nome, SUM(produto.valor + servico.valor) AS faturamento_total FROM pedido
INNER JOIN pedido_itemproduto ON pedido.Id = pedido_itemproduto.id_pedido
INNER JOIN pedido_itemservico ON pedido.Id = pedido_itemservico.id_pedido
INNER JOIN produto ON produto.Id = pedido_itemproduto.id_produto
INNER JOIN servico ON servico.Id = pedido_itemservico.id_servico
INNER JOIN filial ON filial.Id = pedido.id_filial
GROUP BY filial.nome;

-- Quantidade de pedidos por barbearia
SELECT barbearia.name, COUNT(id_barbearia) AS quantidade FROM pedido
INNER JOIN barbearia ON barbearia.Id = pedido.id_barbearia
GROUP BY id_barbearia, barbearia.name;
