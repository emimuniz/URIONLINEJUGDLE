#Faça um programa que calcule e mostre o volume de uma esfera sendo fornecido o valor de seu raio (R). #
# A fórmula para calcular o volume é: (4/3) * pi * R3. Considere (atribua) para pi o valor 3.14159.

raio = int(input(''))
VOLUME = (4/3.0)*3.14159*raio**3
print('VOLUME = {:.3f}'.format(VOLUME))