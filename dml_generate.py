import datetime

def generate_strings():
    with open('output.txt', 'w') as file:
        for i in range(1, 51):
            line = f"UPDATE public.transaction SET id_transaction={i}, value={100*i}, id_account={i}, date='{datetime.datetime.now()}', type_transaction=1 WHERE id_account = {i};"
            file.write(line + '\n')

if __name__ == "__main__":
    generate_strings()
