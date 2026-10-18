namespace EFT;

public interface IExchangeRequirement
{

	public int IntCount
	{
		 get { } //Length: 0
	}

	public bool IsEncoded
	{
		 get { } //Length: 0
	}

	public bool IsSpawnedInSession
	{
		 get { } //Length: 0
	}

	public Item Item
	{
		 get { } //Length: 0
	}

	public string ItemName
	{
		 get { } //Length: 0
	}

	public bool OnlyFunctional
	{
		 get { } //Length: 0
	}

	public double PreciseCount
	{
		 get { } //Length: 0
	}

	public string TemplateId
	{
		 get { } //Length: 0
	}

	public int get_IntCount() { }

	public bool get_IsEncoded() { }

	public bool get_IsSpawnedInSession() { }

	public Item get_Item() { }

	public string get_ItemName() { }

	public bool get_OnlyFunctional() { }

	public double get_PreciseCount() { }

	public string get_TemplateId() { }

}

