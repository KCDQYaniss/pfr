namespace System.Collections.Generic;

internal class ByteEqualityComparer : EqualityComparer
{

	public ByteEqualityComparer() { }

	public virtual bool Equals(byte x, byte y) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode(byte b) { }

	public virtual int GetHashCode() { }

	internal virtual int IndexOf(byte[] array, byte value, int startIndex, int count) { }

	internal virtual int LastIndexOf(byte[] array, byte value, int startIndex, int count) { }

}

