#Joaozinho quer calcular e mostrar a quantidade de litros de combustível gastos em uma viagem, ao utilizar um automóvel que faz 12 KM/L.
# Para isso, ele gostaria que você o auxiliasse através de um simples programa.
# Para efetuar o cálculo, deve-se fornecer o tempo gasto na viagem (em horas) e a velocidade média durante a mesma (em km/h).

horas = int(input(''))
velocidade = int(input(''))
consumo = horas/12*velocidade
print('{:.3f}'.format(consumo))
