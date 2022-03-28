isNotValid = True

totalValue = 0
totalNums = 0

while(isNotValid):
    userInput = str(input("Give a List of Number Values:"))
    try:
        numList = userInput.split(",")
        for x in numList:
            totalValue += int(x)
            totalNums += 1
        isNotValid = False
    except:
        print("You must provide a list of only Number Values that separated by only commas. (No Spaces)")

print(totalValue/totalNums)
