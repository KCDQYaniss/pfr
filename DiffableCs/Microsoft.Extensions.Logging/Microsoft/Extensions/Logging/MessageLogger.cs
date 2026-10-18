namespace Microsoft.Extensions.Logging;

[IsReadOnly]
internal struct MessageLogger
{
	[CompilerGenerated]
	private readonly ILogger <Logger>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly string <Category>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private readonly string <ProviderTypeFullName>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly Nullable <MinLevel>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly Func <Filter>k__BackingField; //Field offset: 0x20

	public string Category
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public Func Filter
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public ILogger Logger
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public Nullable MinLevel
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	private string ProviderTypeFullName
	{
		[CompilerGenerated]
		private get { } //Length: 5
	}

	public MessageLogger(ILogger logger, string category, string providerTypeFullName, Nullable minLevel, Func filter) { }

	[CompilerGenerated]
	public string get_Category() { }

	[CompilerGenerated]
	public Func get_Filter() { }

	[CompilerGenerated]
	public ILogger get_Logger() { }

	[CompilerGenerated]
	public Nullable get_MinLevel() { }

	[CompilerGenerated]
	private string get_ProviderTypeFullName() { }

	public bool IsEnabled(LogLevel level) { }

}

