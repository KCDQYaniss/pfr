namespace EFT.Console.Core;

public struct AutoCompleteItem
{
	public string Description; //Field offset: 0x0
	public string Title; //Field offset: 0x8
	public string Result; //Field offset: 0x10

	public virtual bool Equals(object obj) { }

	private bool Equals(AutoCompleteItem other) { }

	public virtual int GetHashCode() { }

}

