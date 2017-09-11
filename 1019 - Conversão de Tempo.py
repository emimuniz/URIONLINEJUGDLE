#Leia um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma fábrica, e informe-o expresso no formato horas:minutos:segundos.
segundos_normal = int(input())
horas_normal = 3600
minutos_normal = 60

horas = int((segundos_normal / horas_normal))
minutos = int((segundos_normal % horas_normal) / minutos_normal)
segundos = int((segundos_normal % horas_normal) % minutos_normal)

print(str(horas) + ":" + str(minutos) + ":" + str(segundos))