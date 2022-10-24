package com.example;

import org.junit.jupiter.api.Test;

import com.example.Models.Person;

import static org.junit.jupiter.api.Assertions.assertEquals;

/**
 * Unit test for simple App.
 */
class AppTest {
    /**
     * Rigorous Test.
     */
    @Test
    void ValidPhoneNumbers() {
        assertEquals(true, Person.isPhoneNumber("801-234-6443"));
        assertEquals(true, Person.isPhoneNumber("801-555-6443"));
        assertEquals(true, Person.isPhoneNumber("801-264-6734"));
        assertEquals(true, Person.isPhoneNumber("385-294-8950"));
    }

    @Test
    void InvalidPhoneNumbers() {
        assertEquals(false, Person.isPhoneNumber(""));
        assertEquals(false, Person.isPhoneNumber("8017128989"));
        assertEquals(false, Person.isPhoneNumber("(801) 555-2345"));
        assertEquals(false, Person.isPhoneNumber("555 555 5555"));
        assertEquals(false, Person.isPhoneNumber("abc-def-ghij"));
    }
}
