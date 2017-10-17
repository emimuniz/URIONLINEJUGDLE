h1, m1, h2, m2 = input().split()

h1 = int(h1)
m1 = int(m1)
h2 = int(h2)
m2 = int(m2)

inicio = h1 * 60 + m1
fim = h2 * 60 + m2

if (fim > inicio):
    minutos = fim - inicio
else:
    minutos = (24 * 60) - inicio + fim

# minutos = (60 - m1) + (h2 - h1 - 1) * 60 + m2
horas = minutos // 60
minutos = minutos % 60

if (horas == 0 and minutos == 0):
    print("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)")
else:
    print("O JOGO DUROU %d HORA(S) E %d MINUTO(S)" % (horas, minutos))
