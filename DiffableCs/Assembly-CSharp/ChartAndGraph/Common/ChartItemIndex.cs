namespace ChartAndGraph.Common;

internal struct ChartItemIndex
{
	[CompilerGenerated]
	private int <Group>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private int <Category>k__BackingField; //Field offset: 0x4

	public int Category
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public int Group
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 3
		[CompilerGenerated]
		 set { } //Length: 3
	}

	public ChartItemIndex(int group, int category) { }

	public virtual bool Equals(object obj) { }

	[CompilerGenerated]
	[IsReadOnly]
	public int get_Category() { }

	[CompilerGenerated]
	[IsReadOnly]
	public int get_Group() { }

	public virtual int GetHashCode() { }

	[CompilerGenerated]
	public void set_Category(int value) { }

	[CompilerGenerated]
	public void set_Group(int value) { }

}

