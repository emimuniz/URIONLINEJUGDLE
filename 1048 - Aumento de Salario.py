salario = float(input(''))
salario15 = salario*15/100
salario12 = salario*12/100
salario10 = salario*10/100
salario7 = salario*7/100
salario4 = salario*4/100
if  salario <= 400:
    print('Novo salario: {:.2f}'.format(salario + salario15))
    print('Reajuste ganho: {:.2f}'.format(salario15))
    print('Em percentual: 15 %')
elif salario >= 400 and salario <= 800:
    print('Novo salario: {:.2f}'.format(salario + salario12))
    print('Reajuste ganho: {:.2f}'.format(salario12))
    print('Em percentual: 12 %')
elif salario >= 800 and salario <= 1200:
    print('Novo salario: {:.2f}'.format(salario + salario10))
    print('Reajuste ganho: {:.2f}'.format(salario10))
    print('Em percentual: 10 %')
elif salario >= 1200 and salario <= 2000:
    print('Novo salario: {:.2f}'.format(salario + salario7))
    print('Reajuste ganho: {:.2f}'.format(salario7))
    print('Em percentual: 7 %')
elif salario >= 2000.01:
    print('Novo salario: {:.2f}'.format(salario + salario4))
    print('Reajuste ganho: {:.2f}'.format(salario4))
    print('Em percentual: 4 %')