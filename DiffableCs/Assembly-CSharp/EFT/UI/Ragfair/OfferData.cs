namespace EFT.UI.Ragfair;

public sealed class OfferData : Data
{
	public Handbook Handbook; //Field offset: 0x18
	public string ProfileId; //Field offset: 0x20
	public Offer Offer; //Field offset: 0x28
	public TraderInfo TraderInfo; //Field offset: 0x30
	public ItemUiContext ItemUiContext; //Field offset: 0x38
	public RagFair Ragfair; //Field offset: 0x40
	public InventoryController InventoryController; //Field offset: 0x48
	public InsuranceCompany InsuranceCompany; //Field offset: 0x50
	public SocialNetwork SocialNetwork; //Field offset: 0x58
	public Action OnRenew; //Field offset: 0x60
	public Action OnPurchase; //Field offset: 0x68
	public Action OnExpired; //Field offset: 0x70
	public Action OnRemove; //Field offset: 0x78

	public virtual ERagFairOfferDataType DataType
	{
		 get { } //Length: 3
	}

	public OfferData() { }

	public virtual ERagFairOfferDataType get_DataType() { }

}

