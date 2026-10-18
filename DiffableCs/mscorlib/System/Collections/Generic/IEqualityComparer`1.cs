namespace System.Collections.Generic;

public interface IEqualityComparer`1
{

	public bool Equals(T x, T y) { }

	public int GetHashCode(T obj) { }

}

