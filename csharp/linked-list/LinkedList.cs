using System;

public class Deque<T>
{
    private Node<T> current;
    private Node<T> head;
    
    public void Push(T value)
    {
        Node<T> node = new Node<T>(value);
        if (this.head == null) // i.e. the first instance of making the list
        {
            // initialize everything, including current
            this.head = node;
            this.current = this.head;
        }
        else
        {
            //The following ensures current will always be the last element
            this.current.Next = node;
            node.Prev = this.current;
            this.current = node;
        }
        
    }

    public T Pop()
    {
        //Remove the element at the end of the list
        T last = this.current.Data;
        this.current = this.current.Prev;
        //this.current.Next = null;
        return last;
    }

    public void Unshift(T value)
    {
        Node<T> node = new Node<T>(value);
        if (this.head == null) // i.e. the first instance of making the list
        {
            // initialize everything, including current
            this.head = node;
            this.current = this.head;
        }
        else
        {
            //The following ensures current will always be the last element
            //Connect head and the newly created node
            this.head.Prev = node;
            node.Next = this.head;
            //Finally, move head to node
            this.head = node;
        }
    }

    public T Shift()
    {
        //Remove the element at the start of the list
        T first = this.head.Data;
        this.head = this.head.Next;
        //this.head.Prev = null;
        return first;
    }
}

internal class Node<T>
{
    public Node<T> Next {get; set;}
    public Node<T> Prev {get; set;}
    public T Data {get; set;}
    
    public Node(T data)
    {
        this.Data = data;
    }
    
}