//Type is in global namespace

public class SmallPhysicsObject : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__28_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <Awake>b__28_0(Rigidbody x) { }

	}

	[CompilerGenerated]
	private sealed class <TimeOfLifeCountDown>d__34 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public SmallPhysicsObject <>4__this; //Field offset: 0x20

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <TimeOfLifeCountDown>d__34(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal enum EPhysicsObjectType
	{
		Books = 0,
		CardBoard = 1,
		CoolerBottle = 2,
		Cup = 3,
		GlassBottle = 4,
		HardPlastic = 5,
		MediumGeneric = 6,
		MetalCandlestick = 7,
		Monitor = 8,
		SmallBox = 9,
		SmallPaper = 10,
		SmallPlastic = 11,
		TincanEmpty = 12,
	}

	private const float COLLISION_TRACK_TIMEOUT = 0.5; //Field offset: 0x0
	private const float HIT_TRACK_TIMEOUT = 0.3; //Field offset: 0x0
	private const float MIN_COLLISION_THRESHOLD = 0.2; //Field offset: 0x0
	private const float TRAVEL_THROUGH_GLASS_THRESHOLD = 0.5; //Field offset: 0x0
	private static readonly Collider[] PlayerColliders; //Field offset: 0x0
	public EPhysicsObjectType SoundType; //Field offset: 0x20
	public List BallisticColliders; //Field offset: 0x28
	public List Rigidbodies; //Field offset: 0x30
	public Collider Collider; //Field offset: 0x38
	public GameObject SolidObject; //Field offset: 0x40
	public GameObject FragmentedObject; //Field offset: 0x48
	public float TimeOfLife; //Field offset: 0x50
	public float OnHitForceMultiplier; //Field offset: 0x54
	public float OnTouchForceMultiplier; //Field offset: 0x58
	public float OnBlowUpForceMultiplier; //Field offset: 0x5C
	public float BlowUpThreshold; //Field offset: 0x60
	public string ParticlesEffectName; //Field offset: 0x68
	public List InitialPositions; //Field offset: 0x70
	private byte _collisionNumber; //Field offset: 0x78
	private float _dontCheckUntil; //Field offset: 0x7C
	protected float IgnoreCollisionTrackingTimer; //Field offset: 0x80
	private float _lastHitTime; //Field offset: 0x84
	public Vector3 TestBlowPosition; //Field offset: 0x88
	private Vector3 _lastCollidedPlayerPosition; //Field offset: 0x94
	private Coroutine _destroyCoroutine; //Field offset: 0xA0
	private SoundBank _collisionSoundBank; //Field offset: 0xA8
	private readonly Vector3 _sourceShift; //Field offset: 0xB0

	public byte CollisionNumber
	{
		 get { } //Length: 5
		 set { } //Length: 110
	}

	private static SmallPhysicsObject() { }

	public SmallPhysicsObject() { }

	private void Awake() { }

	private void CheckPlayerCollision() { }

	public byte get_CollisionNumber() { }

	public void OnBlowUp(Vector3 grenadePosition) { }

	private void OnCollisionEnter(Collision collision) { }

	public void OnCollisionHandler(bool resetSound = false) { }

	private void OnDrawGizmos() { }

	private void OnHit(DamageInfo damageInfo) { }

	private void PlayCollision(Vector3 force, Vector3 position, float forceMultiplier) { }

	private void PlayGrenadeBlowup() { }

	private void PlayParticles() { }

	private void PlaySound() { }

	public void ResetToDefaultPositions() { }

	public void set_CollisionNumber(byte value) { }

	private void SetupDefaultPositions(Transform t) { }

	private void SetupSoundBank() { }

	private void StartPartciles(Vector3 force) { }

	[IteratorStateMachine(typeof(<TimeOfLifeCountDown>d__34))]
	private IEnumerator TimeOfLifeCountDown() { }

	public void UpdatePhysics() { }

}

