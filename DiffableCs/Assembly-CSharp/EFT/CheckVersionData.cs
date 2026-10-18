namespace EFT;

public sealed class CheckVersionData
{
	[JsonProperty("isvalid")]
	public bool IsValid; //Field offset: 0x10
	[JsonProperty("latestVersion")]
	public string ActualVersion; //Field offset: 0x18

	public CheckVersionData() { }

}

