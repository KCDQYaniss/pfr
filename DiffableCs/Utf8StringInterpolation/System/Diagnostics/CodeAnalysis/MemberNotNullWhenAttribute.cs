namespace System.Diagnostics.CodeAnalysis;

[AttributeUsage(192, Inherited = False, AllowMultiple = True)]
[ExcludeFromCodeCoverage]
[Nullable(0)]
[NullableContext(1)]
internal sealed class MemberNotNullWhenAttribute : Attribute
{
	[CompilerGenerated]
	private readonly bool <ReturnValue>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly string[] <Members>k__BackingField; //Field offset: 0x18

	public string[] Members
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public bool ReturnValue
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public MemberNotNullWhenAttribute(bool returnValue, string member) { }

	public MemberNotNullWhenAttribute(bool returnValue, string[] members) { }

	[CompilerGenerated]
	public string[] get_Members() { }

	[CompilerGenerated]
	public bool get_ReturnValue() { }

}

