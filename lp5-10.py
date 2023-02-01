num1 = int(input("Enter A Number:"))
num2 = int(input("Enter Another Number: "))
temp = num1%num2
while temp:
  pass
  num1 = num2
  num2 = temp
  temp = num1%num2
  print("The GDC is:" + str(num2))