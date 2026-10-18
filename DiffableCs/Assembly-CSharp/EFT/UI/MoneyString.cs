namespace EFT.UI;

[IsReadOnly]
public struct MoneyString
{
	public readonly string Rubles; //Field offset: 0x0
	public readonly string Euros; //Field offset: 0x8
	public readonly string Dollars; //Field offset: 0x10

	public MoneyString(string rubles, string euros, string dollars) { }

}

