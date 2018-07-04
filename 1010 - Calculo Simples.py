#Neste problema, deve-se ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, 
#o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. 
#Após, calcule e mostre o valor a ser pago.


linha = input()
parte = linha.split()
codigo1 = int(parte[0])
quantidade1 = int(parte[1])
valor1 = float(parte[2])

linha = input()
parte = linha.split()
codigo2 = int(parte[0])
quantidade2 = int(parte[1])
valor2 = float(parte[2])
valornovo = quantidade1*valor1+quantidade2*valor2
print('VALOR A PAGAR: R$ {:.2f}'.format(valornovo))
