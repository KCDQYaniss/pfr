namespace System.Diagnostics.CodeAnalysis;

[AttributeUsage(AttributeTargets::All (32767), Inherited = False, AllowMultiple = True)]
internal sealed class UnconditionalSuppressMessageAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string <Category>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly string <CheckId>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <Justification>k__BackingField; //Field offset: 0x20

	public string Justification
	{
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public UnconditionalSuppressMessageAttribute(string category, string checkId) { }

	[CompilerGenerated]
	public void set_Justification(string value) { }

}

