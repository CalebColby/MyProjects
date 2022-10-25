package com.example;

public class Person {
    public String Name;
    public String PhoneNumber;

    public Person(String name, String PhoneNum){
        Name = name;
        PhoneNumber = PhoneNum;
    }

    @Override
    public String toString(){
        return new StringBuilder("Name: ").append(Name)
        .append(", Phone Number: ").append(PhoneNumber).toString();
    }
}
