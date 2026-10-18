namespace EFT.UI.Chat;

public class FriendsRequestResponse
{
	[JsonProperty("requestId")]
	public string RequestId; //Field offset: 0x10
	[JsonProperty("retryAfter")]
	public int RetryAfter; //Field offset: 0x18
	[JsonProperty("status")]
	public EBackendErrorCode Error; //Field offset: 0x1C

	public FriendsRequestResponse() { }

}

