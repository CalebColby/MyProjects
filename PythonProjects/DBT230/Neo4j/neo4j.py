import os
from py2neo import Graph, Node, Relationship
graph = Graph(password="1234")

LONG_PATH =r'C:\Users\Ccolby\OneDrive - Neumont College of Computer Science\Desktop\DBT230 Databases II\people\long/'
# FRIEND_PATH = r"C:\Users\Ccolby\OneDrive - Neumont College of Computer Science\Desktop\DBT230 Databases II\people\friendships.csv"
# REPORTS_PATH = r"C:\Users\Ccolby\OneDrive - Neumont College of Computer Science\Desktop\DBT230 Databases II\people\reportsTo.csv"

def AddAllRecords():
    PeopleFiles = os.listdir(LONG_PATH)
    counter = 0
    for Pfile in PeopleFiles:
        with open(os.path.join(LONG_PATH, Pfile), 'r') as file:
                tx = graph.begin()
                text = file.readline()
                info = text.split(', ')
                info[3] = info[3][:4]
                record = Node("Person", Id = info[0], FirstName = info[1], LastName = info[2], HireYear = info[3])
                tx.create(record)
                tx.commit()
                counter = counter + 1
                if(counter % 100 == 0):
                    print(record)



def InsertRecords(id, first_name, last_name, hire_year):
    g = graph.begin()
    record = Node("Person", Id = id, FirstName = first_name, LastName = last_name, HireYear = hire_year)
    g.create(record)
    g.commit()

def DeleteRecords(id):
    bad_node = FindRecords(id)
    graph.delete(bad_node)

def FindRecords(id):
    return graph.evaluate(f'MATCH (n) where n.Id = "{id}"  RETURN n')

def UpdateRecords(id, first_name, last_name, hire_year):
    graph.evaluate(f'MATCH (n) where n.Id = "{id}" SET n.FirstName = "{first_name}", n.LastName = "{last_name}", n.HireYear = "{hire_year}" RETURN n')
    


        
        
# AddAllRecords()
# InsertRecords("0", "George", "Smith", "2008")
# print(FindRecords("0"))
# UpdateRecords("0", "James", "Roberts", "1999")
# DeleteRecords("0")