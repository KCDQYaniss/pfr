namespace EFT.Airdrop;

public class ClientAirPlane : ISynchronizableLogic
{
	[CompilerGenerated]
	private sealed class <SpawnLTCCoroutine>d__43 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public ClientAirPlane <>4__this; //Field offset: 0x20
		public float emissionTime; //Field offset: 0x28
		private GameObject <projectile>5__2; //Field offset: 0x30
		private ParticleSystem[] <projectileParticles>5__3; //Field offset: 0x38
		private float <projectileEmissionTime>5__4; //Field offset: 0x40

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
		public <SpawnLTCCoroutine>d__43(int <>1__state) { }

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

	private const float MAX_PROJECTILE_EMISSION_TIME = 0.4; //Field offset: 0x0
	private static readonly Vector3 PROJECTILE_LOCAL_POSITION; //Field offset: 0x0
	private const float MIN_PITCH = 0.7; //Field offset: 0x0
	private const float MAX_PITCH = 1.1; //Field offset: 0x0
	private const float DOPPLER = 1.5; //Field offset: 0x0
	private const float MIN_SPREAD = 60; //Field offset: 0x0
	private const float MAX_SPREAD = 180; //Field offset: 0x0
	private const float SPREAD_DISTANCE = 800; //Field offset: 0x0
	private const float MIN_DISTANCE_TO_PLAYER = 300; //Field offset: 0x0
	private const float LAST_PROJECTILE_EMISSION_TIME = 5; //Field offset: 0x0
	private const float LAST_PROJECTILE_INIT_PERCENT = 49; //Field offset: 0x0
	private const float PROJECTILE_STEP = 4; //Field offset: 0x0
	private const float MIN_PROJECTILE_EMISSION_TIME = 0.2; //Field offset: 0x0
	public ServerPlane OfflineServerLogic; //Field offset: 0x10
	public bool offlineMode; //Field offset: 0x18
	private float _nextProjectileSpawnedTime; //Field offset: 0x1C
	private bool _lastProjectileSpawned; //Field offset: 0x20
	private Vector3 _destinationPosition; //Field offset: 0x24
	private Quaternion _destinationRotation; //Field offset: 0x30
	private SynchronizableObjectType _objectType; //Field offset: 0x40
	private AirplaneSynchronizableObject _syncObject; //Field offset: 0x48
	private int _airplanePercent; //Field offset: 0x50
	private int _currentMaxAirplanePercent; //Field offset: 0x54
	private MeshRenderer[] _airplaneMeshRenderers; //Field offset: 0x58
	private AudioListener _listener; //Field offset: 0x60
	private Bounds _mapBounds; //Field offset: 0x68
	private BetterSource _soundSource; //Field offset: 0x80

	private BetterSource SoundSource
	{
		private get { } //Length: 591
		private set { } //Length: 82
	}

	private Transform SyncObjectTransform
	{
		private get { } //Length: 90
	}

	private static ClientAirPlane() { }

	public ClientAirPlane(bool offlineServerLogic) { }

	public override void CollisionEnter(Collider colliderComponent) { }

	private BetterSource get_SoundSource() { }

	private Transform get_SyncObjectTransform() { }

	private float GetDistancePercent() { }

	public override void Init(int objectID, Vector3 position, Vector3 rotation) { }

	public override void InitStaticObject() { }

	private void ManualProjectileUpdate() { }

	public override void ManualUpdate(float deltaTime) { }

	private void PlaySound(TaggedClip clip) { }

	private void ReleaseSpeechSource() { }

	public override void ReturnToPool() { }

	private void set_SoundSource(BetterSource value) { }

	public override void SetSyncObject(SynchronizableObject syncObject) { }

	[IteratorStateMachine(typeof(<SpawnLTCCoroutine>d__43))]
	private IEnumerator SpawnLTCCoroutine(float emissionTime) { }

	public override void TakeFromPool() { }

	public override void UpdateSyncObjectData(ref SynchronizableObjectPacket packet) { }

}

