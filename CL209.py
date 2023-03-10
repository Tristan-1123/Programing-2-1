num2 = 0
num3 = 0
num4 = 0
class CL209:

  def __init__(self, num):
    self.num = num

    
  def __calc(self, num):
    global num2
    global num3
    global num4
    if self.num <= 499:
      num2 += 1
    elif self.num >= 500:
      num3 += 1
    num4 = num2 + num3


  def make(self):
    self.__calc(self)

  def __str__(self):
    return  f"The number of numbers less than 500 is {num2}. The number of numbers greater than or equal to 500 is {num3}. The total is {num4}."