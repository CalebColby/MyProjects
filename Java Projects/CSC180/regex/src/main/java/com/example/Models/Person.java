package com.example.Models;

public class Person {
    private String name;
    private String phoneNumber;

    public String getName() {return name;}
    public String getPhoneNumber() {return phoneNumber;}

    public void setName(String name){this.name = name;}
    public void setPhoneNumber(String phoneNumber){
        if(isPhoneNumber(phoneNumber)){
            this.phoneNumber = phoneNumber;
            return;
        }
        throw new IllegalArgumentException();
    }

    public static boolean isPhoneNumber(String possiblePhoneNumber){
        String regexPattern = "[0-9][0-9][0-9]-[0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]";

        return possiblePhoneNumber.matches(regexPattern);
    }
}
