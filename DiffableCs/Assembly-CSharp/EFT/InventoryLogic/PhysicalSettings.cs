namespace EFT.InventoryLogic;

public class PhysicalSettings : IPhysicalSettings
{
	public float ExplosionRadius; //Field offset: 0x10
	public float PropagationSpeed; //Field offset: 0x14
	public float ArmingTime; //Field offset: 0x18
	public WeightMultipliers WeightMultipliers; //Field offset: 0x20

	private override float EFT.RocketLauncher.Explosion.IPhysicalSettings.ArmingTime
	{
		private get { } //Length: 6
	}

	private override float EFT.RocketLauncher.Explosion.IPhysicalSettings.ExplosionRadius
	{
		private get { } //Length: 6
	}

	private override float EFT.RocketLauncher.Explosion.IPhysicalSettings.PropagationSpeed
	{
		private get { } //Length: 6
	}

	private override WeightMultipliers EFT.RocketLauncher.Explosion.IPhysicalSettings.WeightMultipliers
	{
		private get { } //Length: 5
	}

	public PhysicalSettings() { }

	private override float EFT.RocketLauncher.Explosion.IPhysicalSettings.get_ArmingTime() { }

	private override float EFT.RocketLauncher.Explosion.IPhysicalSettings.get_ExplosionRadius() { }

	private override float EFT.RocketLauncher.Explosion.IPhysicalSettings.get_PropagationSpeed() { }

	private override WeightMultipliers EFT.RocketLauncher.Explosion.IPhysicalSettings.get_WeightMultipliers() { }

}

