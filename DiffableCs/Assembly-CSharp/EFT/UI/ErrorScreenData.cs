namespace EFT.UI;

public sealed class ErrorScreenData
{
	public string header; //Field offset: 0x10
	public string message; //Field offset: 0x18
	public Action acceptCallback; //Field offset: 0x20

	public ErrorScreenData() { }

}

