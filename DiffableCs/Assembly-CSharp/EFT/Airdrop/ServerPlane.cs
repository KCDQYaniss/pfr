namespace EFT.Airdrop;

public class ServerPlane : ISynchronizableLogic
{
	[CompilerGenerated]
	private struct <AwaitContainerLoot>d__39 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ServerPlane <>4__this; //Field offset: 0x20
		public string containerTemplateId; //Field offset: 0x28
		private ClientSynchronizableObjectLogicProcessor <synchronizableObjectLogicProcessor>5__2; //Field offset: 0x30
		private AirplaneSynchronizableObject <>7__wrap2; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const float AIRDROP_SPAWN_POS_Y_OFFSET = 5; //Field offset: 0x0
	private const float START_POINT_ADDITIONAL_HEIGHT = -50; //Field offset: 0x0
	private const float DISTANCE_TO_CHANGE_TARGET = 0.3; //Field offset: 0x0
	private const float HORIZONTAL_ROTATE_SPEED = 0.13; //Field offset: 0x0
	private const float MIN_ROTATE_DEGREE = 105; //Field offset: 0x0
	private const float MAX_ROTATE_DEGREE = 115; //Field offset: 0x0
	private const float ROLL_TIME_MULTIPLIER = 0.5; //Field offset: 0x0
	private const float MIN_ROLL = 55; //Field offset: 0x0
	private const float MAX_ROLL = 60; //Field offset: 0x0
	private const float ADDITIONAL_SPEED = 60; //Field offset: 0x0
	private const float ADDITIONAL_HEIGHT = 200; //Field offset: 0x0
	private const float ADDITIONAL_TIME_MULTIPLIER = 0.03; //Field offset: 0x0
	public string ContainerTemplateId; //Field offset: 0x10
	private Vector3 _startPosition; //Field offset: 0x18
	private Vector3 _exitPosition; //Field offset: 0x24
	private Vector3 _airdropPosition; //Field offset: 0x30
	private bool _flyToAirdrop; //Field offset: 0x3C
	private bool _flyToExit; //Field offset: 0x3D
	private Vector3 _velocity; //Field offset: 0x40
	private SynchronizableObjectType _objectType; //Field offset: 0x4C
	private AirplaneSynchronizableObject _syncObject; //Field offset: 0x50
	private float _destinationHeight; //Field offset: 0x58
	private float _fullDistance; //Field offset: 0x5C
	private bool _isLastObjectPacket; //Field offset: 0x60
	private Vector3 _prevPosition; //Field offset: 0x64
	private float _airplanePercent; //Field offset: 0x70
	private float _initialPlaneRoll; //Field offset: 0x74
	private float _currentRoll; //Field offset: 0x78
	private float _timeModified; //Field offset: 0x7C
	private EFTHardSettings _eftHardSettings; //Field offset: 0x80
	private AirdropSynchronizableObject _airdrop; //Field offset: 0x88
	private SynchronizableObjectPacket _offlineSyncPacket; //Field offset: 0x90

	private AirdropSettings AirdropSettings
	{
		private get { } //Length: 64
	}

	private float MoveSpeedInMeters
	{
		private get { } //Length: 141
	}

	private Transform SyncObjectTransform
	{
		private get { } //Length: 90
	}

	public ServerPlane() { }

	private void AirdropReached() { }

	[AsyncStateMachine(typeof(<AwaitContainerLoot>d__39))]
	private Task AwaitContainerLoot(string containerTemplateId) { }

	public override void CollisionEnter(Collider collider) { }

	private AirdropSettings get_AirdropSettings() { }

	private float get_MoveSpeedInMeters() { }

	private Transform get_SyncObjectTransform() { }

	private float GetClampedAngle(float angle) { }

	public override void Init(int objectID, Vector3 airdropPos, Vector3 rotation) { }

	public override void InitStaticObject() { }

	public override void ManualUpdate(float deltaTime) { }

	private void ProcessFlyToAirdrop(float deltaTime) { }

	private void ProcessFlyToExit(float deltaTime) { }

	private void ProcessPlanePosition(float deltaTime) { }

	private void ProcessPlaneRoll(float deltaTime) { }

	public void ReadSyncObjectData(ref SynchronizableObjectPacket packet) { }

	public override void ReturnToPool() { }

	public override void SetSyncObject(SynchronizableObject syncObject) { }

	public override void TakeFromPool() { }

	public void UpdateOfflineClientLogic(ClientAirPlane clientAirDrop) { }

	public override void UpdateSyncObjectData(ref SynchronizableObjectPacket packet) { }

}

