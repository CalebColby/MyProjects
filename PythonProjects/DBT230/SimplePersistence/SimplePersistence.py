import os
import pickle
from webbrowser import get

SIMPLE_PATH = r'C:\Users\Ccolby\OneDrive - Neumont College of Computer Science\Desktop\DBT230 Databases II\people\simple/'
SIMPLE_SERIAL_PATH = r'C:\Users\Ccolby\OneDrive - Neumont College of Computer Science\Desktop\DBT230 Databases II\people\simple serialized'
LONG_PATH =r'C:\Users\Ccolby\OneDrive - Neumont College of Computer Science\Desktop\DBT230 Databases II\people\long/'
LONG_SERIAL_PATH =r'C:\Users\Ccolby\OneDrive - Neumont College of Computer Science\Desktop\DBT230 Databases II\people\long serialized/'

class Employee:
    def __init__(self, id, fname, lname, hiredate):
        self.id = id
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
    for str in file:
        
        info = str.split(', ')
        return Employee(info[0], info[1], info[2], info[3])
    
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
    file_path = os.path.join(SIMPLE_PATH, file_name)
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
    long_path = os.path.join(LONG_PATH, file_name)

    if os.path.isfile(long_path):
        print('This file already exists')
    else:
        file_reference = open(long_path, "w")
        string_to_write = f''
        file_reference.write(string_to_write)
        file_reference.close()
            
def serialize_all_employee():
    files = os.listdir(LONG_PATH)
    for file in files:
        with open(os.path.join(LONG_PATH, file), "r") as f:
            emp = get_employee_from_file(f)
            id = emp.id
            ser_path = f'{id}.ser'
            with open(os.path.join(LONG_SERIAL_PATH, ser_path), 'wb') as ser:
                pickle.dump(emp, ser)
            

def get_serialized_employee(id):
    ser_path = f'{id}.ser'
    with open(os.path.join(LONG_SERIAL_PATH, ser_path), "rb") as out:
        emp = pickle.load(out)
        return emp
        
def find_employee_by_id(id): #return an employee object
    file_name = f'{id}.txt'
    file_path = os.path.join(LONG_PATH, file_name)
    if os.path.isfile(file_path):
        with open(file_path, 'r') as file:
            emp =get_employee_from_file(file)
            return emp    
    else:
        print('Error: That Id does not exist')

def print_serialized_details(path):
    files = os.listdir(path)
    for file in files:
        with open(os.path.join(path, file), 'rb') as content:
            print(pickle.load(content))
            
def GetAllEmployees(path):
    files = os.listdir(path)
    for file in files:
        with open(os.path.join(LONG_SERIAL_PATH, ser_path), "rb") as out:
            emp = pickle.load(out)
            for x in f:
                id = x.split(', ')[0]
                first_name = x.split(', ')[1]
                last_name = x.split(', ')[2]
                hire_year = x.split(', ')[3]
                employee = Employees(id, first_name, last_name, hire_year)
                all_employees.update({employee.id, employee})
            f.close()

def printAllEmployees():
    all_employees = GetAllEmployees()
    print(all_employees)
    
def get_last_name_file(file):
    for str in file:

        info = str.split(', ')
        return info[2]


def FindEmployeeByLastName(last_name):
    files = os.listdir(LONG_PATH)
    for file in files:
        lb = get_last_name_file
        if lb == last_name:
            with open(os.path.join(LONG_PATH, file), "r") as f:
                return get_employee_from_file(f)

def FindAllEmployeesByLastName(lastName):
    emplist = []
    iles = os.listdir(LONG_PATH)
    for file in files:
        lb = get_last_name_file
        if lb == last_name:
            with open(os.path.join(LONG_PATH, file), "r") as f:
                 emplist.append(get_employee_from_file(f))
    return emplist
     
# update_employee(1, 'Jane', 'Doe', 'September 2003')
# delete_employee(4)

# serialize_all_employee()

# test = get_serialized_employee(2)
# print(test)
                
# print_people_details(SIMPLE_PATH)
# print("-"*50 + '\n')
# print_employees(SIMPLE_PATH)

# print(find_employee_by_id(9))
# print_serialized_details(SIMPLE_SERIAL_PATH)