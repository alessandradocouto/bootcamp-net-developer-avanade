/* Questao 1 */ 

SELECT Nome, Ano
FROM dbo.Filmes;

/* Questao 2 */ 

SELECT Nome, Ano
FROM dbo.Filmes 
ORDER BY ANO ASC;

/* Questao 3 */ 

SELECT Nome, Ano, Duracao
FROM dbo.Filmes 
WHERE Nome = 'De Volta para o Futuro';

/* Questao 4 */ 

SELECT Nome, Ano, Duracao
FROM dbo.Filmes 
WHERE Ano LIKE '%1997%';

/* Questao 5 */ 

SELECT Nome, Ano, Duracao
FROM dbo.Filmes 
WHERE Ano > '2000';

/* Questao 6 */ 

SELECT Nome, Ano, Duracao
FROM dbo.Filmes 
WHERE Duracao > '100' AND Duracao < '150'
ORDER BY Duracao ASC;

/* Questao 7 */ 

SELECT Ano, Count(*) AS Quantidade
FROM dbo.Filmes 
GROUP BY Ano
ORDER BY Quantidade DESC;

/* Questao 8 */ 

SELECT PrimeiroNome, UltimoNome, Genero
FROM dbo.Atores
WHERE Genero = 'M';

/* Questao 9 */ 

SELECT PrimeiroNome, UltimoNome, Genero
FROM dbo.Atores
WHERE Genero = 'F'
ORDER BY PrimeiroNome ASC;

/* Questao 10 */ 

SELECT f.Nome, g.Genero
FROM dbo.Filmes f
INNER JOIN dbo.FilmesGenero fg ON fg.IdFilme = f.Id -- filme 
INNER JOIN dbo.Generos g ON g.Id = fg.IdGenero;

/* Questao 11 */ 

SELECT f.Nome, g.Genero
FROM dbo.Filmes f
INNER JOIN dbo.FilmesGenero fg ON fg.IdFilme = f.Id -- filme 
INNER JOIN dbo.Generos g ON g.Id = fg.IdGenero -- genero
WHERE g.Genero = 'Mistério';

/* Questao 12 */ 

SELECT f.Nome, a.PrimeiroNome, a.UltimoNome, ef.Papel
FROM dbo.Filmes f
INNER JOIN dbo.ElencoFilme ef ON ef.IdFilme = f.Id -- filme 
INNER JOIN dbo.Atores a ON a.Id = ef.IdAtor;