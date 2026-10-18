namespace System.Collections.Generic;

internal class NullableComparer`1 : Comparer
{

	public NullableComparer`1() { }

	public virtual int Compare(Nullable x, Nullable y) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

}

