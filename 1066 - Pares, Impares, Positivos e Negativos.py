num1 = int(input(''))
num2 = int(input(''))
num3 = int(input(''))
num4 = int(input(''))
num5 = int(input(''))
par = 0
impar = 0
positivo = 0
negativo = 0
if num1%2 == 0:
    par = par + 1
if num1%2 == 1:
    impar = impar + 1
if num1 > 0:
    positivo = positivo + 1
if num1 < 0:
    negativo = negativo + 1
if num2%2 == 0:
    par = par + 1
if num2%2 == 1:
    impar = impar + 1
if num2 > 0:
    positivo = positivo + 1
if num2 < 0:
    negativo = negativo + 1
if num3%2 == 0:
    par = par + 1
if num3%2 == 1:
    impar = impar + 1
if num3 > 0:
    positivo = positivo + 1
if num3 < 0:
    negativo = negativo + 1
if num4%2 == 0:
    par = par + 1
if num4%2 == 1:
    impar = impar + 1
if num4 > 0:
    positivo = positivo + 1
if num4 < 0:
    negativo = negativo + 1
if num5%2 == 0:
    par = par + 1
if num5%2 == 1:
    impar = impar + 1
if num5 > 0:
    positivo = positivo + 1
if num5 < 0:
    negativo = negativo + 1
print(par, 'valor(es) par(es)')
print(impar, 'valor(es) impar(es)')
print(positivo, 'valor(es) positivo(s)')
print(negativo, 'valor(es) negativo(s)')
