namespace EFT.Interactive;

public class WorldInteractiveObject : InteractableObject, IMapEditable, ITriggerEntity
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__113_0; //Field offset: 0x8
		public static Func <>9__139_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <OnEnable>b__113_0(Collider c) { }

		internal bool <SmoothDoorOpenCoroutine>b__139_0(Keyframe k) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass146_0
	{
		public InteractionResult interactionResult; //Field offset: 0x10
		public WorldInteractiveObject <>4__this; //Field offset: 0x18

		public <>c__DisplayClass146_0() { }

		internal void <Interact>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass171_0
	{
		public string oldId; //Field offset: 0x10

		public <>c__DisplayClass171_0() { }

		internal bool <TryRenameId>b__0(TriggerOnStatePair triggerPair) { }

	}

	[CompilerGenerated]
	private sealed class <get_InputTriggerIds>d__168 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private string <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20

		private override string System.Collections.Generic.IEnumerator<System.String>.Current
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
		public <get_InputTriggerIds>d__168(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

		[DebuggerHidden]
		private override string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <get_OutputTriggerIds>d__170 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private string <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public WorldInteractiveObject <>4__this; //Field offset: 0x28
		private TriggerOnStatePair[] <>7__wrap1; //Field offset: 0x30
		private int <>7__wrap2; //Field offset: 0x38

		private override string System.Collections.Generic.IEnumerator<System.String>.Current
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
		public <get_OutputTriggerIds>d__170(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

		[DebuggerHidden]
		private override string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <SmoothDoorOpenCoroutine>d__139 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public WorldInteractiveObject <>4__this; //Field offset: 0x20
		public float speed; //Field offset: 0x28
		private int <maxInteractionStepsCount>5__2; //Field offset: 0x2C

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
		public <SmoothDoorOpenCoroutine>d__139(int <>1__state) { }

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
	private sealed class <UnlockCoroutine>d__151 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public WorldInteractiveObject <>4__this; //Field offset: 0x20

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
		public <UnlockCoroutine>d__151(int <>1__state) { }

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

	internal enum EDoorAxis
	{
		X = 0,
		Y = 1,
		Z = 2,
		XNegative = 3,
		YNegative = 4,
		ZNegative = 5,
	}

	internal enum EDoorHingePosition
	{
		HingeRight = 0,
		HingeLeft = 1,
	}

	internal enum EDoorInteractionAction
	{
		Pull = 0,
		Push = 1,
	}

	internal enum ERotationInterpolationMode
	{
		ViewTarget = 0,
		ViewTargetWithZeroPitch = 1,
		ViewTargetAsOrientation = 2,
	}

	internal struct InteractionParameters
	{
		public EDoorState InitialState; //Field offset: 0x0
		public Vector3 ViewTarget; //Field offset: 0x4
		public Vector3 InteractionPosition; //Field offset: 0x10
		public GripPose Grip; //Field offset: 0x20
		public int AnimationId; //Field offset: 0x28
		public bool Snap; //Field offset: 0x2C
		public bool Sit; //Field offset: 0x2D
		public ERotationInterpolationMode RotationMode; //Field offset: 0x30
		public bool BlockChangePosLevel; //Field offset: 0x34

	}

	internal class InteractionState
	{
		private float _initAngle; //Field offset: 0x10
		private float _deltaAngle; //Field offset: 0x14
		private AnimationCurve _progressCurve; //Field offset: 0x18
		[CompilerGenerated]
		private EDoorState <ResultState>k__BackingField; //Field offset: 0x20
		[CompilerGenerated]
		private bool <Break>k__BackingField; //Field offset: 0x21
		[CompilerGenerated]
		private float <ResultAngle>k__BackingField; //Field offset: 0x24
		[CompilerGenerated]
		private float <ProgressTime>k__BackingField; //Field offset: 0x28
		[CompilerGenerated]
		private float <Duration>k__BackingField; //Field offset: 0x2C
		[CompilerGenerated]
		private float <Speed>k__BackingField; //Field offset: 0x30
		[CompilerGenerated]
		private float <StartTime>k__BackingField; //Field offset: 0x34
		[CompilerGenerated]
		private float <EndTime>k__BackingField; //Field offset: 0x38
		[CompilerGenerated]
		private bool <IsConfirmed>k__BackingField; //Field offset: 0x3C

		public bool Break
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 4
		}

		public float CurrentAngle
		{
			 get { } //Length: 175
		}

		public private float Duration
		{
			[CompilerGenerated]
			 get { } //Length: 6
			[CompilerGenerated]
			private set { } //Length: 6
		}

		public float EndTime
		{
			[CompilerGenerated]
			 get { } //Length: 6
			[CompilerGenerated]
			 set { } //Length: 6
		}

		public bool IsConfirmed
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 4
		}

		public bool IsInProgress
		{
			 get { } //Length: 22
		}

		public bool NearToResult
		{
			 get { } //Length: 81
		}

		public AnimationCurve ProgressCurve
		{
			 get { } //Length: 42
			 set { } //Length: 82
		}

		public private float ProgressTime
		{
			[CompilerGenerated]
			 get { } //Length: 6
			[CompilerGenerated]
			private set { } //Length: 6
		}

		public private float ResultAngle
		{
			[CompilerGenerated]
			 get { } //Length: 6
			[CompilerGenerated]
			private set { } //Length: 6
		}

		public EDoorState ResultState
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 4
		}

		public float Speed
		{
			[CompilerGenerated]
			 get { } //Length: 6
			[CompilerGenerated]
			 set { } //Length: 6
		}

		public float StartTime
		{
			[CompilerGenerated]
			 get { } //Length: 6
			[CompilerGenerated]
			 set { } //Length: 6
		}

		public bool TimeIsOver
		{
			 get { } //Length: 13
		}

		public InteractionState() { }

		[CompilerGenerated]
		public bool get_Break() { }

		public float get_CurrentAngle() { }

		[CompilerGenerated]
		public float get_Duration() { }

		[CompilerGenerated]
		public float get_EndTime() { }

		[CompilerGenerated]
		public bool get_IsConfirmed() { }

		public bool get_IsInProgress() { }

		public bool get_NearToResult() { }

		public AnimationCurve get_ProgressCurve() { }

		[CompilerGenerated]
		public float get_ProgressTime() { }

		[CompilerGenerated]
		public float get_ResultAngle() { }

		[CompilerGenerated]
		public EDoorState get_ResultState() { }

		[CompilerGenerated]
		public float get_Speed() { }

		[CompilerGenerated]
		public float get_StartTime() { }

		public bool get_TimeIsOver() { }

		public void InitSmoothOpen(EDoorState state, float initAngle, float resultAngle, AnimationCurve progressCurve = null, bool confirmed = false) { }

		[CompilerGenerated]
		public void set_Break(bool value) { }

		[CompilerGenerated]
		private void set_Duration(float value) { }

		[CompilerGenerated]
		public void set_EndTime(float value) { }

		[CompilerGenerated]
		public void set_IsConfirmed(bool value) { }

		public void set_ProgressCurve(AnimationCurve value) { }

		[CompilerGenerated]
		private void set_ProgressTime(float value) { }

		[CompilerGenerated]
		private void set_ResultAngle(float value) { }

		[CompilerGenerated]
		public void set_ResultState(EDoorState value) { }

		[CompilerGenerated]
		public void set_Speed(float value) { }

		[CompilerGenerated]
		public void set_StartTime(float value) { }

		public void SetEndData(EDoorState state, AnimationCurve curve) { }

		public void SetEndData(InteractionState otherState) { }

		public void SyncAngle(float angle) { }

		public virtual string ToString() { }

		public void UpdateTime(float deltaTime) { }

	}

	internal struct InteractiveObjectStatusInfo
	{
		public string Id; //Field offset: 0x0
		public byte State; //Field offset: 0x8
		public int Angle; //Field offset: 0xC
		public bool Updated; //Field offset: 0x10
		public bool IsBroken; //Field offset: 0x11
		[CompilerGenerated]
		private int <NetId>k__BackingField; //Field offset: 0x14

		public int NetId
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 4
			[CompilerGenerated]
			 set { } //Length: 4
		}

		public InteractiveObjectStatusInfo(string id, EDoorState state, float angle) { }

		[CompilerGenerated]
		[IsReadOnly]
		public int get_NetId() { }

		[CompilerGenerated]
		public void set_NetId(int value) { }

	}

	internal class MBOITRenderer
	{
		public string id; //Field offset: 0x10
		public MeshRenderer renderer; //Field offset: 0x18

		public MBOITRenderer() { }

	}

	private struct TriggerOnStatePair
	{
		public EDoorState State; //Field offset: 0x0
		public string TriggerId; //Field offset: 0x8

	}

	public static bool InteractionShouldBeConfirmed; //Field offset: 0x0
	private const float MAX_APPROPRIATE_STATE_CHANGE_DELTA = 1; //Field offset: 0x0
	private const float MAX_ALLOWED_ANGLE_DESYNC = 20; //Field offset: 0x0
	private const float ANGLE_SYNC_FOR_SYNC = 30; //Field offset: 0x0
	private const int MAX_SMOOTH_INTERACT_STEPS = 1000; //Field offset: 0x0
	private const float LOCK_DISTANCE = 0.8; //Field offset: 0x0
	private const float PIVOT_2_LOCK = 0.1; //Field offset: 0x0
	private static int NextNetId; //Field offset: 0x4
	[CompilerGenerated]
	private WorldInteractiveObjectInteract OnDoorStateChanged; //Field offset: 0x48
	[SerializeField]
	private TriggerOnStatePair[] TriggersMap; //Field offset: 0x50
	[EnumBitMask(typeof(EDoorState))]
	[Header("States that take control of a player")]
	public EDoorState Snap; //Field offset: 0x58
	[Header("KeyRequirement")]
	[Space]
	public string KeyId; //Field offset: 0x60
	[Header("SkillLevelRequirement")]
	[Space]
	public bool HasSkillRequirement; //Field offset: 0x68
	public ESkillId SkillRequirement; //Field offset: 0x69
	public int SkillMinLevelRequirement; //Field offset: 0x6C
	[Space]
	public string Id; //Field offset: 0x70
	[SerializeField]
	protected float _currentAngle; //Field offset: 0x78
	[SerializeField]
	private bool _keepRotation; //Field offset: 0x7C
	public Vector3 interactPosition1; //Field offset: 0x80
	public Vector3 interactPosition2; //Field offset: 0x8C
	public Vector3 viewTarget1; //Field offset: 0x98
	[ClassStateStorageIgnore]
	public DoorHandle LockHandle; //Field offset: 0xA8
	public float OpenAngle; //Field offset: 0xB0
	public float CloseAngle; //Field offset: 0xB4
	public EDoorAxis DoorAxis; //Field offset: 0xB8
	public EDoorAxis DoorForward; //Field offset: 0xBC
	[Header("Animations")]
	public bool interactWithoutAnimation; //Field offset: 0xC0
	public float ShutShift; //Field offset: 0xC4
	public NavMeshObstacle Obstacle; //Field offset: 0xC8
	[SerializeField]
	protected EDoorState _doorState; //Field offset: 0xD0
	[ClassStateStorageIgnore]
	protected InteractionState _interaction; //Field offset: 0xD8
	[ClassStateStorageIgnore]
	protected InteractionState _previousInteraction; //Field offset: 0xE0
	[SerializeField]
	protected DoorHandle _handle; //Field offset: 0xE8
	[ClassStateStorageIgnore]
	protected GripPose[] Grips; //Field offset: 0xF0
	[SerializeField]
	private bool _forceLocalInteraction; //Field offset: 0xF8
	[SerializeField]
	public bool NoInteractionsAllowed; //Field offset: 0xF9
	[SerializeField]
	private float _maxAllowedDistance; //Field offset: 0xFC
	[ClassStateStorageIgnore]
	[SerializeField]
	private MBOITRenderer[] _mboitRenderers; //Field offset: 0x100
	private Dictionary _rendererToMBOITRenderer; //Field offset: 0x108
	public EInteraction DoorKeyOpenInteraction; //Field offset: 0x110
	[Header("Actions")]
	[Space(10)]
	public bool Operatable; //Field offset: 0x111
	private int _netId; //Field offset: 0x114
	protected bool _forceSync; //Field offset: 0x118
	private bool _currentAngleChanged; //Field offset: 0x119
	private EDoorState _syncState; //Field offset: 0x11A
	private float _syncAngle; //Field offset: 0x11C
	protected bool _shutPlayed; //Field offset: 0x120
	[ClassStateStorageIgnore]
	[Header("Sound")]
	[Space]
	public AudioClip[] ShutSound; //Field offset: 0x128
	[ClassStateStorageIgnore]
	public AudioClip[] SqueakSound; //Field offset: 0x130
	[ClassStateStorageIgnore]
	public AudioClip[] OpenSound; //Field offset: 0x138
	[SerializeField]
	protected int _shutSoundRolloff; //Field offset: 0x140
	[SerializeField]
	protected int _squeakSoundRolloff; //Field offset: 0x144
	[SerializeField]
	protected int _openSoundRolloff; //Field offset: 0x148
	[SerializeField]
	private AnimationCurve _spreadSoundCurve; //Field offset: 0x150
	private bool _shouldUpdateTransformWindowsManager; //Field offset: 0x158
	[CompilerGenerated]
	private IPlayer <InteractingPlayer>k__BackingField; //Field offset: 0x160
	[CompilerGenerated]
	private Collider <Collider>k__BackingField; //Field offset: 0x168
	[CompilerGenerated]
	private EDoorState <FallbackState>k__BackingField; //Field offset: 0x170
	[CompilerGenerated]
	private EDoorState <InitialDoorState>k__BackingField; //Field offset: 0x171

	public event WorldInteractiveObjectInteract OnDoorStateChanged
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public override float AngleSyncForSync
	{
		 get { } //Length: 9
	}

	public private Collider Collider
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override float CurrentAngle
	{
		 get { } //Length: 6
		 set { } //Length: 1660
	}

	public override EDoorState DoorState
	{
		 get { } //Length: 8
		 set { } //Length: 472
	}

	private override GameObject EFT.Interactive.IMapEditable.GameObject
	{
		private get { } //Length: 78
	}

	private override string EFT.Interactive.IMapEditable.IdEditable
	{
		private get { } //Length: 5
		private set { } //Length: 82
	}

	public EDoorState FallbackState
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public bool ForceLocalInteraction
	{
		 get { } //Length: 8
	}

	public override GameObject GameObject
	{
		 get { } //Length: 78
	}

	public Transform Handle
	{
		 get { } //Length: 93
	}

	public private EDoorState InitialDoorState
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public override IEnumerable InputTriggerIds
	{
		[IteratorStateMachine(typeof(<get_InputTriggerIds>d__168))]
		 get { } //Length: 80
	}

	public private IPlayer InteractingPlayer
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override bool IsClientAuthority
	{
		 get { } //Length: 3
	}

	public override float LockDistance
	{
		 get { } //Length: 9
	}

	public override float MaxAllowedAngleDesync
	{
		 get { } //Length: 9
	}

	public float MaxAllowedDistance
	{
		 get { } //Length: 9
	}

	public int NetId
	{
		 get { } //Length: 95
		 set { } //Length: 7
	}

	protected override Vector2 OpenSoundVolumeRange
	{
		 get { } //Length: 25
	}

	public override IEnumerable OutputTriggerIds
	{
		[IteratorStateMachine(typeof(<get_OutputTriggerIds>d__170))]
		 get { } //Length: 175
	}

	public override AnimationCurve ProgressCurve
	{
		 get { } //Length: 33
	}

	protected override Vector2 ShutSoundVolumeRange
	{
		 get { } //Length: 25
	}

	public override string TypeKey
	{
		 get { } //Length: 49
	}

	public WorldInteractiveObject() { }

	[CompilerGenerated]
	public void add_OnDoorStateChanged(WorldInteractiveObjectInteract value) { }

	private void Awake() { }

	protected override int CalculateInteractionIndex(Vector3 playerPosition) { }

	public override void CancelInteraction() { }

	protected override bool CanStartInteraction(EDoorState state, bool logFalse = false) { }

	protected void Close() { }

	private bool CurrentAngleInNormalSyncRange(float syncAngle, EDoorState state) { }

	protected override void DoorStateChanged(EDoorState newState) { }

	private override GameObject EFT.Interactive.IMapEditable.get_GameObject() { }

	private override string EFT.Interactive.IMapEditable.get_IdEditable() { }

	private override void EFT.Interactive.IMapEditable.set_IdEditable(string value) { }

	public void ForceCloseLocalDoor(bool playSound) { }

	public void ForceLockedState() { }

	private Dictionary GenerateRenderersToMBOITRendererDict(MBOITRenderer[] renderers) { }

	public override float get_AngleSyncForSync() { }

	[CompilerGenerated]
	public Collider get_Collider() { }

	public override float get_CurrentAngle() { }

	public override EDoorState get_DoorState() { }

	[CompilerGenerated]
	public EDoorState get_FallbackState() { }

	public bool get_ForceLocalInteraction() { }

	public override GameObject get_GameObject() { }

	public Transform get_Handle() { }

	[CompilerGenerated]
	public EDoorState get_InitialDoorState() { }

	[IteratorStateMachine(typeof(<get_InputTriggerIds>d__168))]
	public override IEnumerable get_InputTriggerIds() { }

	[CompilerGenerated]
	public IPlayer get_InteractingPlayer() { }

	public override bool get_IsClientAuthority() { }

	public override float get_LockDistance() { }

	public override float get_MaxAllowedAngleDesync() { }

	public float get_MaxAllowedDistance() { }

	public int get_NetId() { }

	protected override Vector2 get_OpenSoundVolumeRange() { }

	[IteratorStateMachine(typeof(<get_OutputTriggerIds>d__170))]
	public override IEnumerable get_OutputTriggerIds() { }

	public override AnimationCurve get_ProgressCurve() { }

	protected override Vector2 get_ShutSoundVolumeRange() { }

	public override string get_TypeKey() { }

	public override float GetAngle(EDoorState state) { }

	public override GripPose GetClosestGrip(Vector3 yourPosition) { }

	public Quaternion GetDoorRotation(float currentAngle) { }

	public float GetInitAngle(EDoorState state) { }

	public override InteractionParameters GetInteractionParameters(Vector3 playerPosition) { }

	public override Vector3 GetInteractionPosition(Vector3 yourPosition) { }

	public string GetRendererId(Renderer renderer) { }

	public static Vector3 GetRotationAxis(EDoorAxis doorAxis, Transform objectTransform) { }

	protected Vector3 GetSoundOcclusionOffset() { }

	protected EOcclusionTest GetSoundOcclusionTest(Vector3 position) { }

	protected override Vector3 GetSoundPos() { }

	protected float GetSqrDistanceToMyPlayer(Vector3 position) { }

	public override InteractiveObjectStatusInfo GetStatusInfo(bool solidState = false) { }

	public override Vector3 GetViewDirection(Vector3 position) { }

	protected override void InitializeSmoothOpenInteraction(EDoorState state, bool confirmed = false) { }

	public void Interact(EInteractionType interactionType) { }

	public override void Interact(InteractionResult interactionResult) { }

	public bool IsInteractionSuitsCurrentState(EInteractionType interaction) { }

	protected void Lock() { }

	public void LockForInteraction(EDoorState resultState) { }

	public void LockForInteraction() { }

	public void LockForInteractionAs(EDoorState lockState) { }

	public string mboitRendererId(int idx) { }

	public int mboitRenderersCount() { }

	protected override void OnAwake() { }

	protected override void OnDestroy() { }

	public virtual void OnDrawGizmosSelected() { }

	public override void OnEnable() { }

	public virtual void OnReturnToPool(AssetPoolObject assetPoolObject) { }

	public override void OnValidate() { }

	protected override void Open() { }

	protected void PlayShut() { }

	protected void PlaySound(EDoorState state, float volume = 1) { }

	protected AudioHandle PlaySoundAtPoint(Vector3 position, AudioClip clip, AudioSourceGroupType groupType, int rolloff, float volume, bool loop = false, bool useSpreadCurve = false) { }

	protected override void ProcessOcclusion(BetterSource source, Vector3 position) { }

	private void PushTriggers(EDoorState state) { }

	[CompilerGenerated]
	public void remove_OnDoorStateChanged(WorldInteractiveObjectInteract value) { }

	protected override void Seal() { }

	[CompilerGenerated]
	private void set_Collider(Collider value) { }

	protected override void set_CurrentAngle(float value) { }

	public override void set_DoorState(EDoorState value) { }

	[CompilerGenerated]
	protected void set_FallbackState(EDoorState value) { }

	[CompilerGenerated]
	private void set_InitialDoorState(EDoorState value) { }

	[CompilerGenerated]
	private void set_InteractingPlayer(IPlayer value) { }

	public void set_NetId(int value) { }

	protected void SetDoorState(EDoorState state, bool force = false) { }

	public void SetFromStatusInfo(InteractiveObjectStatusInfo info) { }

	public override void SetInitialSyncState(InteractiveObjectStatusInfo info) { }

	public bool SetMBOITRenderers(MeshRenderer[] renderers) { }

	public override void SetUser(Player player) { }

	[IteratorStateMachine(typeof(<SmoothDoorOpenCoroutine>d__139))]
	protected override IEnumerator SmoothDoorOpenCoroutine(EDoorState state, bool isLocalInteraction, float speed = 1) { }

	public override void SyncInteractState(InteractiveObjectStatusInfo info) { }

	public override bool TryRenameId(string oldId, string newId) { }

	protected void Unlock() { }

	[IteratorStateMachine(typeof(<UnlockCoroutine>d__151))]
	protected override IEnumerator UnlockCoroutine() { }

	public override Option UnlockOperation(KeyComponent key, Player player, WorldInteractiveObject wio) { }

	protected override void Unseal() { }

}

