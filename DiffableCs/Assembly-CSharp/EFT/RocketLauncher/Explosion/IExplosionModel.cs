namespace EFT.RocketLauncher.Explosion;

public interface IExplosionModel
{

	public event Action OnExplosionCompleatedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	[CompilerGenerated]
	public void add_OnExplosionCompleatedEvent(Action value) { }

	public void Dispose() { }

	public IEnumerator Explode(Vector3 epicenter) { }

	[CompilerGenerated]
	public void remove_OnExplosionCompleatedEvent(Action value) { }

}

