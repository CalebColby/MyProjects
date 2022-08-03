from pymongo import MongoClient
import os

client = MongoClient('localhost', 27018)
db = client["PeopleDB"]
coll = db["People"]

LONG_PATH =r'C:\Users\Ccolby\OneDrive - Neumont College of Computer Science\Desktop\DBT230 Databases II\people\long/'

def AddAllRecords():
    PeopleFiles = os.listdir(LONG_PATH)
    for Pfile in PeopleFiles:
        with open(os.path.join(LONG_PATH, Pfile), 'r') as file:
            text = file.readline()
            info = text.split(', ')
            info[3] = info[3][:4]
            record = {"_id": info[0],"First Name" : info[1], "Last Name" : info[2], "HireDate" : info[3]}
            coll.insert_one(record)
            print(record)



def InsertRecords(id, first_name, last_name, hire_year):
    insert_dict = {"_id" : id, "First Name": first_name, "Last Name": last_name, "Hire Date": hire_year}

    collection.insert_one(insert_dict)

def DeleteRecords(id):
    delete_dict = {"_id" : str(id)}

    collection.delete_one(delete_dict)

def FindRecords(id):
    find_dict = {"_id" : str(id)}

    x = collection.find_one(find_dict)

    print(x)

def UpdateRecords(id, first_name, last_name, hire_year):
    update_find_dict = {"_id" : str(id)}
    update_change_dict = {"$set": {"First Name" : first_name, "Last Name" : last_name, "Hire Date" : hire_year}}
    collection.update_one(update_find_dict, update_change_dict)


        
        
#AddAllRecords()
#InsertRecords("0", "George", "Smith", "2008")
#FindRecords("0")
#UpdateRecords("0", "James", "Roberts", "1999")
#DeleteRecords("0")