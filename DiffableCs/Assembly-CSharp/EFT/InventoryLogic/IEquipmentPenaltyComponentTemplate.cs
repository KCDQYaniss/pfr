namespace EFT.InventoryLogic;

public interface IEquipmentPenaltyComponentTemplate
{

	public float MousePenalty
	{
		 get { } //Length: 0
	}

	public float SpeedPenaltyPercent
	{
		 get { } //Length: 0
	}

	public float WeaponErgonomicPenalty
	{
		 get { } //Length: 0
	}

	public float get_MousePenalty() { }

	public float get_SpeedPenaltyPercent() { }

	public float get_WeaponErgonomicPenalty() { }

}

