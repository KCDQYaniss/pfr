namespace EFT.Interactive;

public class CorpseRagdoll
{
	[CompilerGenerated]
	private sealed class <WorkingCycle>d__28 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public CorpseRagdoll <>4__this; //Field offset: 0x20
		private bool <sleeping>5__2; //Field offset: 0x28
		private float <timePass>5__3; //Field offset: 0x2C
		private CharacterJointSpawner[] <>7__wrap3; //Field offset: 0x30
		private int <>7__wrap4; //Field offset: 0x38
		private CharacterJointSpawner <jointSpawner>5__6; //Field offset: 0x40
		private RigidbodySpawner[] <>7__wrap6; //Field offset: 0x48
		private RigidbodySpawner <rigidbodySpawner>5__8; //Field offset: 0x50

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
		public <WorkingCycle>d__28(int <>1__state) { }

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

	private RigidbodySpawner[] _rigidbodySpawners; //Field offset: 0x10
	private CharacterJointSpawner[] _jointSpawners; //Field offset: 0x18
	private List _rigidbodySleepHierarchy; //Field offset: 0x20
	private Vector3 _velocity; //Field offset: 0x28
	private CollisionDetectionMode _collisionDetectionMode; //Field offset: 0x34
	private MonoBehaviour _owner; //Field offset: 0x38
	private Func _checkCorpseIsStill; //Field offset: 0x40
	private Action _onRigidbodyStopped; //Field offset: 0x48
	private bool _keepRigidbody; //Field offset: 0x50
	private bool _putToSleep; //Field offset: 0x51
	private float _maxDepenetrationVelocity; //Field offset: 0x54
	private bool _isPhysicsDone; //Field offset: 0x58
	[CanBeNull]
	private Func _isVisibleTest; //Field offset: 0x60
	private Rigidbody _weaponRigidbody; //Field offset: 0x68
	private Joint _weaponJoint; //Field offset: 0x70
	private bool _hasImpulse; //Field offset: 0x78
	private RigidbodySpawner _impulseRigidbodySpawner; //Field offset: 0x80
	private Vector3 _impulseDirection; //Field offset: 0x88
	private Vector3 _impulsePoint; //Field offset: 0x94
	private float _impulseThrust; //Field offset: 0xA0
	private readonly List _weaponCollidersBuffer; //Field offset: 0xA8
	private readonly List _corpseCollidersBuffer; //Field offset: 0xB0
	private PlayerBody _playerBody; //Field offset: 0xB8

	public Rigidbody WeaponRigidbody
	{
		 get { } //Length: 5
	}

	public CorpseRagdoll(RigidbodySpawner[] rigidbodySpawners, CharacterJointSpawner[] jointSpawners, List rigidbodySleepHierarchy, Vector3 velocity, float maxDepenetrationVelocity, CollisionDetectionMode collisionDetectionMode, MonoBehaviour owner, Func checkCorpseIsStill, PlayerBody playerBody, Func isVisibleTest, Action onRigidbodyStopped, bool keepRigidbody, bool putToSleep) { }

	private void ApplyImpulse(Rigidbody rigidbody, Vector3 direction, Vector3 point, float thrust) { }

	public void ApplyImpulse(Collider collider, Vector3 direction, Vector3 point, float thrust) { }

	public void AttachWeapon(Rigidbody weaponRigidbody, GameObject playerGameObject, PlayerBones playerBones, TransformLinks links, bool fixedHinge, Vector3 velocity) { }

	public void BreakBodyJointToItemInHands() { }

	public void ClearWeapon() { }

	private bool FindRigidbodySpawner(Collider collider, out RigidbodySpawner rigidbodySpawner) { }

	public void ForceStopRigidBody() { }

	public Rigidbody get_WeaponRigidbody() { }

	private void GetPartsTogether() { }

	private Joint HandAttach(GameObject body, Rigidbody connectedBody) { }

	private void IgnoreWeaponToCorpseCollisions(Rigidbody weaponRigidbody) { }

	private void Start() { }

	private void StopRigidbody(Rigidbody rigidbody) { }

	private void StopWeapon() { }

	private Joint StrapAttach(GameObject body, Rigidbody connectedBody, Vector3 p1, Vector3 p2) { }

	private void TryToApplyImpulse() { }

	public void WakeUp() { }

	[IteratorStateMachine(typeof(<WorkingCycle>d__28))]
	private IEnumerator WorkingCycle() { }

}

