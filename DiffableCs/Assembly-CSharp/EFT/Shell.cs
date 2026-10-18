namespace EFT;

public class Shell : BouncingObject
{
	private const float DELTA_TIME_MULTIPLIER = 100; //Field offset: 0x0
	[SerializeField]
	private ECaliber _caliber; //Field offset: 0xF8
	private Vector3 _rotationVector; //Field offset: 0xFC
	[CompilerGenerated]
	private IShellCollisionListener <CollisionListener>k__BackingField; //Field offset: 0x108

	public IShellCollisionListener CollisionListener
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public Shell() { }

	public void ActivatePhysics(Vector3 beginPoint, Vector3 velocity, Vector3 rotationVector, Vector3 weaponForward) { }

	private void Awake() { }

	public void DisablePhysics() { }

	[CompilerGenerated]
	public IShellCollisionListener get_CollisionListener() { }

	protected virtual void OnBounce(Collider collider) { }

	[CompilerGenerated]
	public void set_CollisionListener(IShellCollisionListener value) { }

	public void SetCaliber(ECaliber caliber) { }

	protected virtual void Update() { }

}

