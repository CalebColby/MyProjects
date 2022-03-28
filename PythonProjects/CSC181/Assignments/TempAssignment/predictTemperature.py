import pickle

def findDaysAverageChange(temperatures):
    changes = list()
    for idx, x in enumerate(temperatures):
        try:
            changes.append(temperatures[idx+1] - x)
        except:
            pass
    averageChange = 0
    for x in changes:
        averageChange += x
    return (averageChange/len(temperatures))


def predictTemp(startdate, enddate, temperatures, n):
    predictedTemps = list()
    days = int(len(temperatures)/24)
    averageChanges = list()
    iter = 0
    while iter != days:
        tmpList = temperature[(1+(iter*24)):(24+(iter*24))]
        print(findDaysAverageChange(tmpList))
        averageChanges.append(findDaysAverageChange(tmpList))
        iter += 1
    averageChange = 0
    for x in averageChanges:
        averageChange += x
    averageChange = averageChange/len(averageChanges)
    iter = 0
    while(iter != n):
        for x in temperatures[-24:]:
            predictedTemps.append((x + (averageChange)))
        iter += 1
    return predictedTemps

# startDate = '2022-01-01'
# endDate = '2022-01-01'
# temperature=[24
#     ,34.38
#     ,34.36
#     ,34.74
#     ,35.26
#     ,35.23
#     ,35.29
#     ,35.64
#     ,36.02
#     ,36.1
#     ,36.98
#     ,37.01
#     ,36.75
#     ,35.66
#     ,34.72
#     ,33.9
#     ,32.62
#     ,31.51
#     ,30.73
#     ,29.5
#     ,26.94
#     ,25.47
#     ,23.84
#     ,22.55
# ]

# n = 8

startDate = "2022-02-09"
endDate = "2022-02-13"

with open('temperature.pickle', 'rb') as f:
    temperature = pickle.load(f)
# temperature = temperature[:24]
n = 300

with open('test_temperature.pickle', 'rb') as f:
    testTemperature = pickle.load(f)

def test_accuracy(n, prediction_temperature, test_temperature):
    if len(prediction_temperature) != n * 24:
        print("The shape of your array is incorrect. It must be size: {}".format(n * 24))
    else:
        accuracy_score = 0
        for p, t in zip(prediction_temperature, test_temperature):
            accuracy_score += int(abs(t - p) <= 5)
        return accuracy_score

temps = predictTemp(startDate, endDate, temperature, n)

print(len(temps))
print(test_accuracy(n, temps, temps))

