<h1 align="center">Academia .NET - Mini ERP EF - Windows Forms</h1>

<p align="center">
  <a href="https://learn.microsoft.com/pt-br/dotnet/"><img alt="DotNet 6" src="https://img.shields.io/badge/.NET-5C2D91?logo=.net&logoColor=white&style=for-the-badge" /></a>
  <a href="https://learn.microsoft.com/pt-br/dotnet/csharp/programming-guide/"><img alt="C#" src="https://img.shields.io/badge/C%23-239120?logo=c-sharp&logoColor=white&style=for-the-badge" /></a>
  <a href="https://www.microsoft.com/pt-br/sql-server/sql-server-downloads"><img alt="SQL Server" src="https://img.shields.io/badge/Microsoft%20SQL%20Server-CC2927?style=for-the-badge&logo=microsoft%20sql%20server&logoColor=white" /></a>
</p>

## :computer: Projeto

Repositório com aplicação desktop para simular um `Mini ERP` com objetivo realizar o lançamento de `Notas Fiscais` fictícias, o desafio foi proposto durante a Academia DotNet ministrada pela `Universidade Franciscana - UFN`.

## :camera: Menu de Navegação

<p align="center"> <img src="https://github.com/PauloAlves8039/academia-dotnet-mini-erp-ef/blob/master/src/MiniERP.EF.App/Resources/images/screenshot2.PNG" /></p>

## :movie_camera: Vídeo de Demonstração

