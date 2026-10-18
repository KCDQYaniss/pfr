namespace EFT.Hideout;

public sealed class HideoutArea : MonoBehaviour, IHideoutAreaWrapper, IInteractive
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__67_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal GameObject <RemoveProducedItems>b__67_0(KeyValuePair go) { }

	}

	[CompilerGenerated]
	private struct <GetVideocardInstaller>d__65 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public HideoutArea <>4__this; //Field offset: 0x20
		private VideocardInstaller <installer>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Init>d__52 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public HideoutArea <>4__this; //Field offset: 0x28
		public AreaData areaData; //Field offset: 0x30
		public HideoutCustomizationController customizationController; //Field offset: 0x38
		public InventoryController inventoryController; //Field offset: 0x40
		public Profile profile; //Field offset: 0x48
		private TaskAwaiter <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <InitVideocardInstaller>d__66 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public VideocardInstaller installer; //Field offset: 0x20
		public HideoutArea <>4__this; //Field offset: 0x28
		private PermanentProducer <permanentProducer>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SetupItem>d__64 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public GameObject spawnedObject; //Field offset: 0x20
		public Item item; //Field offset: 0x28
		private Rigidbody <spawnedRigidbody>5__2; //Field offset: 0x30
		private BoxCollider <resultCollider>5__3; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpawnProducedItems>d__63 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Item[] items; //Field offset: 0x20
		public HideoutArea <>4__this; //Field offset: 0x28
		private ObjectsFactory <factory>5__2; //Field offset: 0x30
		private List <tasks>5__3; //Field offset: 0x38
		private List <spawnedObjects>5__4; //Field offset: 0x40
		private Item[] <>7__wrap4; //Field offset: 0x48
		private int <>7__wrap5; //Field offset: 0x50
		private Item <item>5__7; //Field offset: 0x58
		private TaskAwaiter <>u__1; //Field offset: 0x60
		private TaskAwaiter <>u__2; //Field offset: 0x68

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SwitchAreaLevels>d__58 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public HideoutArea <>4__this; //Field offset: 0x28
		private VideocardInstaller <oldInstaller>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private HideoutAreaTrigger _trigger; //Field offset: 0x20
	[SerializeField]
	private Color _highlightColor; //Field offset: 0x28
	[SerializeField]
	private AreaTemplate _areaTemplate; //Field offset: 0x38
	[SerializeField]
	[Space]
	private HideoutAreaDefaultLevel _areaDefaultLevel; //Field offset: 0x40
	[SerializeField]
	private HideoutAreaLevel[] _areaLevels; //Field offset: 0x48
	[SerializeField]
	[Space]
	private CinemachineVirtualCamera _areaCamera; //Field offset: 0x50
	[SerializeField]
	private CinemachineVirtualCamera _specialActionCamera; //Field offset: 0x58
	[SerializeField]
	private Transform _areaIconPoint; //Field offset: 0x60
	[SerializeField]
	[Space]
	private HideoutDialogEntryPoint[] _dialogEntryPoints; //Field offset: 0x68
	private AreaData _data; //Field offset: 0x70
	private HideoutAreaLevel _currentLevel; //Field offset: 0x78
	private ELightingLevel _lightingLevel; //Field offset: 0x80
	private HideoutCustomizationController _customizationController; //Field offset: 0x88
	private readonly Dictionary _producedItems; //Field offset: 0x90
	private UIParent _disposableBindings; //Field offset: 0x98
	private VideocardInstaller _videocardInstaller; //Field offset: 0xA0
	[CompilerGenerated]
	private HideoutAreaStashController <StashController>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	private Action LightLevelChanged; //Field offset: 0xB0
	[CompilerGenerated]
	private AreaLevelAudio <AudioAmbiance>k__BackingField; //Field offset: 0xB8

	public event Action LightLevelChanged
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public override HideoutArea Area
	{
		 get { } //Length: 4
	}

	public CinemachineVirtualCamera AreaCamera
	{
		 get { } //Length: 5
	}

	public HideoutAreaDefaultLevel AreaDefaultLevel
	{
		 get { } //Length: 5
	}

	public Transform AreaIconPoint
	{
		 get { } //Length: 5
	}

	public HideoutAreaLevel[] AreaLevels
	{
		 get { } //Length: 5
	}

	public AreaTemplate AreaTemplate
	{
		 get { } //Length: 5
	}

	public private AreaLevelAudio AudioAmbiance
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public HideoutAreaLevel CurrentLevel
	{
		 get { } //Length: 5
	}

	public AreaData Data
	{
		 get { } //Length: 5
	}

	public HideoutDialogEntryPoint[] DialogEntryPoints
	{
		 get { } //Length: 5
	}

	public Color HighlightColor
	{
		 get { } //Length: 11
	}

	public Transform HighlightTransform
	{
		 get { } //Length: 29
		 set { } //Length: 107
	}

	public CinemachineVirtualCamera SpecialActionCamera
	{
		 get { } //Length: 5
	}

	public private HideoutAreaStashController StashController
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public HideoutArea() { }

	[CompilerGenerated]
	private void <Init>b__52_0(bool silent) { }

	[CompilerGenerated]
	private void <Init>b__52_1(bool isSelected) { }

	[CompilerGenerated]
	private void <Init>b__52_2() { }

	[CompilerGenerated]
	public void add_LightLevelChanged(Action value) { }

	private void AreaUpgradeHandler(bool silent) { }

	public void AttachVideocard(int count) { }

	private void CollectDialogEntryPoints() { }

	public void DetachVideocard() { }

	public void EnableIlluminationLevels(IReadOnlyCollection availableLevels) { }

	public override HideoutArea get_Area() { }

	public CinemachineVirtualCamera get_AreaCamera() { }

	public HideoutAreaDefaultLevel get_AreaDefaultLevel() { }

	public Transform get_AreaIconPoint() { }

	public HideoutAreaLevel[] get_AreaLevels() { }

	public AreaTemplate get_AreaTemplate() { }

	[CompilerGenerated]
	public AreaLevelAudio get_AudioAmbiance() { }

	public HideoutAreaLevel get_CurrentLevel() { }

	public AreaData get_Data() { }

	public HideoutDialogEntryPoint[] get_DialogEntryPoints() { }

	public Color get_HighlightColor() { }

	public Transform get_HighlightTransform() { }

	public CinemachineVirtualCamera get_SpecialActionCamera() { }

	[CompilerGenerated]
	public HideoutAreaStashController get_StashController() { }

	[AsyncStateMachine(typeof(<GetVideocardInstaller>d__65))]
	private Task GetVideocardInstaller() { }

	[AsyncStateMachine(typeof(<Init>d__52))]
	public void Init(AreaData areaData, InventoryController inventoryController, Profile profile, HideoutCustomizationController customizationController) { }

	[AsyncStateMachine(typeof(<InitVideocardInstaller>d__66))]
	private Task InitVideocardInstaller(VideocardInstaller installer) { }

	private void OnDestroy() { }

	private void OnHideoutCustomizationChanged(Dictionary customizationPack) { }

	[CompilerGenerated]
	public void remove_LightLevelChanged(Action value) { }

	public void RemoveProducedItems(IEnumerable items) { }

	[CompilerGenerated]
	private void set_AudioAmbiance(AreaLevelAudio value) { }

	public void set_HighlightTransform(Transform value) { }

	[CompilerGenerated]
	private void set_StashController(HideoutAreaStashController value) { }

	public void SetLightingLevel(ELightingLevel level) { }

	[AsyncStateMachine(typeof(<SetupItem>d__64))]
	private Task SetupItem(GameObject spawnedObject, Item item) { }

	[AsyncStateMachine(typeof(<SpawnProducedItems>d__63))]
	public Task SpawnProducedItems(Item[] items) { }

	[AsyncStateMachine(typeof(<SwitchAreaLevels>d__58))]
	private void SwitchAreaLevels() { }

	private void Update() { }

	private void UpdateAreaStatus() { }

	private void UpdateAudioSource(AreaLevelAudio source) { }

	private void UpdateLightStatus(ELightStatus lightStatus) { }

	private void UpdateVisibility(bool visible) { }

}

