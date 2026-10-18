namespace Microsoft.Extensions.Logging;

[IsReadOnly]
internal struct LoggerInformation
{
	[CompilerGenerated]
	private readonly ILogger <Logger>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly string <Category>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private readonly Type <ProviderType>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly bool <ExternalScope>k__BackingField; //Field offset: 0x18

	public string Category
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public bool ExternalScope
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public ILogger Logger
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public Type ProviderType
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public LoggerInformation(ILoggerProvider provider, string category) { }

	[CompilerGenerated]
	public string get_Category() { }

	[CompilerGenerated]
	public bool get_ExternalScope() { }

	[CompilerGenerated]
	public ILogger get_Logger() { }

	[CompilerGenerated]
	public Type get_ProviderType() { }

}

