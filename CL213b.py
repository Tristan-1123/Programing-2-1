class CL213b:
  def __init__(self, num):
    self.num = num
    self.price = 0.0
    self.total = 0.0

  def calc(self, num):
    if self.num <= 99:
      self.price = 5.95
    elif self.num >= 100 and self.num <= 199:
      self.price = 5.75
    elif self.num >= 200 and self.num <= 299:
      self.price = 5.40
    elif self.num >= 300:
      self.price = 5.15
    self.total = self.price * self.num

  def make(self):
    self.calc(self)
  def __str__(self):
    return f" Quantity {self.num} \n Price ${self.price} \n Amount Due ${self.total}"