#1
#operation = input('''
#Millist arvutust soovite teha?
#+ Liitmine
#- Lahutamine
#* Korrutamine
#/ Jagamine
#''')

#a = int (input("Sisestage esimene arv: "))
#b = int (input("Sisestage teine arv: "))

#if operation == '+':
    #print("{} + {} = ".format(a,b))
    #print(a+b)

#elif operation == '-':
    #print("{} - {} = ".format(a,b))
    #print(a-b)

#elif operation == '*':
    #print("{} * {} = ".format(a,b))
    #print(a*b)

#elif operation == '/':
    #print("{} / {} = ".format(a,b))
    #print(a/b)

#else:
    #print("Vale tehe.")

#2
#for i in range(0,101):
    #print(i)

#3
#for i in range(100, 0, -10):
    #print(i)

#4
#nimi = input("Sisestage oma nimi: ")
#print(nimi.upper())
#perekonnanimi = input("Sisestage oma perekonnanimi: ")
#print(perekonnanimi.lower())

#5
#autod = ['BMW', 'Volkswagen', 'Ferrari', 'Mercedes', 'Lamborghini']
#for auto in autod:
    #print(auto)

#for item in range(len(autod)):
    #autod.append('kia')
#print(autod)

#autod2 = []

#for i in range (10):
    #autod2.append("auto" + str(i))
#print(autod2)

#6
#autonimi = 'lamborghini'
#for täht in autonimi:
    #print(täht)

num_list = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
alpha_list = ['a', 'b', 'c']
third_list = ['x', 'y']
#for number in num_list:
    #print(number)
    #for täht in alpha_list:
        #print(täht)
        #for täht in third_list:
            #print(täht)
list_of_list = [['ferrari, lamborghini'], [1, 4, 5], [2, 2]]
for list in list_of_list:
    for item in list:
        print(item)




