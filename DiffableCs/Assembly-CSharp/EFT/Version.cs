namespace EFT;

public sealed class Version
{
	[JsonProperty("major")]
	public string Major; //Field offset: 0x10
	[JsonProperty("minor")]
	public string Minor; //Field offset: 0x18
	[JsonProperty("game")]
	public string Game; //Field offset: 0x20
	[JsonProperty("backend")]
	public string Backend; //Field offset: 0x28
	[JsonProperty("taxonomy")]
	public string Taxonomy; //Field offset: 0x30

	public static Version Current
	{
		 get { } //Length: 135
	}

	public Version() { }

	public static Version Create(string major = "1.2.5.0.48146", string minor = "", string backend = "6", string taxonomy = "341") { }

	public static Version get_Current() { }

	public virtual string ToString() { }

}

