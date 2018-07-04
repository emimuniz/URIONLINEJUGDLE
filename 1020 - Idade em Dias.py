#Leia um valor inteiro correspondente à idade de uma pessoa em dias e informe-a em anos, meses e dias

dias = int(input(''))
anoindividuo = int(dias/365)
mesesindividuo = int((dias%365)/30)
diasindividuo = int((dias%365)%30)
print('{} ano(s)'.format(anoindividuo))
print('{} mes(es)'.format(mesesindividuo))
print('{} dia(s)'.format(diasindividuo))
