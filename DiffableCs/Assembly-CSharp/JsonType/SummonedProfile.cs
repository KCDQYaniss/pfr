namespace JsonType;

public sealed class SummonedProfile
{
	[JsonProperty("profile")]
	private ProfileDescriptor _profileDescriptor; //Field offset: 0x10
	private Profile _profile; //Field offset: 0x18
	[JsonProperty("profileToken")]
	public string ProfileToken; //Field offset: 0x20
	[JsonProperty("group")]
	public string GroupId; //Field offset: 0x28
	[JsonProperty("team")]
	public string TeamId; //Field offset: 0x30
	[JsonProperty("entryPoint")]
	public string EntryPoint; //Field offset: 0x38
	[JsonProperty("keyId")]
	public string KeyId; //Field offset: 0x40
	[JsonProperty("repeatableQuests")]
	public QuestTemplate[] RepeatableQuests; //Field offset: 0x48
	[JsonProperty("transitionType")]
	public ELocationTransition transitionType; //Field offset: 0x50
	[JsonProperty("transitionRaidId")]
	public string transitionRaidId; //Field offset: 0x58
	[JsonProperty("transitionCount")]
	public int transitionCount; //Field offset: 0x60
	[JsonProperty("visitedLocations")]
	public string[] visitedLocations; //Field offset: 0x68
	[JsonProperty("karmaValue")]
	public float KarmaValue; //Field offset: 0x70

	[JsonIgnore]
	public Profile Profile
	{
		 get { } //Length: 191
	}

	public SummonedProfile() { }

	public Profile get_Profile() { }

	public bool ShouldApplyTransit() { }

}

