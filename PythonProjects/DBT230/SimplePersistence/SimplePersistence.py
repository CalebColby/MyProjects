import os
import pickle

SIMPLE_PATH = r'C:\Users\Ccolby\OneDrive - Neumont College of Computer Science\Desktop\DBT230 Databases II\people\simple'
LONG_PATH =r'C:\Users\Ccolby\OneDrive - Neumont College of Computer Science\Desktop\DBT230 Databases II\people\long/'

class Employee:
    def __init__(self, fname, lname, hiredate):
        self.fname = fname
        self.lname = lname
        self.hiredate = hiredate
    
    def __str__(self):
        return f'{self.fname} {self.lname} was hired {self.hiredate}'

def print_people_details(path):
    files = os.listdir(path)
    for file in files:
        if os.path.isfile(os.path.join(path, file)):
            f = open(os.path.join(path, file), 'r')
            for x in f:
                print(x)
            f.close()
            
def get_employee_from_file(file):
    info = file.split(', ')
    return Employee(info[1],info[2],info[3])
    
def print_employees(path):
    files = os.listdir(path)
    for file in files:
        if os.path.isfile(os.path.join(path, file)):
            f = open(os.path.join(path, file), 'r')
            for line in f:
                print(get_employee_from_file(line))
            f.close()

def update_employee(id, fname, lname, hire_date):
    file_name = f'{str(id)}.txt'
    file_path = f'{SIMPLE_PATH}\\{file_name}'
    if os.path.isfile(file_path):
        with open(file_path, 'w') as file_ref:
            new_str = f'{id}, {fname}, {lname}, {hire_date}\n'
            file_ref.write(new_str)
            
def delete_employee(id):
    file_path = f'{SIMPLE_PATH}\\{str(id)}.txt'
    if os.path.isfile(file_path):
        os.remove(file_path)
        
def add_employee(id, first_name, last_name, hire_date):
    file_name = str(id) + '.txt'
    long_path = LONG_PATH + file_name

    if os.path.isfile(long_path):
        print('This file already exists')
    else:
        file_reference = open(long_path, "w")
        string_to_write = ', '.join([str(id), first_name, last_name, str(hire_date)])
        file_reference.write(string_to_write)
        file_reference.close()
            
def SerializeAllEmployee(id, first_name, last_name, hire_date):

   with open(' /long serializied/1.ser', 'w') as f:
      self.id = id
      self.first_name = first_name
      self.last_name = last_name
      self.hire_date = hire_date
      with open('.txt', 'rb') as f:
          p = pickle.load(f)

def GetEmployee(id = int):

    with open("pickle_obj.pickle", "wb") as out:
        pickle.dump(employee, out)

    with open("pickle_obj.pickle", "rb") as out:
        assert type(pickle.load(out)) == Employee
        
        
#update_employee(5, 'Jane', 'Doe', 'September 2003')
#delete_employee(5)
                
#print_people_details(SIMPLE_PATH)
#print("-"*50 + '\n')
#print_employees(SIMPLE_PATH)