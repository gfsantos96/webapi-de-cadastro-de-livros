# Projeto de api de uma livraria fictícia em dotnet

## Como funciona?

Essa api foi criada como critério de resolução do projeto da DIO, com a finalidade de simular uma api que cadastra e busca livros dentro de uma livraria fictícia.

Criada em dotnet com a linguagem C#, utiliza o banco de dados não relacional mongo.db para criar um ambiente de cadastro e busca de livros.

Para acessar a api, insira o seguinte endereço no navegador:
http://localhost:5000/Livro

O resultado será um json:

{
"Autor": "Luís da Silva",
"Titulo": "Um livro fictício",
"Sinopse": "Este livro foi criado com a finalidade de testar o projeto",
"Genero": "nenhum"
}

Obs.: Você deve configurar a string do mongo.db no arquivo appsettings

## Contato
Gustavo Fernandes
Github: [github.com/gfsantos96](https://github.com/gfsantos96)