namespace EFT.InventoryLogic;

public interface IWeapon
{

	public Slot[] Chambers
	{
		 get { } //Length: 0
	}

	public bool IsUnderbarrelWeapon
	{
		 get { } //Length: 0
	}

	public Item Item
	{
		 get { } //Length: 0
	}

	public MalfunctionState MalfState
	{
		 get { } //Length: 0
	}

	public float RecoilBase
	{
		 get { } //Length: 0
	}

	public float RecoilDelta
	{
		 get { } //Length: 0
	}

	public float RecoilForceBack
	{
		 get { } //Length: 0
	}

	public float SpeedFactor
	{
		 get { } //Length: 0
	}

	public float TotalWeight
	{
		 get { } //Length: 0
	}

	public WeaponTemplate WeaponTemplate
	{
		 get { } //Length: 0
	}

	public Slot[] get_Chambers() { }

	public bool get_IsUnderbarrelWeapon() { }

	public Item get_Item() { }

	public MalfunctionState get_MalfState() { }

	public float get_RecoilBase() { }

	public float get_RecoilDelta() { }

	public float get_RecoilForceBack() { }

	public float get_SpeedFactor() { }

	public float get_TotalWeight() { }

	public WeaponTemplate get_WeaponTemplate() { }

	public int GetCurrentMagazineCount() { }

}

