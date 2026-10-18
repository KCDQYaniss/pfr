namespace EFT;

public sealed class BarterTemplate
{
	public string _tpl; //Field offset: 0x10
	public double count; //Field offset: 0x18
	public int level; //Field offset: 0x20
	public EDogtagExchangeSide side; //Field offset: 0x24
	public bool onlyFunctional; //Field offset: 0x28

	[JsonIgnore]
	public int IntCount
	{
		 get { } //Length: 96
	}

	public BarterTemplate() { }

	public int get_IntCount() { }

}

