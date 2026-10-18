namespace EFT.InventoryLogic;

public interface IKeyComponentTemplate
{

	public string KeyId
	{
		 get { } //Length: 0
	}

	public int MaximumNumberOfUsage
	{
		 get { } //Length: 0
	}

	public string get_KeyId() { }

	public int get_MaximumNumberOfUsage() { }

}

