namespace System.Diagnostics.CodeAnalysis;

[AttributeUsage(192, Inherited = False, AllowMultiple = True)]
[ExcludeFromCodeCoverage]
[Nullable(0)]
[NullableContext(1)]
internal sealed class MemberNotNullAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string[] <Members>k__BackingField; //Field offset: 0x10

	public string[] Members
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public MemberNotNullAttribute(string member) { }

	public MemberNotNullAttribute(string[] members) { }

	[CompilerGenerated]
	public string[] get_Members() { }

}

