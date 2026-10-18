namespace EFT;

public sealed class CharacterSelectionProfileData
{
	[JsonProperty("PlayerVisualRepresentation")]
	private PlayerVisualRepresentationDescriptor _playerVisualRepresentation; //Field offset: 0x10
	[JsonIgnore]
	public PlayerVisualRepresentation PlayerVisualRepresentation; //Field offset: 0x18
	[JsonProperty("status")]
	public ECharacterSelectionProfileStatus Status; //Field offset: 0x20
	[JsonProperty("SeasonalInfo")]
	public CharacterSelectionSeasonInfo SeasonalInfo; //Field offset: 0x28
	[JsonProperty("accountType")]
	public int AccountType; //Field offset: 0x30
	[JsonProperty("aid")]
	public long AccountId; //Field offset: 0x38
	[JsonProperty("gameVersion")]
	public string GameVersion; //Field offset: 0x40
	[JsonProperty("level")]
	public int Level; //Field offset: 0x48
	[JsonProperty("lowerNickname")]
	public string LowerNickname; //Field offset: 0x50
	[JsonProperty("memberCategory")]
	public EMemberCategory MemberCategory; //Field offset: 0x58
	[JsonProperty("nickname")]
	public string Nickname; //Field offset: 0x60
	[JsonProperty("nicknamePref")]
	public string NicknamePrefix; //Field offset: 0x68
	[JsonProperty("prestigeLevel")]
	public int PrestigeLevel; //Field offset: 0x70
	[JsonProperty("side")]
	public EPlayerSide Side; //Field offset: 0x74
	[JsonProperty("uid")]
	public string ProfileId; //Field offset: 0x78
	[JsonProperty("unlockedProductionRecipe")]
	public List UnlockedProductionRecipe; //Field offset: 0x80
	[JsonProperty("unlockedRules")]
	public List UnlockedRules; //Field offset: 0x88
	[JsonProperty("unlockedTraderDialogues")]
	public List UnlockedTraderDialogues; //Field offset: 0x90
	[JsonProperty("unlockedTraders")]
	public List UnlockedTraders; //Field offset: 0x98

	[JsonIgnore]
	public bool HasProfile
	{
		 get { } //Length: 27
	}

	[JsonIgnore]
	public bool IsAvailableForPurchase
	{
		 get { } //Length: 8
	}

	[JsonIgnore]
	public bool IsEmpty
	{
		 get { } //Length: 8
	}

	[JsonIgnore]
	public bool IsLocked
	{
		 get { } //Length: 8
	}

	[JsonIgnore]
	public bool IsSelectable
	{
		 get { } //Length: 17
	}

	public CharacterSelectionProfileData() { }

	public bool get_HasProfile() { }

	public bool get_IsAvailableForPurchase() { }

	public bool get_IsEmpty() { }

	public bool get_IsLocked() { }

	public bool get_IsSelectable() { }

	public bool IsCurrent(string profileId) { }

	[OnDeserialized]
	private void OnJsonDeserialize(StreamingContext context) { }

}

