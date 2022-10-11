package com.example;

/**
 * Hello world!
 */
public final class App {
    private App() {
    }

    /**
     * Says hello to the world.
     * @param args The arguments of the program.
     */
    public static void main(String[] args) {
        float[] vars = {2.5f,2.5f,4f,3.2f};
        System.out.println(add(vars));
        System.out.println(subtract(3.7f,2.1f));
        System.out.println(multiply(vars));
        System.out.println(divide(4.5f, 1.5f));
    }

    public static float add(float[] vars){
        float result = 0f;
        for (float f : vars) {
            result += f;
        }
        return result;
    }

    public static float subtract(float minemund, float subtrahend){
        return minemund - subtrahend;
    }

    public static float multiply(float[] vars){
        float result = 1f;
        for (float f : vars) {
            result *= f;
        }
        return result;
    }

    public static float divide(float divedend, float divisor){
        return divedend / divisor;
    }
}
