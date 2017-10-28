salario = float(input(''))
if salario <= 2000.00:
    print('Isento')
elif 2000.01 < salario <= 3000:
    t = (salario - 2000)
    tx = (t * 8) / 100
    print("R$ %.2f" % tx)
elif 3000.01 < salario <= 4500:
    t = (salario - 2000)
    t1 = t - 1000
    tx1 = (1000 * 8) / 100
    tx2 = (t1 * 18) / 100
    print("R$ %.2f" % (tx1 + tx2))
else:
    t = (salario - 2000)
    t1 = t - 1000
    tx1 = (1000 * 8) / 100
    t2 = t1 - 1500
    tx2 = (1500 * 18) / 100
    tx = (t2 * 28) / 100
    print("R$ %.2f" % (tx + tx1 + tx2))