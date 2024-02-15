CREATE TABLE Pagamentos (
    ID UNIQUEIDENTIFIER PRIMARY KEY,
    FormaPagamento NVARCHAR(50) NOT NULL,
    Valor DECIMAL(10, 2) NOT NULL
);
GO

INSERT INTO Pagamentos (ID, FormaPagamento, Valor) VALUES (NEWID(), 'Pix', 1650.00);

-- Inserindo valores para Cartão de Crédito
INSERT INTO Pagamentos (ID, FormaPagamento, Valor) VALUES (NEWID(), 'Cartão de Crédito', 2000.00);

-- Inserindo valores para Cartão de Débito
INSERT INTO Pagamentos (ID, FormaPagamento, Valor) VALUES (NEWID(), 'Cartão de Débito', 1200.00);

-- Inserindo valores para VR
INSERT INTO Pagamentos (ID, FormaPagamento, Valor) VALUES (NEWID(), 'VR', 1800.00);

INSERT INTO Pagamentos (ID, FormaPagamento, Valor) VALUES (NEWID(), 'Dinheiro', 1500.00);

SELECT * FROM Pagamentos;