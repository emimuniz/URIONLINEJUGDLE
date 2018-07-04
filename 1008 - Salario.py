#Escreva um programa que leia o número de um funcionário, seu número de horas trabalhadas, 
#o valor que recebe por hora e calcula o salário desse funcionário. 
#A seguir, mostre o número e o salário do funcionário, com duas casas decimais.

numf = int(input(''))
horas = int(input(''))
salario = float(input(''))
salarioh = horas*salario
print('NUMBER = {}'.format(numf))
print('SALARY = U$ {:.2f}'.format(salarioh))
