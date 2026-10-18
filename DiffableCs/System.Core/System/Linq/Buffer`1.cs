namespace System.Linq;

internal struct Buffer`1
{
	internal TElement[] items; //Field offset: 0x0
	internal int count; //Field offset: 0x0

	internal Buffer`1(IEnumerable source) { }

	internal TElement[] ToArray() { }

}

