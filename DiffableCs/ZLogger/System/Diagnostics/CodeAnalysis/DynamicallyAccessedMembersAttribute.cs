namespace System.Diagnostics.CodeAnalysis;

[AttributeUsage(28108, Inherited = False)]
[Conditional("MULTI_TARGETING_SUPPORT_ATTRIBUTES")]
[ExcludeFromCodeCoverage]
internal sealed class DynamicallyAccessedMembersAttribute : Attribute
{
	[CompilerGenerated]
	private readonly DynamicallyAccessedMemberTypes <MemberTypes>k__BackingField; //Field offset: 0x10

	public DynamicallyAccessedMemberTypes MemberTypes
	{
		[CompilerGenerated]
		 get { } //Length: 164
	}

	public DynamicallyAccessedMembersAttribute(DynamicallyAccessedMemberTypes memberTypes) { }

	[CompilerGenerated]
	public DynamicallyAccessedMemberTypes get_MemberTypes() { }

}

