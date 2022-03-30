
String[] getIsoStringsFromFile()
{
    do 
    {
        Console.WriteLine("Give a file path:");
        try
        {
            String filePath = Console.ReadLine();
            return System.IO.File.ReadAllLines(filePath);
        }  catch(FileNotFoundException fnfe) {
            Console.WriteLine("Invalid File Path Given.\nCouldn't Find File.\nPlease Give a Valid File Path\n");
        }
    } while (true);
}


