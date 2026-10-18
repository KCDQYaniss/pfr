namespace System.Collections.Generic;

[TypeDependency("System.Collections.Generic.ObjectComparer`1")]
public abstract class Comparer`1 : IComparer, IComparer
{
	private static Comparer defaultComparer; //Field offset: 0x0

	public static Comparer Default
	{
		 get { } //Length: 335
	}

	protected Comparer`1() { }

	public abstract int Compare(T x, T y) { }

	public static Comparer Create(Comparison comparison) { }

	private static Comparer CreateComparer() { }

	public static Comparer get_Default() { }

	private override int System.Collections.IComparer.Compare(object x, object y) { }

}

