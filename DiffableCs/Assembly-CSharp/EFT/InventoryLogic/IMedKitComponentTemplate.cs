namespace EFT.InventoryLogic;

public interface IMedKitComponentTemplate
{

	public EBodyPart[] BodyPartPriority
	{
		 get { } //Length: 0
	}

	public float HpResourceRate
	{
		 get { } //Length: 0
	}

	public int MaxHpResource
	{
		 get { } //Length: 0
	}

	public EBodyPart[] get_BodyPartPriority() { }

	public float get_HpResourceRate() { }

	public int get_MaxHpResource() { }

}

