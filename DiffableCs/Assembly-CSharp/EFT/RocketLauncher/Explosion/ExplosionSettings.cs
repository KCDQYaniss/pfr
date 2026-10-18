namespace EFT.RocketLauncher.Explosion;

public class ExplosionSettings : IExplosionSettings
{
	private ComputableUnitSettings _unitSettings; //Field offset: 0x10
	private PhysicalSettings _physicalSettings; //Field offset: 0x18
	private VisualSettings _visualSettings; //Field offset: 0x20
	private BackBlastSettings _backBlastSettings; //Field offset: 0x28

	public override IBackBlastSettings BackBlastSettings
	{
		 get { } //Length: 5
	}

	public override IComputableUnitSettings ComputableUnitSettings
	{
		 get { } //Length: 5
	}

	public override IPhysicalSettings PhysicalSettings
	{
		 get { } //Length: 5
	}

	public override IVisualSettings VisualSettings
	{
		 get { } //Length: 5
	}

	public ExplosionSettings() { }

	public override IBackBlastSettings get_BackBlastSettings() { }

	public override IComputableUnitSettings get_ComputableUnitSettings() { }

	public override IPhysicalSettings get_PhysicalSettings() { }

	public override IVisualSettings get_VisualSettings() { }

	public override void Initialize(IExplosionSettings settings) { }

	private void InitializeBackBlastSettings(IBackBlastSettings settings) { }

	private void InitializePhysicalSettings(IPhysicalSettings settings) { }

	private void InitializeUnitSettings(IComputableUnitSettings settings) { }

	private void InitializeVisualSettings(IVisualSettings settings) { }

}

