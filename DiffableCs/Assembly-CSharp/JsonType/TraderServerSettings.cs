namespace JsonType;

public class TraderServerSettings
{
	[JsonProperty("TraderServices")]
	private readonly Dictionary _servicesData; //Field offset: 0x10

	public IReadOnlyDictionary ServicesData
	{
		 get { } //Length: 5
	}

	public TraderServerSettings() { }

	public IReadOnlyDictionary get_ServicesData() { }

}

