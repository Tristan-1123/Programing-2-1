eggs = int(input("Number of Eggs"))
cost = 0.0
if eggs > 0 and eggs < 48:
  cost = 0.50
elif eggs >= 48 and eggs < 72:
  cost = 0.45
elif eggs >= 72 and eggs < 132:
  cost = 0.40
elif eggs >= 132:
  cost = 0.35
doz = eggs / 12
sin = eggs % 12

dozc = doz * cost
sinc = sin * (cost / 12)
result = dozc + sinc
print("The total cost is: $" + str(round(result,2)))
