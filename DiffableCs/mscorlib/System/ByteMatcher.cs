namespace System;

internal class ByteMatcher
{
	private Hashtable map; //Field offset: 0x10
	private Hashtable starts; //Field offset: 0x18

	public ByteMatcher() { }

	public void AddMapping(TermInfoStrings key, byte[] val) { }

	public TermInfoStrings Match(char[] buffer, int offset, int length, out int used) { }

	public void Sort() { }

	public bool StartsWith(int c) { }

}

