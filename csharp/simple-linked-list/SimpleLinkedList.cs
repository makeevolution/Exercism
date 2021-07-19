using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class SimpleLinkedList<T> : IEnumerable<T>
{
    private T value;
    private SimpleLinkedList<T> next;

    // START READING HERE, THESE TWO METHODS DEFINE THE LIST
    // "this" refers to the linked list itself
    public SimpleLinkedList(T value)
    {
        this.value = value;
    }

    public SimpleLinkedList(IEnumerable<T> values)
    {
        this.value = values.First();

        foreach (var i in values.Skip(1))
        {
            this.Add(i);
        }
    }

    public T Value 
    { 
        get
        {
            return this.value;
        } 
    }

    public SimpleLinkedList<T> Next
    { 
        get
        {
            return this.next;
        } 
    }

    public SimpleLinkedList<T> Add(T value)
    {
        // Make a reference to the current list
        var current_item = this;
        // Iterate through the nodes until we find the last node
        while (current_item.next != null)
        {
            current_item = current_item.next;
        }
        // Create a new node with value "value"
        current_item.next = new SimpleLinkedList<T>(value);
        // Since current_item is a reference to "this", "this" will also
        // be updated. Since "this" is the real list, return it instead.
        return this;
    }

    // This method implements what happens when the "foreach" in SimpleLinkedList
    // method above is called i.e. foreach automatically calls this method , and 
    //this method creates the enumerables used
    // by foreach to iterate. Some info: with strings, list, array etc. built in
    // collections data type, this method is already implemented in their source code!
    
    // This method won't stop at the first yield return, but will keep
    // going until the iterator is exhausted.
    public IEnumerator<T> GetEnumerator()
    {
        yield return value;
        SimpleLinkedList<T> current_item = this.next;

        // Remember, the null one is the node, not the item inside!
        while (current_item != null)
        {
            yield return current_item.value;
            current_item = current_item.next;
        }
    }

    // Since we use Inenumerable<T> interface, need to also implement the
    // generic GetEnumerator method() (which in turn is coded below to
    // implement the non-generic GetEnumerator coded above).
    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}