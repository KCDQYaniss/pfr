namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal sealed class ExprArrayInit : ExprWithType
{
	[CompilerGenerated]
	private Expr <OptionalArguments>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private Expr <OptionalArgumentDimensions>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private readonly int[] <DimensionSizes>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private int <DimensionSize>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private bool <GeneratedForParamArray>k__BackingField; //Field offset: 0x5C

	public int DimensionSize
	{
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public int[] DimensionSizes
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public bool GeneratedForParamArray
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public Expr OptionalArgumentDimensions
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public Expr OptionalArguments
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public ExprArrayInit(CType type, Expr arguments, Expr argumentDimensions, int[] dimensionSizes, int dimensionSize) { }

	[CompilerGenerated]
	public int[] get_DimensionSizes() { }

	[CompilerGenerated]
	public bool get_GeneratedForParamArray() { }

	[CompilerGenerated]
	public Expr get_OptionalArgumentDimensions() { }

	[CompilerGenerated]
	public Expr get_OptionalArguments() { }

	[CompilerGenerated]
	public void set_DimensionSize(int value) { }

	[CompilerGenerated]
	public void set_GeneratedForParamArray(bool value) { }

	[CompilerGenerated]
	public void set_OptionalArgumentDimensions(Expr value) { }

	[CompilerGenerated]
	public void set_OptionalArguments(Expr value) { }

}

