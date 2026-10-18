namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets::Method (64), AllowMultiple = False, Inherited = False)]
[Conditional("MULTI_TARGETING_SUPPORT_ATTRIBUTES")]
[ExcludeFromCodeCoverage]
[Nullable(0)]
[NullableContext(2)]
internal sealed class UnsafeAccessorAttribute : Attribute
{
	[CompilerGenerated]
	private readonly UnsafeAccessorKind <Kind>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <Name>k__BackingField; //Field offset: 0x18

	public UnsafeAccessorKind Kind
	{
		[CompilerGenerated]
		 get { } //Length: 164
	}

	public string Name
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public UnsafeAccessorAttribute(UnsafeAccessorKind kind) { }

	[CompilerGenerated]
	public UnsafeAccessorKind get_Kind() { }

	[CompilerGenerated]
	public string get_Name() { }

	[CompilerGenerated]
	public void set_Name(string value) { }

}

