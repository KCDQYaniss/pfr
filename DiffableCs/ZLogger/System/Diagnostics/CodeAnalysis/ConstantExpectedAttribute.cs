namespace System.Diagnostics.CodeAnalysis;

[AttributeUsage(AttributeTargets::Parameter (2048), Inherited = False)]
[Nullable(0)]
[NullableContext(2)]
public sealed class ConstantExpectedAttribute : Attribute
{
	[CompilerGenerated]
	private object <Min>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private object <Max>k__BackingField; //Field offset: 0x18

	public object Max
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public object Min
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public ConstantExpectedAttribute() { }

	[CompilerGenerated]
	public object get_Max() { }

	[CompilerGenerated]
	public object get_Min() { }

	[CompilerGenerated]
	public void set_Max(object value) { }

	[CompilerGenerated]
	public void set_Min(object value) { }

}

