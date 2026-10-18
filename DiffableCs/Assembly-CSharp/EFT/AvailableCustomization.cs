namespace EFT;

public sealed class AvailableCustomization
{
	[CompilerGenerated]
	private readonly MongoID <Id>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly ECustomizationType <Type>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly ECustomizationSource <Source>k__BackingField; //Field offset: 0x2C

	[JsonProperty("id")]
	public MongoID Id
	{
		[CompilerGenerated]
		 get { } //Length: 21
	}

	[JsonProperty("source")]
	public ECustomizationSource Source
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	[JsonProperty("type")]
	public ECustomizationType Type
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	[JsonConstructor]
	public AvailableCustomization(MongoID id, ECustomizationType type, ECustomizationSource source = 4) { }

	public virtual bool Equals(object otherObject) { }

	[CompilerGenerated]
	public MongoID get_Id() { }

	[CompilerGenerated]
	public ECustomizationSource get_Source() { }

	[CompilerGenerated]
	public ECustomizationType get_Type() { }

	public virtual int GetHashCode() { }

}

