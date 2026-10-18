namespace System.Collections.Generic;

internal sealed class InternalStringComparer : EqualityComparer
{

	public InternalStringComparer() { }

	public virtual bool Equals(string x, string y) { }

	public virtual int GetHashCode(string obj) { }

	internal virtual int IndexOf(string[] array, string value, int startIndex, int count) { }

}

