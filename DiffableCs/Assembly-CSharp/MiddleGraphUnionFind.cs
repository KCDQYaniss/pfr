//Type is in global namespace

internal sealed class MiddleGraphUnionFind
{
	private readonly int[] _parent; //Field offset: 0x10
	private readonly int[] _rank; //Field offset: 0x18
	[CompilerGenerated]
	private int <ComponentCount>k__BackingField; //Field offset: 0x20

	public private int ComponentCount
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public MiddleGraphUnionFind(int n) { }

	public int Find(int x) { }

	[CompilerGenerated]
	public int get_ComponentCount() { }

	[CompilerGenerated]
	private void set_ComponentCount(int value) { }

	public void Union(int a, int b) { }

}

