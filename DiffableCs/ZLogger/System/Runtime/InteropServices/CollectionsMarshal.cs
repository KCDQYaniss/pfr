namespace System.Runtime.InteropServices;

internal static class CollectionsMarshal
{
	private class ListDummy`1
	{
		[Nullable(1)]
		public T[] Items; //Field offset: 0x0
		private int size; //Field offset: 0x0
		private int version; //Field offset: 0x0

		public ListDummy`1() { }

	}


	[NullableContext(1)]
	internal static Span AsSpan(List list) { }

}

