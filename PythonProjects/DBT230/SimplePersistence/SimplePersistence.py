import os

from setuptools import find_namespace_packages

SIMPLE_PATH = r'C:\Users\Ccolby\OneDrive - Neumont College of Computer Science\Desktop\people\simple/'

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
                
    
print_people_details(SIMPLE_PATH)
print("-"*50 + '\n')
print_employees(SIMPLE_PATH)