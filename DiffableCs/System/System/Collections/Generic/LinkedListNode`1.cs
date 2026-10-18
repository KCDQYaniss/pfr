namespace System.Collections.Generic;

public sealed class LinkedListNode`1
{
	internal LinkedList list; //Field offset: 0x0
	internal LinkedListNode next; //Field offset: 0x0
	internal LinkedListNode prev; //Field offset: 0x0
	internal T item; //Field offset: 0x0

	public LinkedListNode Next
	{
		 get { } //Length: 51
	}

	public LinkedListNode Previous
	{
		 get { } //Length: 47
	}

	public T Value
	{
		 get { } //Length: 11
		 set { } //Length: 82
	}

	public LinkedListNode`1(T value) { }

	internal LinkedListNode`1(LinkedList list, T value) { }

	public LinkedListNode get_Next() { }

	public LinkedListNode get_Previous() { }

	public T get_Value() { }

	internal void Invalidate() { }

	public void set_Value(T value) { }

}

