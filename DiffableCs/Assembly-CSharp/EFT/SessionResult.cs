namespace EFT;

public sealed class SessionResult
{
	[JsonProperty("profile")]
	public UnparsedData profile; //Field offset: 0x10
	[JsonProperty("result")]
	public ExitStatus result; //Field offset: 0x18
	[JsonProperty("killerId")]
	public string killerId; //Field offset: 0x20
	[JsonProperty("killerAid")]
	public string killerAid; //Field offset: 0x28
	[JsonProperty("exitName")]
	public string exitName; //Field offset: 0x30
	[JsonProperty("inSession")]
	public bool inSession; //Field offset: 0x38
	[JsonProperty("favorite")]
	public bool favorite; //Field offset: 0x39
	[JsonProperty("playTime")]
	public int playTime; //Field offset: 0x3C
	[JsonIgnore]
	public InsuredProfileItems[] InsuredItems; //Field offset: 0x40
	[JsonIgnore]
	public string ProfileId; //Field offset: 0x48

	public SessionResult() { }

}

