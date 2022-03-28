import tkinter as TK
import json
import os
from datetime import datetime

dirPath = os.path.dirname(os.path.realpath(__file__))
json2path = os.path.join(dirPath, 'todo.json')
jsonPeoplePath = os.path.join(dirPath, 'People.json')



def loadData(filePath):
    data = list()
    try:
        file = open(filePath, "r")
        data = json.loads(file.read())
        file.close()
    except:
        pass
    return data

def saveData(data, filePath):
    with open(filePath, "w") as file:
        file.write(json.dumps(list(data), indent=4))

def findEntry(searchString, data):
    for idx, x in enumerate(data):
        try:
            if str(x["Task"]).lower() == str(searchString).lower() or str(x["Finish By"]).lower() == str(searchString).lower():
                return idx
        except:
         if str(x["Name"]).lower() == str(searchString).lower() or str(x["Contact Info"]).lower() == str(searchString).lower():
                return idx
    return -1

Data2 = loadData(json2path)

root = TK.Tk()
root.title('Finally You May Choose')
root.geometry('600x600')

tasksRelY = 0.3
peopleRelY = 0.7
gameRelY = 0.85

displayMessage = TK.Message(root, text=Data2)
displayMessage.place(anchor='center', relx=.5, rely=.1)

TaskEntry = TK.Entry(root)
TaskEntry.place(anchor='center', relx=0.15, rely=tasksRelY)

DateEntry = TK.Entry(root)
DateEntry.place(anchor='center', relx=0.35, rely=tasksRelY)

AddButton = TK.Button(root, text='Add')
AddButton.place(anchor='center', relx=0.5, rely=tasksRelY)

DeleteButton = TK.Button(root, text='Delete')
DeleteButton.place(anchor='center', relx=0.7, rely=tasksRelY)

ClearButton = TK.Button(root, text='Clear')
ClearButton.place(anchor='center', relx=0.6, rely=tasksRelY)

DeleteEntry = TK.Entry(root)
DeleteEntry.place(anchor='center', relx=0.85, rely=tasksRelY)

def addTask():
    global TaskEntry
    global DateEntry
    global Data2
    task = TaskEntry.get()
    date = DateEntry.get()
    if len(task) != 0 and len(date) != 0:
        TaskEntry.delete(0, 'end')
        DateEntry.delete(0, 'end')
        Data2.append({
            'Task' : task,
            'Finish By' : date
        })
        displayMessage.configure(text=Data2)
        displayMessage.update()

def removeTask():
    global DeleteEntry
    global displayMessage
    DTask = DeleteEntry.get()
    if len(DTask) != 0:
        DeleteEntry.delete(0, 'end')
        idx = findEntry(DTask, Data2)
        if idx != -1:
            del Data2[idx]
            displayMessage.configure(text=Data2)
            displayMessage.update()

def ClearTasks():
    global Data2
    Data2 = []
    displayMessage.configure(text=Data2)
    displayMessage.update()


AddButton.configure(command=addTask)
DeleteButton.configure(command=removeTask)
ClearButton.configure(command=ClearTasks)

peopleData = loadData(jsonPeoplePath)

peopleDisplay = TK.Message(root, text=peopleData)
peopleDisplay.place(anchor='center', relx=0.5, rely=0.5)

PeopleLabel = TK.Label(root, text='Enter the name and details in the following format: [fname] [lname] [email or phone #]')
PeopleLabel.place(anchor='center', relx=0.5, rely=peopleRelY-.1)

PeopleEntry = TK.Entry(root)
PeopleEntry.place(anchor='center', relx=0.35, rely=peopleRelY)

PeopleAdd = TK.Button(root, text='Add Contact')
PeopleAdd.place(anchor='center', relx=.15, rely=peopleRelY)

PeopleDelete = TK.Button(root, text='Delete Contact')
PeopleDelete.place(anchor='center', relx=.55, rely=peopleRelY)

PeopleClear = TK.Button(root, text='Clear Contacts')
PeopleClear.place(anchor='center', relx=.8, rely=peopleRelY)

def addContact():
    global PeopleEntry
    newContact = PeopleEntry.get()
    newContact = newContact.split(' ')
    if len(newContact) == 3:
        PeopleEntry.delete(0, 'end')
        peopleData.append({
            'Name' : f'{newContact[0]} {newContact[1]}',
            'Contact Info' : newContact[2]
        })
        peopleDisplay.configure(text=peopleData)
        peopleDisplay.update()

def delContact():
    DTask = PeopleEntry.get()
    if len(DTask) != 0:
        PeopleEntry.delete(0, 'end')
        idx = findEntry(DTask, peopleData)
        if idx != -1:
            del peopleData[idx]
            peopleDisplay.configure(text=peopleData)
            peopleDisplay.update()

def clearContacts():
    global peopleData
    peopleData=list()
    peopleDisplay.configure(text=peopleData)
    peopleDisplay.update()

PeopleAdd.configure(command=addContact)
PeopleDelete.configure(command=delContact)
PeopleClear.configure(command=clearContacts)

def displayTime():
    Time = TK.Tk()
    Time.title('It is this Time')
    Time.geometry('400x400')
    myTime = datetime.now()
    myTime = myTime.strftime("%B %d, %Y \n %H:%M")
    TimeDisplay = TK.Message(Time, text=str(myTime))
    TimeDisplay.place(anchor='center', relx=.5, rely=.5)

skyrimButton = TK.Button(root, text='What Time is it?', command=displayTime)
skyrimButton.place(anchor='center', relx=0.5, rely=gameRelY)



root.mainloop()
saveData(Data2, json2path)
saveData(peopleData, jsonPeoplePath)
