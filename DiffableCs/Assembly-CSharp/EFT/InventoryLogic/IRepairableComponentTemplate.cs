namespace EFT.InventoryLogic;

public interface IRepairableComponentTemplate
{

	public int Durability
	{
		 get { } //Length: 0
	}

	public int MaxDurability
	{
		 get { } //Length: 0
	}

	public float MaxRepairDegradation
	{
		 get { } //Length: 0
	}

	public float MaxRepairKitDegradation
	{
		 get { } //Length: 0
	}

	public float MinRepairDegradation
	{
		 get { } //Length: 0
	}

	public float MinRepairKitDegradation
	{
		 get { } //Length: 0
	}

	public int get_Durability() { }

	public int get_MaxDurability() { }

	public float get_MaxRepairDegradation() { }

	public float get_MaxRepairKitDegradation() { }

	public float get_MinRepairDegradation() { }

	public float get_MinRepairKitDegradation() { }

}

