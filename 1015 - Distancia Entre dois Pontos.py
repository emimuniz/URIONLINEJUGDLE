#Leia os quatro valores correspondentes aos eixos x e y de dois pontos quaisquer no plano, p1(x1,y1) e p2(x2,y2).
# calcule a distância entre eles, mostrando 4 casas decimais após a vírgula.
#√¯(x2-x1)^2(y2-y1)^2

import math

linha = input()
parte = linha.split()
x1 = float(parte[0])
y1 = float(parte[1])

linha = input()
parte = linha.split()
x2 = float(parte[0])
y2 = float(parte[1])
distancia = math.sqrt((x2-x1)**2+(y2-y1)**2)
print('{:.4f}'.format(distancia))