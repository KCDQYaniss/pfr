namespace EFT;

public class ServiceRequirements
{
	[CompilerGenerated]
	private GlobalsArray <CompletedQuests>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private GlobalsDictionary <Standings>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private ESideType <SideType>k__BackingField; //Field offset: 0x20

	[JsonProperty("CompletedQuests")]
	public private GlobalsArray CompletedQuests
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	[JsonProperty("Side")]
	public private ESideType SideType
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	[JsonProperty("Standings")]
	public private GlobalsDictionary Standings
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public ServiceRequirements() { }

	[CompilerGenerated]
	public GlobalsArray get_CompletedQuests() { }

	[CompilerGenerated]
	public ESideType get_SideType() { }

	[CompilerGenerated]
	public GlobalsDictionary get_Standings() { }

	[CompilerGenerated]
	private void set_CompletedQuests(GlobalsArray value) { }

	[CompilerGenerated]
	private void set_SideType(ESideType value) { }

	[CompilerGenerated]
	private void set_Standings(GlobalsDictionary value) { }

}

