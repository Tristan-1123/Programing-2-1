import random
cnum = random.randrange(1,20)
pnum = int(input("Enter a Number Between 1 and 20: "))
if pnum == cnum:
  print(cnum)
  print(pnum)
  print("You Win!")
else:
  print("Better Luck Next Time.")