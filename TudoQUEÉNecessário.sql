use BancoEstoque;
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
FROM dbo.TabelaItens;

update TabelaItens set ValorTotal = NULL;
update TabelaItens set ValorTotal = (ValorUnitario * EstoqueAtual);

alter table TabelaItens
	add ValorTotal decimal(8,2);

update TabelaItens set EstoqueAtual = 2, EstoqueMaximo = 5, EstoqueMinimo = 2 where cod = 1;
select TabelaItens.descricao from TabelaItens where cod = 1;

select * from TabelaItens;

insert into TabelaItens values(01,'Botina com Cadarço n° 39',2,02,05,56.0,112.00);

delete from TabelaItens where cod = 67;


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
FROM dbo.TabelaItens where descricao = '';