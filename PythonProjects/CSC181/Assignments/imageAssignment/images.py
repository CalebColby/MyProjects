from PIL import Image, ImageOps
import os

filePath = os.path.dirname(os.path.realpath(__file__))
sourcePath = os.path.join(filePath, 'images')
destPath = os.path.join(filePath, 'newImages')

if not os.path.isdir(sourcePath):
    print("Creating Folder: {}".format(sourcePath))
    os.mkdir(sourcePath)


if not os.path.isdir(destPath):
    print("Creating Folder: {}".format(destPath))
    os.mkdir(destPath)

with Image.open(os.path.join(sourcePath, 'aagib.jpg')) as im:
    print(im.size)

    width, height = im.size
    im = im.rotate(270)
    im = im.crop((30, 0, width-30, height))
    im = ImageOps.grayscale(im)

    im.save(os.path.join(destPath, 'newAagib.png'))
    im.save(os.path.join(destPath, 'newAagib.jpg'))