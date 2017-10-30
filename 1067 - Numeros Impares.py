x = int(input(''))
contador = 1
while contador <= x <= 1000:
    print(contador)
    contador = contador + 1
    if contador%2 == 1:
        print(contador)
    else:
        contador = contador + 1