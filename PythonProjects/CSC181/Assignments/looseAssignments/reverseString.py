import argparse

def reverseString(s):
    s = list(s)
    tracker = 0
    for x in range(0, int(len(s)/2)):
        temp = s[tracker]
        s[tracker] = s[((-1*tracker) - 1)]
        s[((-1*tracker) - 1)] = temp
        tracker += 1
    return s

parser = argparse.ArgumentParser(description="Give Me a String and I will reverse it")
parser.add_argument("-s", type=str, default="", help="Give this arg a String Value")

args = parser.parse_args()

if len(args.s) > 0:
    print(str(reverseString(args.s)))