[Projeto Mini ERP - YouTube](https://www.youtube.com/watch?v=mnmmCrL1Ot0&t=55s)

## :page_facing_up: Desafio

[Descrição do Desafio](https://github.com/ricardofrohlich/academia_DotNet_5/blob/main/03-exercicios-e-desafios/13_MiniERP%20com%20Entity.txt)

## :blue_book: Regra de Negócio

A aplicação implementa um sistema de gerenciamento que facilita a realização de vendas de produtos provenientes de diversos fornecedores para os clientes de uma empresa, esse processo resulta na emissão de notas fiscais atráves dos seguintes princípios:

- `Cliente` possui uma coleção de `Notas Ficais`.
- `Fornecedor` tem uma coleção de `Produtos`.
- `Produto` dospõe de um relacionamento com o `Fornecedor`.
- `NotaFiscal` possui uma coleção de `ItemNotaFiscal`.
- `ItemNotaFiscal` faz uma mediação com a `NotaFiscal` e `Produto`.

## :hammer: Funcionalidades

- `Cliente`: pesquisa, visualização, cadastro, atualização e exclusão.
- `Fornecedor`: pesquisa, visualização, cadastro, atualização e exclusão.
- `Produto`: pesquisa, visualização, cadastro, atualização e exclusão.
- `NotaFiscal`: pesquisa, visualização, cadastro e geração de PDF.

## Diagrama do Banco de Dados

<p align="center"> <img src="https://github.com/PauloAlves8039/academia-dotnet-mini-erp-ef/blob/master/src/MiniERP.EF.App/Resources/images/Diagrama-MiniERP.PNG" /></p>

## ✔️ Recursos Utilizados

- ``.NET 6.0``
- ``Windows Forms Applications``
- ``C#``
- ``SQL Server``
- ``Entity Framework Core``
- ``Database First Migration``
- ``Identity Client``
- ``iText7``

## :white_check_mark: Decisões Técnicas

1. Na estrutura do projeto adicionei pastas para manter uma organização e divisão das responsabilidades.
2. Optei em implementar o uso do `Identity Client` de forma básica para ter o mínimo de segurança no acesso a aplicação.
3. A exibição dos IDs nos `DataGrids` decidi deixar dessa forma para fins didáticos.
4. O uso dos padrões `Service` e `Repository` além da organização na estrutura do projeto  os objetivos são:
- Aplicar uma comunicação com o banco de dados usando o `Repository Pattern`.
- Definir a separação da regra de negócio das demais partes da aplicação com o `Service Pattern`.
5. A utilização de algumas `ViewModels`: usei essa abordagem para as classes `Produto`, `NotaFiscal` e `ItemNotaFiscal` para obter uma melhor flexibilidade para a montagem das `DataGrids` dessas entidades e na montagem do `PDF` da nota.
6. A não `Atualização` ou `Exclusão` das notas: decidi não aplicar essas funções com base em boas práticas que envolvem os lançamentos e usos dessas notas.
7. O utilização de um formulário de `Informações` a intenção é tentar proporcionar uma experiência mais agradável ao usuário, se por alguma eventualidade surgir dificuldades no uso da aplicação o usuário vai ter essa opção de ajuda para lhe auxiliar.
8. A adição de `Print Screen` da nota: apliquei esse recurso extra para oferecer ao usuário mais uma opção se por acaso o mesmo precise exibir essas informações.
9. Duplo click nas linhas dos `DataGrids`: habilitei esse recurso para oferecer agilidade ao usuário na hora de atualizar, pesquisar e excluir registros para as models `Cliente`, `Fornecedor` e `Produto` em seus respectivos formulários. No caso da `NotaFiscal` essa função oferece uma melhor rapidez para tirar `Print Screen` e gerar `PDF` com a abertura de um formulário de visualização.
10. Navegação entre os formulários: seguindo a mesma ideia para oferecer uma experiência agradável ao usuário adicionei um menu com uma barra de navegação entre os formulários, também adicionei `ícones clicaveis` no formulário de menu para oferecer agilidade de acesso aos módulos da aplicação.
11. As propriedades `DataEmissao` e `ValorTotal` da classe `NotaFiscal` estão gerando seus valores de forma automatizada:
- A `DataEmissao` vai pegar a data e hora do sistema operacional, essa implementação foi feita no método `CriarNovaNotaFiscal` da classe `Form_NotaFiscal`.
- Já para o calculo do `ValorTotal` foi criado o método `CalcularValorTotal` na classe de serviço `NotaFiscalService`, a sua declaração foi feita no método `AdicionarItemNotaFiscal` também da classe `Form_NotaFiscal`.

## :wrench: Utilização do Projeto

- Após baixar ou clonar o projeto navegue até a classe [MiniERP_EFContext](https://github.com/PauloAlves8039/academia-dotnet-mini-erp-ef/blob/master/src/MiniERP.EF.App/Data/MiniERP_EFContext.cs) e atualize a sua `string de conexão` de acordo com as suas credenciais do `SQL Server`.
- Em seguida execute o comando `Update-Database` para a geração da base de dados, se por um acaso enontrar dificuldades nesse ponto pode ser feita a criação do banco de dados diretamente no `SQL Server` executando o script [MiniERP.sql](https://github.com/PauloAlves8039/academia-dotnet-mini-erp-ef/blob/master/src/MiniERP.EF.App/Data/MiniERP.sql) que foi gerado durante o desenvolvimento.
- Com o projeto configurado ao ser executado vai ser solicitada as credencias do usuário, existem duas opção, pode ser cadastrado um `novo usuário` ou pode ser usado um `usuário padrão` que foi criado na geração do banco de dados com as seguintes informações: nome `Administrador` senha `Abc@123456`.
- 
## :eyes: Observações

- O `Identity Client` foi implementado de forma simples apenas como exemplo ilustrativo oferecendo duas opções, uma para a realização do `login` e a outra para `cadastrar usuários`, essas abordagens do uso do `Identity Client` nesse projeto `não são recomendadas para ambientes de produção`.

Não é uma boa prática a criação desse tipo de usuário nesse cenário, é recomendada abordagens diferentes voltadas a uma segurança mas elaborada. A intenção é ter uma condição de acesso funcional para uso da aplicação.

- com o projeto exeutado e o acesso configurado basta acessar o menu principal para navegar entre os formulários e ter acesso a seus recursos.
- Na geração do `PDF` o arquivo é baixado na pasta `Downloads` do sistema operacional com o nome `DetalhesNotaFiscal`.
 
## :floppy_disk: Clonar Repositório

```bash
git clone https://github.com/PauloAlves8039/academia-dotnet-mini-erp-ef.git
```

## :camera: Formulário de Login

<p align="center"> <img src="https://github.com/PauloAlves8039/academia-dotnet-mini-erp-ef/blob/master/src/MiniERP.EF.App/Resources/images/screenshot1.PNG" /></p>

## :camera: Formulário de Clientes

<p align="center"> <img src="https://github.com/PauloAlves8039/academia-dotnet-mini-erp-ef/blob/master/src/MiniERP.EF.App/Resources/images/screenshot3.PNG" /></p>

## :camera: Formulário de Fornecedores

<p align="center"> <img src="https://github.com/PauloAlves8039/academia-dotnet-mini-erp-ef/blob/master/src/MiniERP.EF.App/Resources/images/screenshot4.PNG" /></p>

## :camera: Formulário de Produtos

<p align="center"> <img src="https://github.com/PauloAlves8039/academia-dotnet-mini-erp-ef/blob/master/src/MiniERP.EF.App/Resources/images/screenshot5.PNG" /></p>

## :camera: Formulário de Notas Fiscais

<p align="center"> <img src="https://github.com/PauloAlves8039/academia-dotnet-mini-erp-ef/blob/master/src/MiniERP.EF.App/Resources/images/screenshot6.PNG" /></p>

## :camera: Um Exemplo de Nota Gerada em PDF

<p align="center"> <img src="https://github.com/PauloAlves8039/academia-dotnet-mini-erp-ef/blob/master/src/MiniERP.EF.App/Resources/images/exemplo-nota.PNG" /></p>

## :boy: Author

<a href="https://github.com/PauloAlves8039"><img src="https://avatars.githubusercontent.com/u/57012714?v=4" width=70></a>
[Paulo Alves](https://github.com/PauloAlves8039)

