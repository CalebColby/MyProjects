from curses import longname
from fnmatch import fnmatchcase
import os

from setuptools import find_namespace_packages

SIMPLE_PATH = r'C:\Users\Ccolby\OneDrive - Neumont College of Computer Science\Desktop\people\simple'

class Employee:
    def __init__(self, fname, lname, hiredate):
        self.fname = fname
        self.lname = lname
        self.hiredate = hiredate
    
    def toString(self):
        return f'{self.fname} {slef.lname} was hired {self.hiredate}'

def print_people_details(path):
    files = os.listdir(path)
    for file in files:
        if os.path.isfile(os.path.join(path, file)):
            f = open(os.path.join(path, file), 'r')
            for x in f:
                print(x)
            f.close()
            
def get_employee_from_file(file):
    x = 2
                
    
print_people_details(SIMPLE_PATH)