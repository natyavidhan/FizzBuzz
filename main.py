for i in range(100):
    output = ""
    output += "Fizz" if i%3==0 else ""
    output += "Buzz" if i%5==0 else ""
    output = i if output == "" else output
    print(output)