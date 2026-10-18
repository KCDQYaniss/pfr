namespace EFT;

public class GroupPlayer : IProfileDataContainer
{
	[JsonProperty("aid")]
	public string AccountId; //Field offset: 0x10
	[JsonProperty("_id")]
	public string Id; //Field offset: 0x18
	[JsonProperty("lookingGroup")]
	public bool LookingForGroup; //Field offset: 0x20
	[JsonProperty("IsLeader")]
	public bool IsLeader; //Field offset: 0x21
	[JsonProperty("IsReady")]
	public bool IsReady; //Field offset: 0x22
	[JsonProperty("Info")]
	public PlayerInfo Info; //Field offset: 0x28
	[CanBeNull]
	[JsonProperty("PlayerVisualRepresentation")]
	private PlayerVisualRepresentationDescriptor _playerVisualRepresentation; //Field offset: 0x30
	[CanBeNull]
	[JsonIgnore]
	public PlayerVisualRepresentation PlayerVisualRepresentation; //Field offset: 0x38

	private override string EFT.IProfileDataContainer.Nickname
	{
		private get { } //Length: 27
	}

	private override int EFT.IProfileDataContainer.PrestigeLevel
	{
		private get { } //Length: 26
	}

	private override string EFT.IProfileDataContainer.ProfileId
	{
		private get { } //Length: 5
	}

	private override EPlayerSide EFT.IProfileDataContainer.Side
	{
		private get { } //Length: 26
	}

	public GroupPlayer() { }

	private override string EFT.IProfileDataContainer.get_Nickname() { }

	private override int EFT.IProfileDataContainer.get_PrestigeLevel() { }

	private override string EFT.IProfileDataContainer.get_ProfileId() { }

	private override EPlayerSide EFT.IProfileDataContainer.get_Side() { }

	[OnDeserialized]
	private void OnJSONDeserialize(StreamingContext context) { }

	[OnSerializing]
	private void OnJSONSerialize(StreamingContext context) { }

}

