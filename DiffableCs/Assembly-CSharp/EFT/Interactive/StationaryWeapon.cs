namespace EFT.Interactive;

public class StationaryWeapon : InteractableObject, IStaticLoot, IMapEditable
{
	[CompilerGenerated]
	private sealed class <ResetCoroutine>d__81 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public StationaryWeapon <>4__this; //Field offset: 0x20
		private float <t>5__2; //Field offset: 0x28
		private Vector3 <dropPosition>5__3; //Field offset: 0x2C
		private Quaternion <dropRotation>5__4; //Field offset: 0x38

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
		public <ResetCoroutine>d__81(int <>1__state) { }

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

	internal enum EStationaryAnimationType
	{
		UtesSit = 0,
		UtesStand = 1,
		AGS_17 = 2,
	}

	private const int BREAK_CHAIN_AMOUNT = 20; //Field offset: 0x0
	[SerializeField]
	private string _id; //Field offset: 0x48
	[SerializeField]
	private GameObject[] _gameObjectsWithRenderers; //Field offset: 0x50
	[FormerlySerializedAs("BeltPivotChamber")]
	[SerializeField]
	private Transform _beltPivotChamber; //Field offset: 0x58
	[FormerlySerializedAs("BetlPivotMagazine")]
	[SerializeField]
	private Transform _beltPivotMagazine; //Field offset: 0x60
	[SerializeField]
	private Transform _beltEmptyPivotChamber; //Field offset: 0x68
	[SerializeField]
	private Vector2 _initialOrientation; //Field offset: 0x70
	[SerializeField]
	private Vector2 _pitchLimit; //Field offset: 0x78
	[SerializeField]
	private Vector2 _yawLimit; //Field offset: 0x80
	[SerializeField]
	private MagVisualController _magController; //Field offset: 0x88
	[SerializeField]
	private Transform _debugViews; //Field offset: 0x90
	[SerializeField]
	private Transform _collidersToCut; //Field offset: 0x98
	public string Template; //Field offset: 0xA0
	public EStationaryAnimationType Animation; //Field offset: 0xA8
	public Transform OperatorTransform; //Field offset: 0xB0
	public Transform Hinge; //Field offset: 0xB8
	public Transform TripodView; //Field offset: 0xC0
	public Transform TripodAnchor; //Field offset: 0xC8
	public Transform WeaponTransform; //Field offset: 0xD0
	public float PitchToleranceUp; //Field offset: 0xD8
	public float PitchToleranceDown; //Field offset: 0xDC
	public float YawTolerance; //Field offset: 0xE0
	public ItemController ItemController; //Field offset: 0xE8
	public WeaponMachinery Machinery; //Field offset: 0xF0
	public MgBelt Belt; //Field offset: 0xF8
	public MgBelt BeltEmpty; //Field offset: 0x100
	private Coroutine _resetCoroutine; //Field offset: 0x108
	private Transform _cachedTransform; //Field offset: 0x110
	[SerializeField]
	private FollowerCullingObject _cullingObject; //Field offset: 0x118
	private string _operatorId; //Field offset: 0x120
	private Vector3 _initialWeaponPosition; //Field offset: 0x128
	private Quaternion _initialWeaponRotation; //Field offset: 0x134
	[CompilerGenerated]
	private int <ObserverMagazineAmmoCount>k__BackingField; //Field offset: 0x144
	[CompilerGenerated]
	private bool <Locked>k__BackingField; //Field offset: 0x148

	public override GameObject GameObject
	{
		 get { } //Length: 78
	}

	public override string Id
	{
		 get { } //Length: 5
	}

	public override string IdEditable
	{
		 get { } //Length: 5
		 set { } //Length: 82
	}

	public Vector2 InitialOrientation
	{
		 get { } //Length: 19
	}

	public Item Item
	{
		 get { } //Length: 33
	}

	public bool Locked
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public int ObserverMagazineAmmoCount
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public string OperatorId
	{
		 get { } //Length: 8
	}

	public Vector3 OperatorPosition
	{
		 get { } //Length: 141
	}

	public Vector2 Orientation
	{
		 get { } //Length: 53
	}

	public float Pitch
	{
		 get { } //Length: 197
	}

	public Vector2 PitchLimit
	{
		 get { } //Length: 19
	}

	public EDoorState State
	{
		 get { } //Length: 21
	}

	public override string TypeKey
	{
		 get { } //Length: 49
	}

	public float Yaw
	{
		 get { } //Length: 136
	}

	public Vector2 YawLimit
	{
		 get { } //Length: 25
	}

	public StationaryWeapon() { }

	[CompilerGenerated]
	private Transform <Awake>b__75_0() { }

	[ContextMenu("Align to ground")]
	public void AlignToGround() { }

	public LootPointParameters AsLootPointParameters() { }

	private void Awake() { }

	public override GameObject get_GameObject() { }

	public override string get_Id() { }

	public override string get_IdEditable() { }

	public Vector2 get_InitialOrientation() { }

	public Item get_Item() { }

	[CompilerGenerated]
	public bool get_Locked() { }

	[CompilerGenerated]
	public int get_ObserverMagazineAmmoCount() { }

	public string get_OperatorId() { }

	public Vector3 get_OperatorPosition() { }

	public Vector2 get_Orientation() { }

	public float get_Pitch() { }

	public Vector2 get_PitchLimit() { }

	public EDoorState get_State() { }

	public override string get_TypeKey() { }

	public float get_Yaw() { }

	public Vector2 get_YawLimit() { }

	public InteractionParameters GetInteractionParameters() { }

	public int GetMagazineCount() { }

	public void Hide(bool isAI) { }

	public void Init(ItemController itemController) { }

	public void InitMagazine() { }

	public bool IsAvailable(string profileId) { }

	public bool IsOperator(string profileId) { }

	public void ManualUpdate(Vector3 position, Quaternion rotation) { }

	public void ObservedShot() { }

	private void OnDestroy() { }

	public virtual void OnDrawGizmosSelected() { }

	public void OnRotation() { }

	public void OnValidate() { }

	[IteratorStateMachine(typeof(<ResetCoroutine>d__81))]
	private IEnumerator ResetCoroutine() { }

	public override void set_IdEditable(string value) { }

	[CompilerGenerated]
	public void set_Locked(bool value) { }

	[CompilerGenerated]
	public void set_ObserverMagazineAmmoCount(int value) { }

	public void SetOperator(string visitorId, bool isAI = false) { }

	public void SetPivots(TransformLinks hierarchy) { }

	public void Shot() { }

	public void Show() { }

	public void Unlock(string profileId) { }

	public void UpdateJoints() { }

	private void VisibilityChanged(bool isVisible) { }

}

