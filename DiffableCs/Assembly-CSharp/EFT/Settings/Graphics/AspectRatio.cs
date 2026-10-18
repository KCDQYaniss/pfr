namespace EFT.Settings.Graphics;

public struct AspectRatio : IEquatable
{
	[CompilerGenerated]
	private int <X>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private int <Y>k__BackingField; //Field offset: 0x4

	[JsonIgnore]
	public float Division
	{
		 get { } //Length: 20
	}

	public private int X
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 3
		[CompilerGenerated]
		private set { } //Length: 3
	}

	public private int Y
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public AspectRatio(int x, int y) { }

	public override bool Equals(AspectRatio other) { }

	public virtual bool Equals(object obj) { }

	public float get_Division() { }

	[CompilerGenerated]
	[IsReadOnly]
	public int get_X() { }

	[CompilerGenerated]
	[IsReadOnly]
	public int get_Y() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(AspectRatio value1, AspectRatio value2) { }

	public static bool op_Inequality(AspectRatio value1, AspectRatio value2) { }

	[CompilerGenerated]
	private void set_X(int value) { }

	[CompilerGenerated]
	private void set_Y(int value) { }

	public virtual string ToString() { }

}

