package com.example;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Scanner;

/**
 * Hello world!
 */
public final class App {
    private App() {
    }

    /**
     * Says hello to the world.
     * @param args The arguments of the program.
     * @throws IOException
     */
    public static ArrayList<Person> main(String[] args) throws IOException {
        String filePath = "C:\\Users\\Ccolby\\OneDrive - Neumont College of Computer Science\\Desktop\\people-2.to.regex.csv";

        String text = ReadFile(filePath);

        ArrayList<Person> People = ConvertToPeopleData(text);

        for (Person person : People) {
            System.out.println(person.toString());
        }

        System.out.println(People.size());
        return People;
    }

    private static ArrayList<Person> ConvertToPeopleData(String BulkData){
        ArrayList<Person> People = new ArrayList<Person>();

        String[] lines = BulkData.split("\n");

        String PhoneRegex = "[0-9]{3}-[0-9]{3}-[0-9]{4}";

        for(int i = 0;i<lines.length;i++) {
            String[] personData = lines[i].split(",");
            if(personData[3].matches(PhoneRegex)){
                People.add(new Person(personData[0], personData[3]));
            }
        }

        return People;
    }

    private static String ReadFile(String filePath) throws FileNotFoundException{
        File file = new File(filePath);
        Scanner sc = new Scanner(file);

        StringBuilder sb = new StringBuilder();

        while(sc.hasNextLine()){
            sb.append(sc.nextLine());
            sb.append("\n");
        }
        sc.close();
        
        return sb.toString();
    }
}
