namespace EFT.Hideout;

public sealed class ScavCaseScheme : BaseHideoutScheme
{
	[JsonProperty("endProducts")]
	public ScavProduct endProducts; //Field offset: 0x50

	public virtual EOwnerType SchemeOwnerType
	{
		 get { } //Length: 6
	}

	public ScavCaseScheme() { }

	public virtual EOwnerType get_SchemeOwnerType() { }

}

