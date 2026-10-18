namespace EFT.InventoryLogic;

public class ComputableUnitSettings : IComputableUnitSettings
{
	public float Size; //Field offset: 0x10
	public ComputableUnitType Type; //Field offset: 0x14
	public Vector2 UnitDamage; //Field offset: 0x18

	private override float EFT.RocketLauncher.Explosion.IComputableUnitSettings.Size
	{
		private get { } //Length: 6
	}

	private override ComputableUnitType EFT.RocketLauncher.Explosion.IComputableUnitSettings.Type
	{
		private get { } //Length: 4
	}

	private override Vector2 EFT.RocketLauncher.Explosion.IComputableUnitSettings.UnitDamage
	{
		private get { } //Length: 19
	}

	public ComputableUnitSettings() { }

	private override float EFT.RocketLauncher.Explosion.IComputableUnitSettings.get_Size() { }

	private override ComputableUnitType EFT.RocketLauncher.Explosion.IComputableUnitSettings.get_Type() { }

	private override Vector2 EFT.RocketLauncher.Explosion.IComputableUnitSettings.get_UnitDamage() { }

}

