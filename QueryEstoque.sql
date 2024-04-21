create table TabelaItens(
cod integer primary key, descricao varchar(70), EstoqueAtual integer, EstoqueMinimo integer, EstoqueMaximo integer,
ValorUnitario decimal(8,2));

alter table TabelaItens
	add ValorTotal decimal(8,2);

insert into TabelaItens values(01,'Botina com Cadarço n° 39',2,02,05,56.0,112.00);
 insert into TabelaItens values(02,'Botina com Cadarço n° 40',2,02,NULL,56.0,112.00);
 insert into TabelaItens values(03,'Botina com Cadarço n° 41',7,02,NULL,56.0,392.00);
 insert into TabelaItens values(04,'Botina com Cadarço n° 42',10,NULL,NULL,NULL,NULL);
 insert into TabelaItens values(05,'Botina com Cadarço n° 43',10,NULL,NULL,NULL,NULL);
 insert into TabelaItens values(06,'Botina com Cadarço n° 44',7,02,NULL,56.0,392.00);
 insert into TabelaItens values(07,'Botina com Cadarço n° 45',1,02,NULL,56.0,56.00);
 insert into TabelaItens values(08,'Botina Granville com Elástico n°37',2,NULL,NULL,NULL,NULL);
 insert into TabelaItens values(09,'Botina Granville com Elástico n°38',11,03,20,56.0,616.00);
 insert into TabelaItens values(10,'Botina Granville com Elástico n°39',19,08,50,56.0,1064.00);
 insert into TabelaItens values(11,'Botina Granville com Elástico n°40',70,22,130,56.0,3920.00);
 insert into TabelaItens values(12,'Botina Granville com Elástico n°41',70,42,250,56.0,3920.00);
 insert into TabelaItens values(13,'Botina Granville com Elástico n°42',74,22,130,NULL,NULL);
 insert into TabelaItens values(14,'Botina Granville com Elástico n°43',12,14,80,56.0,672.00);
 insert into TabelaItens values(15,'Botina Granville com Elástico n°44',7,07,40,56.0,392.00);
 insert into TabelaItens values(16,'Botina Granville com Elástico n°45',6,22,130,60.68,364.08);
 insert into TabelaItens values(17,'Calça P',41,06,36,60.00,2460.00);
 insert into TabelaItens values(18,'Calça M',43,12,72,60.00,2580.00);
 insert into TabelaItens values(19,'Calça G',122,30,180,60.00,7320.00);
 insert into TabelaItens values(20,'Calça GG',42,30,180,60.00,2520.00);
 insert into TabelaItens values(21,'Calça XG',104,18,180,60.00,6240.00);
 insert into TabelaItens values(22,'Calça XGG',85,12,72,60.00,5100.00);
 insert into TabelaItens values(23,'Calça SUPER',35,06,36,60.00,2100.00);
 insert into TabelaItens values(24,'Calça ESPECIAL',22,06,36,60.00,1320.00);
 insert into TabelaItens values(25,'Camisa P',38,06,36,29.00,1102.00);
 insert into TabelaItens values(26,'Camisa M',43,12,72,29.00,1247.00);
 insert into TabelaItens values(27,'Camisa G',127,30,180,29.00,3683.00);
 insert into TabelaItens values(28,'Camisa GG',47,30,180,29.00,1363.00);
 insert into TabelaItens values(29,'Camisa XG',134,18,108,29.00,NULL);
 insert into TabelaItens values(30,'Camisa XGG',84,12,72,29.00,2436.00);
 insert into TabelaItens values(31,'Camisa SUPER',35,06,36,29.00,1015.00);
 insert into TabelaItens values(32,'Camisa ESPECIAL',17,06,36,29.00,493.00);
 insert into TabelaItens values(33,'Capacete Branco',8,10,30,57.00,456.00);
 insert into TabelaItens values(34,'Capacete Laranja MSA',39,40,240,57.00,2223.00);
 insert into TabelaItens values(35,'Capacete Laranja STEELFLEX',150,40,240,29,97);
 insert into TabelaItens values(36,'Capa de Chuva M',24,04,20,17.90,429.60);
 insert into TabelaItens values(37,'Capa de Chuva G',55,16,100,17.90,984.50);
 insert into TabelaItens values(38,'Capa de Chuva GG',106,32,200,17.90,1897.40);
 insert into TabelaItens values(39,'Capa de Chuva XG',313,32,200,NULL,NULL);
 insert into TabelaItens values(40,'Capa de Chuva EXG',180,32,200,17.90,3222.00);
 insert into TabelaItens values(41,'Colete Laranja Conferente M',1,30,NULL,26.60,26.60);
 insert into TabelaItens values(42,'Colete Laranja Conferente G',13,NULL,NULL,26.60,345.80);
 insert into TabelaItens values(43,'Colete Laranja Conferente XG',7,NULL,NULL,26.60,186.20);
 insert into TabelaItens values(44,'Colete Laranja Conferente XGG',9,NULL,NULL,26.60,239.40);
 insert into TabelaItens values(45,'Colete Sinaleiro M',50,30,NULL,26.60,1330.00);
 insert into TabelaItens values(46,'Colete Sinaleiro G',91,30,NULL,26.60,2420.60);
 insert into TabelaItens values(47,'Colete Sinaleiro XG',117,30,NULL,26.60,3112.20);
 insert into TabelaItens values(48,'Luva de Malha Pigmentada',(2),30,NULL,17.25,34.50);
 insert into TabelaItens values(49,'Luva',NULL,30,NULL,17.25,NULL);
 insert into TabelaItens values(50,'Luva',93,30,NULL,17.25,1604.25);
 insert into TabelaItens values(51,'Luva Verde Green',84,30,NULL,17.25,1449.00);
 insert into TabelaItens values(52,'Luva (preta)',5,30,NULL,17.25,86.25);
 insert into TabelaItens values(53,'Luva Thecom Tam. 13 (Vaqueta)',240,30,NULL,17.25,4140.00);
 insert into TabelaItens values(54,'Luva Verde Dany',4,30,NULL,17.25,69.00);
 insert into TabelaItens values(55,'Luva Verde Tam. 9',36,30,NULL,17.25,621.00);
 insert into TabelaItens values(56,'Macacão Tyvek',4,30,NULL,0,NULL);
 insert into TabelaItens values(57,'Máscara Cirúrgica',4.000,30,NULL,0,NULL);
 insert into TabelaItens values(58,'Óculos Ampla Visão Valvulado',218,30,NULL,13.60,2964.80);
 insert into TabelaItens values(59,'Óculos Incolor RJ',239,30,NULL,13,60);
 insert into TabelaItens values(60,'Protetor Auricular tipo Plug silicone',149,30,NULL,0,NULL);
 insert into TabelaItens values(61,'Protetor Facial Acoplavel',8,30,NULL,0,NULL);
 insert into TabelaItens values(62,'Respirador PFF2',2.300,30,NULL,0,NULL);
 insert into TabelaItens values(63,'Rolo de Fita Zebrada',17,10,30,0,NULL);
 insert into TabelaItens values(64,'Suspensão STEELFLEX',225,10,30,27.10,6097.50);
 insert into TabelaItens values(65,'Suspensão MSA',229,80,480,28.35,6492.15);
 insert into TabelaItens values(66,'Talabarte',61,30,NULL,0,NULL);

Select * from TabelaItens;

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

update TabelaItens set ValorTotal = (ValorUnitario * EstoqueAtual);

