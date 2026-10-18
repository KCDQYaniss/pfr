namespace EFT.Hideout;

public struct ScavProductVariation
{
	public int Min; //Field offset: 0x0
	public int Max; //Field offset: 0x4

	public bool Any
	{
		 get { } //Length: 8
	}

	public ScavProductVariation Extend(ScavProductVariation other) { }

	public bool get_Any() { }

}

