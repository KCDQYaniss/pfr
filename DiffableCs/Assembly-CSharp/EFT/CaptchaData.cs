namespace EFT;

public sealed class CaptchaData
{
	[JsonProperty("code")]
	public string Code; //Field offset: 0x10
	[JsonProperty("items")]
	public string[] Items; //Field offset: 0x18
	[JsonProperty("title")]
	public string Title; //Field offset: 0x20
	[JsonProperty("description")]
	public string Description; //Field offset: 0x28
	[JsonProperty("type")]
	public string Type; //Field offset: 0x30

	public CaptchaData() { }

}

