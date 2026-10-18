namespace System.Runtime.Versioning;

[AttributeUsage(2047, AllowMultiple = True, Inherited = False)]
[Conditional("MULTI_TARGETING_SUPPORT_ATTRIBUTES")]
[ExcludeFromCodeCoverage]
[Nullable(0)]
[NullableContext(2)]
internal sealed class ObsoletedOSPlatformAttribute : Attribute
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

	[NullableContext(1)]
	public ObsoletedOSPlatformAttribute(string platformName) { }

	[NullableContext(1)]
	public ObsoletedOSPlatformAttribute(string platformName, string message) { }

	[CompilerGenerated]
	public string get_Message() { }

	[CompilerGenerated]
	public string get_Url() { }

	[CompilerGenerated]
	public void set_Url(string value) { }

}

