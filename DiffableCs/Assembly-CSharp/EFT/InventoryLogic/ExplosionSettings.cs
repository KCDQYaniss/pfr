namespace EFT.InventoryLogic;

public class ExplosionSettings : IExplosionSettings
{
	public ComputableUnitSettings ComputableUnitSettings; //Field offset: 0x10
	public PhysicalSettings PhysicalSettings; //Field offset: 0x18
	public VisualSettings VisualSettings; //Field offset: 0x20
	public BackBlastSettings BackBlastSettings; //Field offset: 0x28

	private override IBackBlastSettings EFT.RocketLauncher.Explosion.IExplosionSettings.BackBlastSettings
	{
		private get { } //Length: 5
	}

	private override IComputableUnitSettings EFT.RocketLauncher.Explosion.IExplosionSettings.ComputableUnitSettings
	{
		private get { } //Length: 5
	}

	private override IPhysicalSettings EFT.RocketLauncher.Explosion.IExplosionSettings.PhysicalSettings
	{
		private get { } //Length: 5
	}

	private override IVisualSettings EFT.RocketLauncher.Explosion.IExplosionSettings.VisualSettings
	{
		private get { } //Length: 5
	}

	public ExplosionSettings() { }

	private override IBackBlastSettings EFT.RocketLauncher.Explosion.IExplosionSettings.get_BackBlastSettings() { }

	private override IComputableUnitSettings EFT.RocketLauncher.Explosion.IExplosionSettings.get_ComputableUnitSettings() { }

	private override IPhysicalSettings EFT.RocketLauncher.Explosion.IExplosionSettings.get_PhysicalSettings() { }

	private override IVisualSettings EFT.RocketLauncher.Explosion.IExplosionSettings.get_VisualSettings() { }

	public override void Initialize(IExplosionSettings settings) { }

}

