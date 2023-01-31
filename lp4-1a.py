copies = int(input("Enter number of copies to be printed"))

price = 0.0
if copies > 0 and copies <= 99:
  price = 0.30
elif copies > 99 and copies <= 499:
  price = 0.28
elif copies > 499 and copies <= 749:
  price = 0.27
elif copies > 749 and copies <= 1000:
  0.26
elif copies >= 1000:
  price = 0.25

print("The price per copy is: $" + str(price))
print("The total cost is $" + str(price*copies))