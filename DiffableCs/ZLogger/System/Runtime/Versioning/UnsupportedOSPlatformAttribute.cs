namespace System.Runtime.Versioning;

[AttributeUsage(2047, AllowMultiple = True, Inherited = False)]
[Conditional("MULTI_TARGETING_SUPPORT_ATTRIBUTES")]
[ExcludeFromCodeCoverage]
[Nullable(0)]
[NullableContext(2)]
internal sealed class UnsupportedOSPlatformAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string <Message>k__BackingField; //Field offset: 0x10

	public string Message
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	[NullableContext(1)]
	public UnsupportedOSPlatformAttribute(string platformName) { }

	[NullableContext(1)]
	public UnsupportedOSPlatformAttribute(string platformName, string message) { }

	[CompilerGenerated]
	public string get_Message() { }

}

