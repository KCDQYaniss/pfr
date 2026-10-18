namespace EFT;

public interface IExchangeable
{

	public int BuyRestrictionCurrent
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public int BuyRestrictionMax
	{
		 get { } //Length: 0
	}

	public int CurrentItemCount
	{
		 get { } //Length: 0
	}

	public DateTime EndTime
	{
		 get { } //Length: 0
	}

	public string Id
	{
		 get { } //Length: 0
	}

	[JsonIgnore]
	public Item Item
	{
		 get { } //Length: 0
	}

	public EMemberCategory MemberType
	{
		 get { } //Length: 0
	}

	public bool OnlyMoney
	{
		 get { } //Length: 0
	}

	[JsonIgnore]
	public IExchangeRequirement[] Requirements
	{
		 get { } //Length: 0
	}

	public bool SellInOnePiece
	{
		 get { } //Length: 0
	}

	public int get_BuyRestrictionCurrent() { }

	public int get_BuyRestrictionMax() { }

	public int get_CurrentItemCount() { }

	public DateTime get_EndTime() { }

	public string get_Id() { }

	public Item get_Item() { }

	public EMemberCategory get_MemberType() { }

	public bool get_OnlyMoney() { }

	public IExchangeRequirement[] get_Requirements() { }

	public bool get_SellInOnePiece() { }

	public void set_BuyRestrictionCurrent(int value) { }

}

