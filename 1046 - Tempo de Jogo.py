linha = input().split()
A = int(linha[0])
B = int(linha[1])
if A == B:
    print('O JOGO DUROU 24 HORA(S)')
if A > B:
    print('O JOGO DUROU {} HORA(S)'.format(24-A+B))
if A < B:
    print('O JOGO DUROU {} HORAS(S)'.format(B - A))
