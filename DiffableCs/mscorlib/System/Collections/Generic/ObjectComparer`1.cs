namespace System.Collections.Generic;

internal class ObjectComparer`1 : Comparer
{

	public ObjectComparer`1() { }

	public virtual int Compare(T x, T y) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

}

