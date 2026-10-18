namespace EFT.RocketLauncher.Explosion;

public interface IExplosionSettings
{

	public IBackBlastSettings BackBlastSettings
	{
		 get { } //Length: 0
	}

	public IComputableUnitSettings ComputableUnitSettings
	{
		 get { } //Length: 0
	}

	public IPhysicalSettings PhysicalSettings
	{
		 get { } //Length: 0
	}

	public IVisualSettings VisualSettings
	{
		 get { } //Length: 0
	}

	public IBackBlastSettings get_BackBlastSettings() { }

	public IComputableUnitSettings get_ComputableUnitSettings() { }

	public IPhysicalSettings get_PhysicalSettings() { }

	public IVisualSettings get_VisualSettings() { }

	public void Initialize(IExplosionSettings settings) { }

}

