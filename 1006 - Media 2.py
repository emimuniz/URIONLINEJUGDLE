#Leia 3 valores, no caso, variáveis A, B e C, que são as três notas de um aluno.
# A seguir, calcule a média do aluno, sabendo que a nota A tem peso 2, a nota B tem peso 3 e a nota C tem peso 5.

A = float(input(''))
B = float(input(''))
C = float(input(''))
MEDIA = ((A*2)+(B*3)+(C*5))/10
print('MEDIA = {:.1f}'.format(MEDIA))
