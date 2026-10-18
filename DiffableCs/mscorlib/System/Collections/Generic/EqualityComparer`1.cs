namespace System.Collections.Generic;

[TypeDependency("System.Collections.Generic.ObjectEqualityComparer`1")]
public abstract class EqualityComparer`1 : IEqualityComparer, IEqualityComparer
{
	private static EqualityComparer defaultComparer; //Field offset: 0x0

	public static EqualityComparer Default
	{
		 get { } //Length: 335
	}

	protected EqualityComparer`1() { }

	private static EqualityComparer CreateComparer() { }

	public abstract bool Equals(T x, T y) { }

	public static EqualityComparer get_Default() { }

	public abstract int GetHashCode(T obj) { }

	internal override int IndexOf(T[] array, T value, int startIndex, int count) { }

	internal override int LastIndexOf(T[] array, T value, int startIndex, int count) { }

	private override bool System.Collections.IEqualityComparer.Equals(object x, object y) { }

	private override int System.Collections.IEqualityComparer.GetHashCode(object obj) { }

}

