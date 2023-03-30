from CL213b import *
def main():
  try:
    with open("data/prog213b.txt", 'r') as f:
      for line in f:
        num = int(line.strip())
        nums = CL213b(num)
        nums.calc(num)
        print(nums)
  except Exception as e:
    print("Error:", e)

if __name__ == "__main__":
  main()