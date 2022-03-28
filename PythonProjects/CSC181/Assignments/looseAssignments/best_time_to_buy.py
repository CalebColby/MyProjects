def bestTimeToBuy(prices):
    boughtValue = "null"
    totalEarnings = 0
    hasStock = False

    for idx, x in enumerate(prices):
        if (idx + 1) == prices.length():
            if hasStock:
                totalEarnings += (x - boughtValue)
                boughtValue = "null"

    return totalEarnings

print(bestTimeToBuy([7,1,5,3,6,4]))
print(bestTimeToBuy([1,2,3,4,5]))
print(bestTimeToBuy([7,6,4,3,1]))