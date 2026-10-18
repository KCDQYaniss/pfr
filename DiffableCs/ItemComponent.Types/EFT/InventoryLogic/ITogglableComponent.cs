namespace EFT.InventoryLogic;

public interface ITogglableComponent : IItemComponent
{

	public bool On
	{
		 get { } //Length: 0
	}

	public bool get_On() { }

	public void Toggle() { }

	public void ToggleSilent() { }

}

