#Faça um programa que leia três valores e apresente o maior dos três valores lidos seguido da mensagem “eh o maior”

linha = input()
parte = linha.split()
A = int(parte[0])
B = int(parte[1])
C = int(parte[2])
MaiorAB = ((A+B)+abs(A-B))/2
MaiorBC = ((MaiorAB+C)+abs(MaiorAB-C))/2
print('%d eh o maior' % MaiorBC)
