
def fizz_buzz(num: int):
    output = ""
    if num % 3 == 0:
        output += "Fizz"
    if num % 5 == 0:
        output += "Buzz"
    if len(output) == 0:
        output += str(num)
    print(f"\"{output}\"")
    