namespace EFT;

public sealed class HideoutInfo
{
	[JsonProperty("Production")]
	public Dictionary Production; //Field offset: 0x10
	[JsonProperty("Improvements")]
	public Dictionary Improvements; //Field offset: 0x18
	[JsonProperty("Areas")]
	public AreaInfo[] Areas; //Field offset: 0x20
	[JsonProperty("Seed")]
	public string RawSeed; //Field offset: 0x28
	[JsonProperty("Customization")]
	public Dictionary GlobalCustomization; //Field offset: 0x30
	[JsonProperty("MannequinPoses")]
	public Dictionary MannequinPoses; //Field offset: 0x38
	[CompilerGenerated]
	private Seed <Seed>k__BackingField; //Field offset: 0x40

	[JsonIgnore]
	public private Seed Seed
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public HideoutInfo() { }

	[CompilerGenerated]
	public Seed get_Seed() { }

	[OnDeserialized]
	private void OnDeserializing(StreamingContext context) { }

	[CompilerGenerated]
	private void set_Seed(Seed value) { }

}

