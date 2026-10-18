namespace EFT.InventoryLogic;

public sealed class ExplosiveAmmoComponent : ReadonlyItemComponent, IExplosiveItem
{

	private override Vector3 EFT.IExplosiveItem.ArmorDistanceDistanceDamage
	{
		private get { } //Length: 113
	}

	private override Vector3 EFT.IExplosiveItem.Blindness
	{
		private get { } //Length: 113
	}

	private override Vector3 EFT.IExplosiveItem.Contusion
	{
		private get { } //Length: 113
	}

	private override int EFT.IExplosiveItem.FragmentsCount
	{
		private get { } //Length: 78
	}

	private override float EFT.IExplosiveItem.GetStrength
	{
		private get { } //Length: 78
	}

	private override float EFT.IExplosiveItem.MaxExplosionDistance
	{
		private get { } //Length: 78
	}

	private override float EFT.IExplosiveItem.MinExplosionDistance
	{
		private get { } //Length: 78
	}

	public override bool IsDummy
	{
		 get { } //Length: 78
	}

	public ExplosiveAmmoComponent(IExplosiveAmmoTemplate explosiveItemTemplate) { }

	private override Ammo EFT.IExplosiveItem.CreateFragment() { }

	private override Vector3 EFT.IExplosiveItem.get_ArmorDistanceDistanceDamage() { }

	private override Vector3 EFT.IExplosiveItem.get_Blindness() { }

	private override Vector3 EFT.IExplosiveItem.get_Contusion() { }

	private override int EFT.IExplosiveItem.get_FragmentsCount() { }

	private override float EFT.IExplosiveItem.get_GetStrength() { }

	private override float EFT.IExplosiveItem.get_MaxExplosionDistance() { }

	private override float EFT.IExplosiveItem.get_MinExplosionDistance() { }

	public override bool get_IsDummy() { }

}

