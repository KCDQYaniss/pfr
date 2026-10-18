//Type is in global namespace

[DisallowMultipleComponent]
public class RigidbodySpawner : MonoBehaviour
{
	public float mass; //Field offset: 0x20
	public float drag; //Field offset: 0x24
	public float angularDrag; //Field offset: 0x28
	public bool useGravity; //Field offset: 0x2C
	public bool isKinematic; //Field offset: 0x2D
	public RigidbodyInterpolation interpolation; //Field offset: 0x30
	public CollisionDetectionMode collisionDetectionMode; //Field offset: 0x34
	[EnumBitMask(typeof(RigidbodyConstraints))]
	public RigidbodyConstraints constraints; //Field offset: 0x38
	private Rigidbody _rigidbody; //Field offset: 0x40
	[CompilerGenerated]
	private Action SpawnEvent; //Field offset: 0x48
	[CompilerGenerated]
	private Action RemoveEvent; //Field offset: 0x50

	public event Action RemoveEvent
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action SpawnEvent
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public Rigidbody Rigidbody
	{
		 get { } //Length: 5
	}

	public RigidbodySpawner() { }

	[CompilerGenerated]
	public void add_RemoveEvent(Action value) { }

	[CompilerGenerated]
	public void add_SpawnEvent(Action value) { }

	public Rigidbody Create() { }

	public Rigidbody get_Rigidbody() { }

	public void Remove() { }

	[CompilerGenerated]
	public void remove_RemoveEvent(Action value) { }

	[CompilerGenerated]
	public void remove_SpawnEvent(Action value) { }

}

