namespace EFT.InventoryLogic;

public interface IRelativeComponent : IItemComponent
{

	public float RelativeValue
	{
		 get { } //Length: 0
	}

	public float get_RelativeValue() { }

}

