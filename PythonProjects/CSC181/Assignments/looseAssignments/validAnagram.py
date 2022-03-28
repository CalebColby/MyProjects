import argparse

parser = argparse.ArgumentParser(description="Anagram Detector")
parser.add_argument("-s", default="", type=str, help="Type one of the comparison strings here")
parser.add_argument("-t", default="", type=str, help="Type another string to be compared against the first")

args = parser.parse_args()


s = args.s
t = args.t

def checkAnagram(sVar, tVar):
    if sorted(sVar) == sorted(tVar):
        return True
    else:
        return False
    

if len(s) > 0 and len(t) > 0:
    print(str(checkAnagram(str(s), str(t))))
    