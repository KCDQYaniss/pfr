namespace EFT.Airdrop;

public sealed class ServerAirDrop : ISynchronizableLogic
{
	[CompilerGenerated]
	private sealed class <RotateAfterDrop>d__54 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public float angle; //Field offset: 0x20
		public ServerAirDrop <>4__this; //Field offset: 0x28
		public Vector3 axis; //Field offset: 0x30
		public bool onePointContact; //Field offset: 0x3C
		private int <rotationFrames>5__2; //Field offset: 0x40
		private int <i>5__3; //Field offset: 0x44

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
		public <RotateAfterDrop>d__54(int <>1__state) { }

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

	[CompilerGenerated]
	private sealed class <SignalFireCoroutine>d__38 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public ServerAirDrop <>4__this; //Field offset: 0x20
		private float <end>5__2; //Field offset: 0x28

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
		public <SignalFireCoroutine>d__38(int <>1__state) { }

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

	private AirdropSynchronizableObject _syncObject; //Field offset: 0x10
	private Transform _parachuteJoint; //Field offset: 0x18
	private float _tiltAngle; //Field offset: 0x20
	private BoxCollider _collisionCollider; //Field offset: 0x28
	private Timer _swingTimer; //Field offset: 0x30
	private bool _descending; //Field offset: 0x38
	private Vector3[] _extents; //Field offset: 0x40
	private EAirdropFallingStage _fallingStage; //Field offset: 0x48
	private float _decelerationSpeed; //Field offset: 0x4C
	private Vector3 _velocity; //Field offset: 0x50
	private Vector3 _wind; //Field offset: 0x5C
	private Vector3 _parachuteOpeningStartVelocity; //Field offset: 0x68
	private float _parachuteOpeningTime; //Field offset: 0x74
	private float _parachuteOpeningCurrentTime; //Field offset: 0x78
	private Vector3 _parachuteOpeningStartPosition; //Field offset: 0x7C
	private float _previousTiltAngle; //Field offset: 0x88
	private float _torque; //Field offset: 0x8C
	private Collider[] _myColliders; //Field offset: 0x90
	private Vector3[] _extentsHeights; //Field offset: 0x98
	private bool _signalFire; //Field offset: 0xA0
	private Coroutine _signalFireCoroutine; //Field offset: 0xA8
	private float _torqueDeceleration; //Field offset: 0xB0
	private bool _signalFireCoroutineDone; //Field offset: 0xB4
	private AirdropSettings _airdropSettings; //Field offset: 0xB8
	private SynchronizableObjectPacket _offlineSyncPacket; //Field offset: 0xC0

	private float CurrentTiltAngle
	{
		private get { } //Length: 90
	}

	private EFTHardSettings EftSettings
	{
		private get { } //Length: 7
	}

	private float ParachuteSpeed
	{
		private get { } //Length: 46
	}

	private Rigidbody SyncObjectRigidbody
	{
		private get { } //Length: 73
	}

	private Transform SyncObjectTransform
	{
		private get { } //Length: 90
	}

	public ServerAirDrop() { }

	private void CalcExtents(bool onInit) { }

	public override void CollisionEnter(Collider collider) { }

	private void Fall(float deltaTime) { }

	private float get_CurrentTiltAngle() { }

	private EFTHardSettings get_EftSettings() { }

	private float get_ParachuteSpeed() { }

	private Rigidbody get_SyncObjectRigidbody() { }

	private Transform get_SyncObjectTransform() { }

	private Vector3 GetDiagonalPoint() { }

	private Vector3 GetOppositePoint() { }

	private bool GetRaycastPoint(Vector3 point, float distance, out RaycastHit raycastHit) { }

	private bool HasRaycastHit(Vector3 point, float distance) { }

	public override void Init(int objectId, Vector3 position, Vector3 rotation) { }

	public override void InitStaticObject() { }

	public override void ManualUpdate(float deltaTime) { }

	private void OnOnePointContact() { }

	private void OnTwoPointContact() { }

	private void ParashuteLanding(float deltaTime) { }

	private void ParashuteOpening(float deltaTime) { }

	private Vector3 ParashuteOpeningResultVector() { }

	public override void ReturnToPool() { }

	[IteratorStateMachine(typeof(<RotateAfterDrop>d__54))]
	private IEnumerator RotateAfterDrop(Vector3 axis, float angle, bool onePointContact) { }

	private void SetExtents() { }

	public override void SetSyncObject(SynchronizableObject syncObject) { }

	[IteratorStateMachine(typeof(<SignalFireCoroutine>d__38))]
	private IEnumerator SignalFireCoroutine() { }

	private void StartOpeningParashute() { }

	private void Swing() { }

	public override void TakeFromPool() { }

	private void Torque() { }

	public void UpdateOfflineClientLogic(ClientAirDrop clientAirDrop) { }

	public override void UpdateSyncObjectData(ref SynchronizableObjectPacket packet) { }

	private Vector3 WindVector() { }

}

