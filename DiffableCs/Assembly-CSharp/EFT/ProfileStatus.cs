namespace EFT;

public sealed class ProfileStatus
{
	private static readonly Dictionary _badTransitions; //Field offset: 0x0
	[JsonProperty("profileid")]
	public string profileid; //Field offset: 0x10
	[JsonProperty("profileToken")]
	public string profileToken; //Field offset: 0x18
	[JsonProperty("status")]
	public EProfileStatus status; //Field offset: 0x20
	[JsonProperty("raidMode")]
	public ERaidMode raidMode; //Field offset: 0x24
	[JsonProperty("ip")]
	public string ip; //Field offset: 0x28
	[JsonProperty("port")]
	public int port; //Field offset: 0x30
	[JsonProperty("location")]
	public string location; //Field offset: 0x38
	[JsonProperty("sid")]
	public string sid; //Field offset: 0x40
	[JsonProperty("mode")]
	public string gameMode; //Field offset: 0x48
	[JsonProperty("shortId")]
	public string shortId; //Field offset: 0x50

	private static ProfileStatus() { }

	public ProfileStatus() { }

	public bool IsAppropriateStatusChange(EProfileStatus newValue) { }

	public virtual string ToString() { }

}

