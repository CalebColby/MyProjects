nums = [1, 67, 32, 41, 9, 20, 24, 57]
nums.sort()
print(nums[-2])
print(nums)

concessions = {
    '2022-01-01': {'popcorn': 30, 'soda': 40},
    '2022-01-02': {'popcorn': 10, 'soda': 50},
    '2022-01-03': {'popcorn': 50, 'soda': 60},
}

totalSales = dict()

totalSales['Jan 1st'] = '$' + str(8*concessions['2022-01-01']['popcorn'] + 5*concessions['2022-01-01']['soda'])
totalSales['Jan 2nd'] = '$' + str(8*concessions['2022-01-02']['popcorn'] + 5*concessions['2022-01-02']['soda'])
totalSales['Jan 3rd'] = '$' + str(8*concessions['2022-01-03']['popcorn'] + 5*concessions['2022-01-03']['soda'])
print(totalSales)

bit_string = "100?011?11?"

replaceVal = 1

while True:
    if bit_string.find('?') < 0:
        break
    bit_string.replace('?', str(replaceVal), 1)
    if replaceVal == 1:
        replaceVal = 0
    else:
        replaceVal = 1
print(bit_string)