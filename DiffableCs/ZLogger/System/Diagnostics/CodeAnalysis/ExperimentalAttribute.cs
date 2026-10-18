namespace System.Diagnostics.CodeAnalysis;

[AttributeUsage(6143, Inherited = False)]
[ExcludeFromCodeCoverage]
[Nullable(0)]
[NullableContext(1)]
internal sealed class ExperimentalAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string <DiagnosticId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[Nullable(2)]
	private string <UrlFormat>k__BackingField; //Field offset: 0x18

	public string DiagnosticId
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	[Nullable(2)]
	public string UrlFormat
	{
		[CompilerGenerated]
		[NullableContext(2)]
		 get { } //Length: 5
		[CompilerGenerated]
		[NullableContext(2)]
		 set { } //Length: 82
	}

	public ExperimentalAttribute(string diagnosticId) { }

	[CompilerGenerated]
	public string get_DiagnosticId() { }

	[CompilerGenerated]
	[NullableContext(2)]
	public string get_UrlFormat() { }

	[CompilerGenerated]
	[NullableContext(2)]
	public void set_UrlFormat(string value) { }

}

