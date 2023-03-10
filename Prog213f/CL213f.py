class Cl213f:
  def __init__(self, kwh):
    self.kwh = kwh
    self.cost = 0.0

  def calc(self):
    if self.kwh <= 2000:
      self.cost = self.kwh * 7
    elif self.kwh > 2000 and self.kwh <= 10000:
      self.cost = self.kwh * 5
    elif self.kwh > 10000:
      self.cost = self.kwh * 4

  def __str__(self):
    return f"The cost of the bill is {self.cost}"
