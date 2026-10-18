namespace EFT.InventoryLogic;

public interface IResourceComponent : IItemComponent
{

	public float MaxResource
	{
		 get { } //Length: 0
	}

	public float Value
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public float get_MaxResource() { }

	public float get_Value() { }

	public void set_Value(float value) { }

}

