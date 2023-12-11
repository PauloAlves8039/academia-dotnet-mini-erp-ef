IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Cliente] (
    [CodigoCliente] int NOT NULL IDENTITY,
    [Nome] varchar(150) NOT NULL,
    [CPF] varchar(15) NOT NULL,
    [Telefone] varchar(15) NOT NULL,
    [Email] varchar(150) NOT NULL,
    [Endereco] varchar(255) NOT NULL,
    CONSTRAINT [PK__Cliente__E0DD7E715BB88913] PRIMARY KEY ([CodigoCliente])
);
GO

CREATE TABLE [Fornecedor] (
    [CodigoFornecedor] int NOT NULL IDENTITY,
    [RazaoSocial] varchar(150) NOT NULL,
    [CNPJ] varchar(20) NOT NULL,
    [Telefone] varchar(20) NOT NULL,
    [Email] varchar(150) NOT NULL,
    [Endereco] varchar(255) NOT NULL,
    CONSTRAINT [PK__Forneced__1FA78911D17DA8B9] PRIMARY KEY ([CodigoFornecedor])
);
GO

CREATE TABLE [Usuarios] (
    [Id] int NOT NULL IDENTITY,
    [Nome] nvarchar(64) NOT NULL,
    [Senha] nvarchar(64) NOT NULL,
    CONSTRAINT [PK_Usuarios] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [NotaFiscal] (
    [CodigoNotaFiscal] int NOT NULL IDENTITY,
    [DataEmissao] datetime NOT NULL,
    [ValorTotal] decimal(18,2) NOT NULL,
    [ClienteId] int NULL,
    CONSTRAINT [PK__NotaFisc__BD26A989DBCE9C43] PRIMARY KEY ([CodigoNotaFiscal]),
    CONSTRAINT [FK__NotaFisca__Clien__3D5E1FD2] FOREIGN KEY ([ClienteId]) REFERENCES [Cliente] ([CodigoCliente])
);
GO

CREATE TABLE [Produto] (
    [CodigoProduto] int NOT NULL IDENTITY,
    [Nome] varchar(150) NOT NULL,
    [Preco] decimal(18,2) NOT NULL,
    [Estoque] int NOT NULL,
    [Descricao] nvarchar(250) NULL,
    [FornecedorId] int NULL,
    CONSTRAINT [PK__Produto__F94CC5B9A4DF4896] PRIMARY KEY ([CodigoProduto]),
    CONSTRAINT [FK__Produto__Fornece__3A81B327] FOREIGN KEY ([FornecedorId]) REFERENCES [Fornecedor] ([CodigoFornecedor])
);
GO

CREATE TABLE [ItemNotaFiscal] (
    [CodigoItemNotaFiscal] int NOT NULL IDENTITY,
    [NotaFiscalId] int NULL,
    [ProdutoId] int NULL,
    [Quantidade] int NOT NULL,
    [ValorUnitario] decimal(18,2) NOT NULL,
    CONSTRAINT [PK__ItemNota__500D34F45549B9B2] PRIMARY KEY ([CodigoItemNotaFiscal]),
    CONSTRAINT [FK__ItemNotaF__NotaF__403A8C7D] FOREIGN KEY ([NotaFiscalId]) REFERENCES [NotaFiscal] ([CodigoNotaFiscal]),
    CONSTRAINT [FK__ItemNotaF__Produ__412EB0B6] FOREIGN KEY ([ProdutoId]) REFERENCES [Produto] ([CodigoProduto])
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Nome', N'Senha') AND [object_id] = OBJECT_ID(N'[Usuarios]'))
    SET IDENTITY_INSERT [Usuarios] ON;
INSERT INTO [Usuarios] ([Id], [Nome], [Senha])
VALUES (1, N'Administrador', N'Abc@123456');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Nome', N'Senha') AND [object_id] = OBJECT_ID(N'[Usuarios]'))
    SET IDENTITY_INSERT [Usuarios] OFF;
GO

CREATE INDEX [IX_ItemNotaFiscal_NotaFiscalId] ON [ItemNotaFiscal] ([NotaFiscalId]);
GO

CREATE INDEX [IX_ItemNotaFiscal_ProdutoId] ON [ItemNotaFiscal] ([ProdutoId]);
GO

CREATE INDEX [IX_NotaFiscal_ClienteId] ON [NotaFiscal] ([ClienteId]);
GO

CREATE INDEX [IX_Produto_FornecedorId] ON [Produto] ([FornecedorId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231211190519_Initial', N'6.0.25');
GO

COMMIT;
GO

