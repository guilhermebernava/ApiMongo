<div align="center">

# 💫 ApiMongoDb 💫

</div>

<div align="center">

Esta é uma API de exemplo construída com .NET 6 que oferece operações CRUD (Create, Read, Update, Delete) para gerenciar produtos usando o MongoDB como banco de dados. Demonstramos o uso do AutoMapper para mapeamento de objetos, o Padrão de Repositório para acesso a dados e Serviços para encapsular a lógica de negócios.

</div>

## Funcionalidades

- **Create**: Adicione um novo produto ao banco de dados.
- **Read**: Recupere uma lista de todos os produtos ou um produto específico pelo seu ID.
- **Update**: Atualize as informações de um produto existente.
- **Delete**: Remova um produto do banco de dados.

## Tecnologias Utilizadas

- .NET 6
- MongoDB: Um banco de dados NoSQL para armazenar dados de produtos.
- AutoMapper: Usado para mapear entre DTOs (Objetos de Transferência de Dados) e modelos de domínio.
- Padrão de Repositório: Separação da lógica de acesso a dados da lógica de negócios.
- Injeção de Dependência: Utilizada para gerenciar os serviços da aplicação.
- Serilog: Usado para exibir logs na console da aplicação.

## Pré-requisitos

- .NET 6 SDK: Certifique-se de ter o .NET 6 instalado em sua máquina. Você pode baixá-lo [aqui](https://dotnet.microsoft.com/download/dotnet/6.0).
- MongoDB: Você precisa de uma instância do MongoDB em execução. Você pode usar um servidor MongoDB instalado localmente ou executá-lo em um contêiner Docker.

## Começando

1. **Clone o Repositório**:

   ```bash
   git clone https://github.com/guilhermebernava/ApiMongo.git
   ```

2. **Atualize as Configurações do AppSettings**:

   Abra o arquivo `appsettings.json` e configure a string de conexão do MongoDB e o nome do banco de dados.

   ```json
   "ConnectionStrings": {
       "MongoDB": "mongodb://localhost:27017"
   },
   "DatabaseSettings": {
       "DatabaseName": "SeuNomeDeBancoDeDados",
       "CollectionName": "Produtos"
   }
   ```

3. **Execute a API**:

   ```bash
   dotnet run
   ```

   A API estará acessível em `http://localhost:5000` por padrão. Você pode usar ferramentas como o Postman ou o cURL para interagir com os endpoints da API.

## Endpoints da API

- **GET /api/products**: Obtenha uma lista de todos os produtos.
- **GET /api/products/{id}**: Obtenha um produto pelo seu ID.
- **POST /api/products**: Crie um novo produto.
- **PUT /api/products/{id}**: Atualize um produto existente.
- **DELETE /api/products/{id}**: Exclua um produto pelo seu ID.

## Exemplos de Uso

Aqui estão alguns exemplos de como usar os endpoints da API:

### Criar um Produto

```http
POST /api/products
Content-Type: application/json

{
    "name": "Nome do Produto",
    "price": 19.99
}
```

### Obter uma Lista de Todos os Produtos

```http
GET /api/products
```

### Obter um Produto pelo ID

```http
GET /api/products/{id}
```

### Atualizar um Produto

```http
PUT /api/products/{id}
Content-Type: application/json

{
    "name": "Nome do Produto Atualizado",
    "price": 29.99
}
```

### Excluir um Produto pelo ID

```http
DELETE /api/products/{id}
```

</div>
