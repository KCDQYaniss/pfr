namespace EFT.GlobalEvents.ArtilleryShellingEcents;

public class ShellProjectileExplosionEvent : BaseEvent
{
	[CompilerGenerated]
	private int <ProjectileID>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private Vector3 <ExplosionPosition>k__BackingField; //Field offset: 0x1C

	public private Vector3 ExplosionPosition
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		private set { } //Length: 16
	}

	public private int ProjectileID
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public ShellProjectileExplosionEvent() { }

	[CompilerGenerated]
	public Vector3 get_ExplosionPosition() { }

	[CompilerGenerated]
	public int get_ProjectileID() { }

	public void Invoke(int projectileID, Vector3 explosionPosition) { }

	public virtual void Reset() { }

	[CompilerGenerated]
	private void set_ExplosionPosition(Vector3 value) { }

	[CompilerGenerated]
	private void set_ProjectileID(int value) { }

}

