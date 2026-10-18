namespace JsonType;

public sealed class LoginDataResponse
{
	public bool queued; //Field offset: 0x10
	public double banTime; //Field offset: 0x18
	public string hash; //Field offset: 0x20
	public string lang; //Field offset: 0x28
	public string aid; //Field offset: 0x30
	public string token; //Field offset: 0x38
	public string taxonomy; //Field offset: 0x40
	public string activeProfileId; //Field offset: 0x48
	public string nickname; //Field offset: 0x50
	public double utc_time; //Field offset: 0x58
	public BackendUrls backend; //Field offset: 0x60
	public long totalInGame; //Field offset: 0x68
	public bool reportAvailable; //Field offset: 0x70
	public Dictionary purchasedGames; //Field offset: 0x78
	public bool isGameSynced; //Field offset: 0x80
	public ELinkedPlatform[] linkedPlatforms; //Field offset: 0x88
	public Dictionary availableGameModes; //Field offset: 0x90

	public LoginDataResponse() { }

}

