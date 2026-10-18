//Type is in global namespace

public class MiddleGraphWay
{
	[CompilerGenerated]
	private readonly MiddleGraphPoint <From>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly MiddleGraphPoint <To>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private MiddleGraphWay <Reverse>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly float <BaseCost>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private float <Cost>k__BackingField; //Field offset: 0x2C

	public float BaseCost
	{
		[CompilerGenerated]
		 get { } //Length: 6
	}

	public float Cost
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public MiddleGraphPoint From
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public internal MiddleGraphWay Reverse
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 82
	}

	public MiddleGraphPoint To
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public MiddleGraphWay(MiddleGraphPoint from, MiddleGraphPoint to, float baseCost) { }

	[CompilerGenerated]
	public float get_BaseCost() { }

	[CompilerGenerated]
	public float get_Cost() { }

	[CompilerGenerated]
	public MiddleGraphPoint get_From() { }

	[CompilerGenerated]
	public MiddleGraphWay get_Reverse() { }

	[CompilerGenerated]
	public MiddleGraphPoint get_To() { }

	internal void ResetCost() { }

	[CompilerGenerated]
	public void set_Cost(float value) { }

	[CompilerGenerated]
	internal void set_Reverse(MiddleGraphWay value) { }

}

