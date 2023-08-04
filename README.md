# Desafio BTG

Projeto destinado ao desenvolvimento de um sistema de contas digitais. Tal desafio foi elaborado pelo processo seletivo do BTG Pactual.

## Tabela de Conteúdos

- Introdução
- Tecnologias Utilizadas
- Modelo Entidade-Relacionamento
- Diagrama Entidade-Relacionamento
- Endpoints da API

## Introdução

Para o desenvolvimento do sistema, foi realizada a modelagem de um banco de dados relacional contendo dados do cliente, dados da conta e dados de movimentação, trabalhando apenas com saques e depósitos.

Após a modelagem, foi feita uma API do sistema com funções de cadastro de cliente/conta, visualização de saldo, deletar dados de cliente, conta e transações; pesquisa de dados do cliente a partir do CPF, atualizar dados do cliente, visualizar lista de clientes; realizção de saque (caso o cliente tenha saldo suficiente), depósito e visualização de lista de transações da conta.

## Tecnologias Utilizadas

Para o desenvolvimento do sistema, foi escolhido um conjunto de tecnologias modernas e também utilizadas dentro do BTG Pactual. Como banco de dados, foi utilizado o PostgreSQL. A hospedagem do banco foi realizada na AWS RDS (Amazon Web Services Relational Database Services), aproveitando a escalabilidade e confiabilidade da nuvem para gerantir um sistema seguro. Quanto ao desenvolvimento da aplicação, foi utilizada a plataforma .NET, aproveitando seu framework para criar uma API completa, fornecendo uma ótima experiência aos usuários.

## Modelo Entidade-Relacionamento

Entidades:

- Client
- Account
- Transaction

Atributos:

- Client: id_client, cpf, name, telephone, address
- Account: id_account, id_client, number, balance
- Transaction: id_transaction, id_account, value, data, type_transaction

Relacionamentos:

## Diagrama Entidade-Relacionamento

Os Scripts DDL e DML estão presentes nas pastas [DDL](/DDL) e [DML](/DML).

## Endpoints da API

![Alt text](image.png)
![Alt text](image-1.png)
![Alt text](image-2.png)