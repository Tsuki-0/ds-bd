CREATE TABLE DS_PESSOA
(
ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
NOME NVARCHAR(40),
ENDERECO NVARCHAR(40),
CIDADE VARCHAR(40),
EMAIL NVARCHAR(40),
DATA_NASCIMENTO DATE
)

INSERT INTO [dbo].[DS_PESSOA] (NOME, ENDERECO, CIDADE, EMAIL, DATA_NASCIMENTO) VALUES
(N'Carlos Silva', N'Rua das Flores, 123', 'São Paulo', N'carlos.silva@example.com', '1987-05-12'),
(N'Ana Beatriz Souza', N'Avenida Central, 456', 'Rio de Janeiro', N'ana.souza@example.com', '1992-11-03'),
(N'João Pereira', N'Praça Sete, 78', 'Belo Horizonte', N'joao.pereira@example.com', '1979-02-20'),
(N'Mariana Oliveira', N'Rua do Carmo, 90', 'Salvador', N'mariana.oliveira@example.com', '1995-07-15'),
(N'Rafael Costa', N'Alameda Santos, 101', 'Campinas', N'rafael.costa@example.com', '1983-09-30'),
(N'Fernanda Lima', N'Rua Boa Vista, 22', 'Fortaleza', N'fernanda.lima@example.com', '1990-03-08'),
(N'Lucas Almeida', N'Avenida Brasil, 555', 'Porto Alegre', N'lucas.almeida@example.com', '1988-12-01'),
(N'Patrícia Fernandes', N'Rua 13 de Maio, 300', 'Curitiba', N'patricia.fernandes@example.com', '1975-06-27'),
(N'Bruno Rodrigues', N'Praça da Paz, 15', 'Recife', N'bruno.rodrigues@example.com', '1998-01-19'),
(N'Isabela Martins', N'Rua do Comércio, 7', 'Manaus', N'isabela.martins@example.com', '2000-10-05');

select * from DS_PESSOA