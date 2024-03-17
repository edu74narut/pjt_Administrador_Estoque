SELECT cod, descricao as Descri��o,
    EstoqueAtual as [Estoque atual],
    EstoqueMaximo as [Estoque m�ximo],
    EstoqueMinimo as [Estoque m�nimo],
    ValorUnitario as [Valor unit�rio], ValorTotal as [Valor total],
    CASE
        WHEN EstoqueAtual > EstoqueMaximo THEN 'ACIMA'
        WHEN EstoqueAtual >= EstoqueMinimo AND EstoqueAtual <= EstoqueMaximo THEN 'IDEAL'
        WHEN EstoqueAtual < EstoqueMinimo THEN 'COMPRAR'
    END AS [Status capacidade] 
FROM dbo.TabelaItens

update TabelaItens set ValorTotal = NULL;
update TabelaItens set ValorTotal = (ValorUnitario * EstoqueAtual);

