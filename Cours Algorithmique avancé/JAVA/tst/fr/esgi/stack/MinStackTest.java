package fr.esgi.stack;

import org.junit.Test;

import static org.junit.Assert.*;

/**
 * Created by damie on 30/03/2017.
 */
public class MinStackTest  {
    @Test
    public void push(){
        MinStack mini=new MinStack();

        mini.push(3);
        assertEquals(3,mini.getMin(),0);

        mini.push(1);
        assertEquals(1,mini.getMin(),0);

        mini.push(5);
        assertEquals(1,mini.getMin(),0);

        mini.push(0);
        assertEquals(0,mini.getMin(),0);

    }
    @Test
    public void pop(){
        MinStack mini=new MinStack();

        mini.push(3);
        assertEquals(3,mini.getMin(),0);

        mini.push(1);
        assertEquals(1,mini.getMin(),0);

        mini.push(5);
        assertEquals(1,mini.getMin(),0);

        mini.push(0);
        assertEquals(0,mini.getMin(),0);

        mini.pop();
        assertEquals(1,mini.getMin(),0);
    }


}