namespace EFT.Hideout;

public sealed class ScavProduct
{
	public ScavProductVariation Common; //Field offset: 0x10
	public ScavProductVariation Rare; //Field offset: 0x18
	public ScavProductVariation Superrare; //Field offset: 0x20

	public ScavProductVariation Total
	{
		 get { } //Length: 127
	}

	public ScavProduct() { }

	public ScavProductVariation get_Total() { }

}

