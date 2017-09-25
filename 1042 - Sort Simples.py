from array import array

n1, n2, n3 = input().split()
n1 = int(n1)
n2 = int(n2)
n3 = int(n3)
arrayDesordenado = array("i",[n1,n2, n3])

menor = min(n1, n2, n3)
maior = max(n1, n2, n3)

print(menor)
if menor < n1 and maior > n1:
    print(n1)
elif menor < n2 and maior > n2:
    print(n2)
else:
    print(n3)
print(str(maior) + "\n")

for value in arrayDesordenado:
    print(value)

