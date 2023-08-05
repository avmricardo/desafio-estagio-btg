# Entidades

## Cliente

| Client
|--
| <u>id_client</u>
|cpf
|name
|telephone
|address

Primary key: id_client

## Conta


| Account
| --
| <u>id_account</u>
| id_client
| number
| balance

Primary key: id_account

Foreign key: id_client

## Movimentações

| Transaction
| --
| id_transaction
| id_account
| value
| data
| type_transaction

Primary key: id_transaction

Foreign key: id_account

tipo_movimentacao: saque ou depósito

# Relacionamentos

- Client 1 --- 1 Account

Essa modelagem está trabalhando com contas de apenas um tipo, com isso um cliente estará associado a apenas uma conta e uma conta será vinculada a apenas um cliente.

- Account 1 --- N Transaction

Uma conta pode realizar mais de uma movimentação, mas uma movimentação está associada a apenas uma conta (pois no caso trabalhado as transações são apenas de saques e depósitos).
