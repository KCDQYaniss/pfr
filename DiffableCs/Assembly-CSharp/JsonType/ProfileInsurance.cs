namespace JsonType;

public class ProfileInsurance
{
	[JsonProperty("insuredItems")]
	public InsuredProfileItems[] insuredItems; //Field offset: 0x10

	public ProfileInsurance() { }

}

