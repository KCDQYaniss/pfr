namespace System;

[AttributeUsage(6140, Inherited = False)]
internal sealed class ObsoleteAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string <Message>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly bool <IsError>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <DiagnosticId>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private string <UrlFormat>k__BackingField; //Field offset: 0x28

	public string DiagnosticId
	{
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public string UrlFormat
	{
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public ObsoleteAttribute(string message) { }

	public ObsoleteAttribute(string message, bool error) { }

	[CompilerGenerated]
	public void set_DiagnosticId(string value) { }

	[CompilerGenerated]
	public void set_UrlFormat(string value) { }

}

