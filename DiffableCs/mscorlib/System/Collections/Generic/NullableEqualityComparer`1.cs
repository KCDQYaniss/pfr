namespace System.Collections.Generic;

internal class NullableEqualityComparer`1 : EqualityComparer
{

	public NullableEqualityComparer`1() { }

	public virtual bool Equals(Nullable x, Nullable y) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode(Nullable obj) { }

	public virtual int GetHashCode() { }

	internal virtual int IndexOf(Nullable[] array, Nullable value, int startIndex, int count) { }

	internal virtual int LastIndexOf(Nullable[] array, Nullable value, int startIndex, int count) { }

}

