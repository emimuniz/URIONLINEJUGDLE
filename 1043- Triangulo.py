linha = input().split()
A = float(linha[0])
B = float(linha[1])
C = float(linha[2])
if (A < B+C) and (B < A+C) and (C < A+B):
    print('Perimetro = {:.1f}'.format(A+B+C))
else:
    print('Area = {:.1f}'.format((A+B)*C/2))
