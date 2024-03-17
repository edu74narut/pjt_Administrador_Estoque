SELECT cod, descricao as Descrição,
    EstoqueAtual as [Estoque atual],
    EstoqueMaximo as [Estoque máximo],
    EstoqueMinimo as [Estoque mínimo],
    ValorUnitario as [Valor unitário], ValorTotal as [Valor total],
    CASE
        WHEN EstoqueAtual > EstoqueMaximo THEN 'ACIMA'
        WHEN EstoqueAtual >= EstoqueMinimo AND EstoqueAtual <= EstoqueMaximo THEN 'IDEAL'
        WHEN EstoqueAtual < EstoqueMinimo THEN 'COMPRAR'
    END AS [Status capacidade] 
FROM dbo.TabelaItens

update TabelaItens set ValorTotal = NULL;
update TabelaItens set ValorTotal = (ValorUnitario * EstoqueAtual);

