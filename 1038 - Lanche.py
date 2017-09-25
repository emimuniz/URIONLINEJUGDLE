linha = input()
parte = linha.split()
codigo = int(parte[0])
quantidade = int(parte[1])
if codigo == 1:
    print('Total: R$ {:.2f}'.format(quantidade*4))
elif codigo == 2:
    print('Total: R$ {:.2f}'.format(quantidade*4.50))
elif codigo == 3:
    print('Total: R$ {:.2f}'.format(quantidade*5))
elif codigo == 4:
    print('Total: R$ {:.2f}'.format(quantidade*2))
elif codigo == 5:
    print('Total: R$ {:.2f}'.format(quantidade*1.50))

