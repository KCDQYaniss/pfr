namespace System.Diagnostics.CodeAnalysis;

[AttributeUsage(736, Inherited = False, AllowMultiple = False)]
[Conditional("MULTI_TARGETING_SUPPORT_ATTRIBUTES")]
[ExcludeFromCodeCoverage]
[Nullable(0)]
[NullableContext(2)]
internal sealed class RequiresAssemblyFilesAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string <Message>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <Url>k__BackingField; //Field offset: 0x18

	public string Message
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public string Url
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public RequiresAssemblyFilesAttribute() { }

	[NullableContext(1)]
	public RequiresAssemblyFilesAttribute(string message) { }

	[CompilerGenerated]
	public string get_Message() { }

	[CompilerGenerated]
	public string get_Url() { }

	[CompilerGenerated]
	public void set_Url(string value) { }

}

