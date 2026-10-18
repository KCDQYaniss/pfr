namespace System.Collections.Generic;

internal class ComparisonComparer`1 : Comparer
{
	private readonly Comparison _comparison; //Field offset: 0x0

	public ComparisonComparer`1(Comparison comparison) { }

	public virtual int Compare(T x, T y) { }

}

