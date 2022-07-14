from http import client
from pydoc import cli
from pymongo import MongoClient
import os


LONG_PATH =r'C:\Users\Ccolby\OneDrive - Neumont College of Computer Science\Desktop\DBT230 Databases II\people\long/'

client = MongoClient('localhost', 27018)
db = client["PeopleDB"]
coll = db["People"]

PeopleFiles = os.listdir(LONG_PATH)

for Pfile in PeopleFiles:
    with open(os.path.join(LONG_PATH, Pfile), 'r') as file:
        text = file.readline()
        info = text.split(', ')
        info[3] = info[3][:4]
        record = {"_id": info[0],"First Name" : info[1], "Last Name" : info[2], "HireDate" : info[3]}
        coll.insert_one(record)
        print(record)