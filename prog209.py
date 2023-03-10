from CL209 import *

def main():
  try:
    with open("data/prog215a.dat", 'r') as f:
      for line in f:
        num = int(line.strip())
        nums = CL209(num)
        nums.make()
      print(nums)
  except Exception as e:
    print("Error:", e)

if __name__ == "__main__":
  main()