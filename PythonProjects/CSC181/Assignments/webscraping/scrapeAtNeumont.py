from urllib.request import urlopen, Request
from bs4 import BeautifulSoup as BS
import os

dirPath = os.path.dirname(os.path.realpath(__file__))
filepath = os.path.join(dirPath, 'scrape.txt')

url = 'http://neumont.smartcatalogiq.com/2021-2022/Catalog/Academic-Calendar-2021-2022'
page = urlopen(url)

soup = BS(page, 'html.parser')
Child = soup.find('div', {'class' : {'combinedChild'}})
TBody = Child.find_all('tbody')
for thing in TBody:
    TRows = thing.find_all('tr')
    for x in TRows:
        tds = x.find_all('td')
        for td in tds:
            print(td.contents[0])
            with open(filepath, 'a') as file:
                file.write(td.contents[0])
                file.write('\n')

# print(TRows)