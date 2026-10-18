namespace EFT.Expansions;

public sealed class ExpansionsAccessData
{
	[JsonProperty("id")]
	public string AccessToken; //Field offset: 0x10
	[CompilerGenerated]
	private string <ExpansionsPageUrl>k__BackingField; //Field offset: 0x18

	public string ExpansionsPageUrl
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public ExpansionsAccessData() { }

	[CompilerGenerated]
	public string get_ExpansionsPageUrl() { }

	[CompilerGenerated]
	public void set_ExpansionsPageUrl(string value) { }

}

