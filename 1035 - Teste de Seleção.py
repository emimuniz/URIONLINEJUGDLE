linha = input()
parte = linha.split()
A = int(parte[0])
B = int(parte[1])
C = int(parte[2])
D = int(parte[3])
if (B > C) and (D > A) and (C+D > A+B) and (C and D > 0)and (A % 2 == 0):
    print('Valores aceitos')
else:
    print('Valores nao aceitos')
