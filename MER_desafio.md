# Entidades

## Cliente

| Cliente
|--
| <u>Id_cliente</u>
|CPF
|Nome
|Telefone
|Endereço

Primary key: Id_cliente

## Conta

| Conta           |
| --              |
| <u>Id_conta</u> |
| Id_cliente      |
| Número          |
| Saldo           |
| Tipo_conta      |

Primary key: Id_conta
Foreign key: Id_cliente

## Movimentações

| Movimentações
| --
| Id_movimentação
| Id_conta
| Valor
| Data
| Tipo_movimentação

Primary key: Id_movimentação
Foreign key: Id_conta

# Relacionamentos

- Cliente N --- M Conta

Um cliente pode ter mais de uma conta e uma conta pode estar associada a mais de um cliente (casos com contas com representantes, os representantes entrariam como clientes também)

- Conta 1 --- N Movimentações


