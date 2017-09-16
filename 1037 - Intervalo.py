num1 = float(input())

if num1 >= 0 and num1 <= 25.0000:
	print("Intervalo [0,25]")
elif num1 > 25.0000 and num1<= 50.0000:
	print("Intervalo (25,50]")
elif num1 > 50.0000 and num1 <= 75.0000:
	print("Intervalo (50,75]")
elif num1 > 75.0000 and num1 <= 100.0000:
	print("Intervalo (75,100]")
else:
	print("Fora de intervalo")

