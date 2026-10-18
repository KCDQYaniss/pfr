namespace EFT.Interactive;

public class LootableContainer : WorldInteractiveObject, IStaticLoot
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__35_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <SmoothDoorOpenCoroutine>b__35_0(Keyframe k) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_0
	{
		public InteractionResult interactionResult; //Field offset: 0x10
		public LootableContainer <>4__this; //Field offset: 0x18

		public <>c__DisplayClass22_0() { }

		internal void <Interact>b__0() { }

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static Func <0>__CreateReferenceTree; //Field offset: 0x0

	}

	[CompilerGenerated]
	private sealed class <SmoothDoorOpenCoroutine>d__35 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public LootableContainer <>4__this; //Field offset: 0x20
		public EDoorState state; //Field offset: 0x28
		public float speed; //Field offset: 0x2C
		private float <angle>5__2; //Field offset: 0x30
		private float <initialAngle>5__3; //Field offset: 0x34
		private float <time>5__4; //Field offset: 0x38
		private float <deltaAngle>5__5; //Field offset: 0x3C

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
		public <SmoothDoorOpenCoroutine>d__35(int <>1__state) { }

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

	[SerializeField]
	public ItemController ItemOwner; //Field offset: 0x178
	public string Template; //Field offset: 0x180
	public Vector3 ClosedPosition; //Field offset: 0x188
	public Vector3 OpenPosition; //Field offset: 0x194
	public string LootableContainersGroupId; //Field offset: 0x1A0
	[HideInInspector]
	public bool IsAlwaysLootable; //Field offset: 0x1A8
	[HideInInspector]
	public bool IsAlwaysSpawn; //Field offset: 0x1A9
	[HideInInspector]
	[SerializeField]
	private bool _isConverted; //Field offset: 0x1AA
	[FormerlySerializedAs("SpawnModifier")]
	public ELootableContainerSpawnType SpawnType; //Field offset: 0x1AC
	[Range(0, 100)]
	public byte SpawnChance; //Field offset: 0x1B0
	[ClassStateStorageIgnore]
	public List GameObjectsToDestroy; //Field offset: 0x1B8
	[CompilerGenerated]
	private bool <IsInitialized>k__BackingField; //Field offset: 0x1C0
	private ExtendedNodeReference[] _trees; //Field offset: 0x1C8
	[Header("Interactions")]
	[SerializeField]
	private EInteraction _openInteraction; //Field offset: 0x1D0
	[SerializeField]
	private EInteraction _closeInteraction; //Field offset: 0x1D1
	[Space(10)]
	public float ChanceModifier; //Field offset: 0x1D4
	[ClassStateStorageIgnore]
	public List FilterExtended; //Field offset: 0x1D8

	public override string Id
	{
		 get { } //Length: 5
		 set { } //Length: 82
	}

	public private bool IsInitialized
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	protected virtual Vector2 OpenSoundVolumeRange
	{
		 get { } //Length: 25
	}

	public ExtendedNodeReference[] Trees
	{
		 get { } //Length: 652
	}

	public virtual string TypeKey
	{
		 get { } //Length: 49
	}

	public LootableContainer() { }

	public LootPointParameters AsLootPointParameters() { }

	public override string get_Id() { }

	[CompilerGenerated]
	public bool get_IsInitialized() { }

	protected virtual Vector2 get_OpenSoundVolumeRange() { }

	public ExtendedNodeReference[] get_Trees() { }

	public virtual string get_TypeKey() { }

	public virtual InteractionParameters GetInteractionParameters(Vector3 playerPosition) { }

	public void Init(ItemController itemController) { }

	public virtual void Interact(InteractionResult interactionResult) { }

	protected virtual void ProcessOcclusion(BetterSource source, Vector3 position) { }

	[ContextMenu("Save OPEN position")]
	private void SaveOpenPos() { }

	[ContextMenu("Save CLOSED position")]
	private void SaveShutPos() { }

	public void set_Id(string value) { }

	[CompilerGenerated]
	private void set_IsInitialized(bool value) { }

	[IteratorStateMachine(typeof(<SmoothDoorOpenCoroutine>d__35))]
	protected virtual IEnumerator SmoothDoorOpenCoroutine(EDoorState state, bool isLocalInteraction, float speed = 1) { }

}

