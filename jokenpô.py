import random 

eu = 0
adv = 0
x = ["PEDRA","PAPEL","TESOURA"]
while True:
    escolha1 = random.choice(x)
    escolha2 = input("Escolha Pedra,Papel ou Tesoura:").upper()
    if escolha1 == escolha2:
        print(f"A Sua escolha foi {escolha2} e a escolha do adversário foi {escolha1}")
        print("Empate")
        print(f"PLACAR----- EU:{eu} ADV:{adv}")
    elif escolha1 == "PEDRA" and escolha2 == "PAPEL" or escolha1 == "PAPEL" and escolha2 == "TESOURA" or escolha1 == "TESOURA" and escolha2 == "PEDRA":
        eu +=1
        print(f"A sua escolha foi {escolha2} e a escolha do adversário foi {escolha1}")
        print(f"PLACAR----- EU:{eu} ADV:{adv}")
    elif escolha1 == "PEDRA" and escolha2 == "TESOURA" or escolha1 == "PAPEL" and escolha2 == "PEDRA" or escolha1 == "TESOURA" and escolha2 == "PAPEL":
        adv +=1
        print(f"A sua escolha foi {escolha2} e a escolha do seu adversário foi {escolha1}")
        print(f"PLACAR----- EU:{eu} ADV:{adv}")