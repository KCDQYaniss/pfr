namespace EFT.NetworkPackets;

[DefaultMember("Item")]
public struct OneAndList`1 : IEquatable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__8_0; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal string <ToString>b__8_0(T x) { }

	}

	private Nullable _firstValue; //Field offset: 0x0
	private List _list; //Field offset: 0x0

	public T Item
	{
		 get { } //Length: 500
	}

	public int Length
	{
		 get { } //Length: 113
	}

	public OneAndList`1(T value) { }

	public void Add(T item) { }

	public override bool Equals(OneAndList other) { }

	public virtual bool Equals(object obj) { }

	public T get_Item(int index) { }

	public int get_Length() { }

	public virtual int GetHashCode() { }

	public string ToShortString() { }

	public virtual string ToString() { }

}

