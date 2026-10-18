namespace System.Diagnostics.CodeAnalysis;

[AttributeUsage(100, Inherited = False)]
[Conditional("MULTI_TARGETING_SUPPORT_ATTRIBUTES")]
[ExcludeFromCodeCoverage]
[Nullable(0)]
[NullableContext(1)]
internal sealed class RequiresDynamicCodeAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string <Message>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[Nullable(2)]
	private string <Url>k__BackingField; //Field offset: 0x18

	public string Message
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	[Nullable(2)]
	public string Url
	{
		[CompilerGenerated]
		[NullableContext(2)]
		 get { } //Length: 5
		[CompilerGenerated]
		[NullableContext(2)]
		 set { } //Length: 82
	}

	public RequiresDynamicCodeAttribute(string message) { }

	[CompilerGenerated]
	public string get_Message() { }

	[CompilerGenerated]
	[NullableContext(2)]
	public string get_Url() { }

	[CompilerGenerated]
	[NullableContext(2)]
	public void set_Url(string value) { }

}

