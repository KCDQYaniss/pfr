namespace EFT.GlobalEvents.ArtilleryShellingEcents;

public class ShellProjectileCreateEvent : BaseEvent
{
	[CompilerGenerated]
	private int <ProjectileID>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private Vector3 <StartPosition>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private Transform <ProjectileTransform>k__BackingField; //Field offset: 0x28

	public private int ProjectileID
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private Transform ProjectileTransform
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private Vector3 StartPosition
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		private set { } //Length: 16
	}

	public ShellProjectileCreateEvent() { }

	[CompilerGenerated]
	public int get_ProjectileID() { }

	[CompilerGenerated]
	public Transform get_ProjectileTransform() { }

	[CompilerGenerated]
	public Vector3 get_StartPosition() { }

	public void Invoke(int projectileID, Vector3 startPosition, Transform projectileTransform) { }

	public virtual void Reset() { }

	[CompilerGenerated]
	private void set_ProjectileID(int value) { }

	[CompilerGenerated]
	private void set_ProjectileTransform(Transform value) { }

	[CompilerGenerated]
	private void set_StartPosition(Vector3 value) { }

}

