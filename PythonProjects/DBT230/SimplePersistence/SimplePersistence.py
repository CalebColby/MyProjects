import os

SIMPLE_PATH = r'C:\Users\Ccolby\OneDrive - Neumont College of Computer Science\Desktop\MyProjects\Github\PythonProjects\DBT230\SimplePersistence\people\simple/'

def print_people_details(path):
    files = os.listdir(path)
    for file in files:
        if os.path.isfile(os.path.join(path, file)):
            f = open(os.path.join(path, file), 'r')
            for x in f:
                print(x)
            f.close()
                
    
print_people_details(SIMPLE_PATH)