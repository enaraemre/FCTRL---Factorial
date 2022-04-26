n =int(input())
i=0
numbers = []
sonuc = 0
bol = 5
while i<n:
    numbers.append(int((input())))
    i+=1
i=0
while i<n:
    while numbers[i]/bol>=1:
        sonuc = sonuc + int(numbers[i] / bol)
        bol *=5
    bol = 5
    print(sonuc)
    sonuc = 0
    i +=1