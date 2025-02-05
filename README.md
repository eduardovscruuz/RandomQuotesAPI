# The Office Quotes API
![](https://media3.giphy.com/media/v1.Y2lkPTc5MGI3NjExd2MxeTQwaDFrODFhZjVjNGk5cG1xNGZ4d2dyMncwdmc4ajYxc3YyMSZlcD12MV9pbnRlcm5hbF9naWZfYnlfaWQmY3Q9Zw/6wmz6Qo40eTDf4tW3Z/giphy.gif)
## Descrição
Esta API fornece quotes aleatórias da série The Office em dois idiomas: português (PT-BR) e inglês (EN-US). A API lê os arquivos JSON contendo as quotes e, com base na linguagem e no ID fornecido na URL, retorna a quote correspondente.

## Funcionalidades
- **GET /api/quotes/{language}/{id}**: Retorna uma quote específica com o id fornecido e na língua indicada (pt para português e en para inglês).
  - Exemplo de URL: `/api/quotes/pt/1` retorna a quote com id = 1 no arquivo de quotes em português.

## Como Usar

### 1. Clone o Repositório
Para começar a usar a API, clone o repositório em sua máquina local.

### 2. Instale as Dependências
Navegue até o diretório do projeto e execute o comando para restaurar as dependências:

```bash
dotnet restore
```
### 3. Execute a API
Execute a API com o comando:

```bash
dotnet run
```
### 4. Faça Requisições

A API estará disponível localmente, geralmente em `http://localhost:5000`. Use as URLs para acessar as quotes de acordo com o idioma e o ID. Por exemplo:

- `/api/quotes/pt/1` - Retorna a quote com id = 1 em português.
- `/api/quotes/en/2` - Retorna a quote com id = 2 em inglês.

## Arquivos de Quotes

Os arquivos de quotes estão localizados na pasta **Data** do projeto:

- `quotes-pt.json` – Contém as quotes em português.
- `quotes-en.json` – Contém as quotes em inglês.

Cada quote é representada por um objeto JSON com as seguintes propriedades:

- `id`: Identificador único.
- `character`: O personagem.
- `quote`: O texto.

### Tecnologias Usadas

- **.NET 9** (Minimal APIs)
- **C#**
- **JSON** (para armazenar as quotes)
