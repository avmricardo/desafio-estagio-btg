# Entidades

## Cliente

| Cliente
|--
| <u>id_cliente</u>
|cpf
|nome
|telefone
|endereco

Primary key: id_cliente

## Conta

| Conta           |
| --              |
| <u>id_conta</u> |
| id_cliente      |
| numero          |
| saldo           |
| tipo_conta      |

Primary key: id_conta

Foreign key: id_cliente

tipo_conta: conta corrente, depósito, etc..

## Movimentacoes

| Movimentacoes
| --
| id_movimentacao
| id_conta
| valor
| data
| tipo_movimentacao

Primary key: id_movimentacao

Foreign key: id_conta

tipo_movimentacao: saque ou depósito

# Relacionamentos

- Cliente N --- M Conta

Um cliente pode ter mais de uma conta e uma conta pode estar associada a mais de um cliente (casos com contas com representantes, os representantes entrariam como clientes também).

- Conta 1 --- N Movimentacoes

Uma conta pode realizar mais de uma movimentação, mas uma movimentação está associada a apenas uma conta (pois no caso estamos tratando apenas de saques e depósitos).
