num1 = float(input(''))
num2 = float(input(''))
num3 = float(input(''))
num4 = float(input(''))
num5 = float(input(''))
num6 = float(input(''))
contador = 0
soma = 0
if num1 > 0:
    contador = contador + 1
    soma = soma + num1
if num2 > 0:
    contador = contador + 1
    soma = soma + num2
if num3 > 0:
    contador = contador + 1
    soma = soma + num3
if num4 > 0:
    contador = contador + 1
    soma = soma + num4
if num5 > 0:
    contador = contador + 1
    soma = soma + num5
if num6 > 0:
    contador = contador + 1
    soma = soma + num6
print(contador, 'valores positivos')
print('{:.1f}'.format(soma/contador))