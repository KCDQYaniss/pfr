namespace EFT;

public class PlayerBody : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__41_0; //Field offset: 0x8
		public static Func <>9__41_1; //Field offset: 0x10
		public static Func <>9__42_0; //Field offset: 0x18
		public static Func <>9__42_1; //Field offset: 0x20
		public static Func <>9__43_0; //Field offset: 0x28
		public static Func <>9__45_1; //Field offset: 0x30

		private static <>c() { }

		public <>c() { }

		internal bool <Init>b__41_0(SlotView x) { }

		internal Task <Init>b__41_1(SlotView x) { }

		internal bool <Init>b__42_0(SlotView x) { }

		internal Task <Init>b__42_1(SlotView x) { }

		internal IEnumerable <SetCustomizationSkin>b__45_1(LoddedSkin x) { }

		internal IEnumerable <SetCustomizationSkins>b__43_0(LoddedSkin x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass45_0
	{
		public EBodyModelPart partType; //Field offset: 0x10
		public ResourceKey bundle; //Field offset: 0x18
		public PlayerBody <>4__this; //Field offset: 0x20

		public <>c__DisplayClass45_0() { }

		internal void <SetCustomizationSkin>b__0() { }

	}

	internal interface ISlotModelPositionTuner
	{

		public void Init(GameObject prefab) { }

	}

	internal class SlotView
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func <>9__27_0; //Field offset: 0x8
			public static Action <>9__31_0; //Field offset: 0x10

			private static <>c() { }

			public <>c() { }

			internal Item <.ctor>b__27_0(Item item, Item itemInHands) { }

			internal void <CreateItemAsync>b__31_0() { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass27_0
		{
			public SlotView <>4__this; //Field offset: 0x10
			public EquipmentSlot equipmentSlot; //Field offset: 0x18
			public bool loadItemForce; //Field offset: 0x1C
			public Action <>9__3; //Field offset: 0x20

			public <>c__DisplayClass27_0() { }

			internal void <.ctor>b__1(Item item) { }

			internal void <.ctor>b__2(Item item) { }

			internal void <.ctor>b__3(Item child) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass31_0
		{
			public GameObject result; //Field offset: 0x10

			public <>c__DisplayClass31_0() { }

			internal void <CreateItemAsync>b__1() { }

		}

		[CompilerGenerated]
		private struct <CreateItemAsync>d__31 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public SlotView <>4__this; //Field offset: 0x20
			public Item item; //Field offset: 0x28
			private <>c__DisplayClass31_0 <>8__1; //Field offset: 0x30
			private CancellationToken <cancellationToken>5__2; //Field offset: 0x38
			private TaskAwaiter <>u__1; //Field offset: 0x40
			private TaskAwaiter <>u__2; //Field offset: 0x48

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		private readonly Slot _slot; //Field offset: 0x10
		private readonly PlayerBody _playerBody; //Field offset: 0x18
		[CanBeNull]
		private readonly Transform _bone; //Field offset: 0x20
		[CanBeNull]
		private readonly Slot _backpackSlot; //Field offset: 0x28
		[CanBeNull]
		private readonly Transform _alternativeHolsterBone; //Field offset: 0x30
		public Task LoadingJob; //Field offset: 0x38
		public Dress[] Dresses; //Field offset: 0x40
		public readonly BindableState MainDress; //Field offset: 0x48
		public readonly BindableState ParentedModel; //Field offset: 0x50
		private Item _item; //Field offset: 0x58
		private GameObject _model; //Field offset: 0x60
		private CancellationTokenSource _cancellationTokenSource; //Field offset: 0x68
		private Action _unsubscribe; //Field offset: 0x70
		private Action _innerUnsubscribe; //Field offset: 0x78
		private Action _backpackBindUnsubscribe; //Field offset: 0x80
		private Renderer[] _renderers; //Field offset: 0x88
		private ISlotModelPositionTuner _slotModelPositionTuner; //Field offset: 0x90
		[CompilerGenerated]
		private EquipmentSlot <EquipmentSlot>k__BackingField; //Field offset: 0x98

		public BindableState ContainedItem
		{
			 get { } //Length: 97
		}

		public private EquipmentSlot EquipmentSlot
		{
			[CompilerGenerated]
			 get { } //Length: 7
			[CompilerGenerated]
			private set { } //Length: 7
		}

		public GameObject Model
		{
			 get { } //Length: 5
		}

		public Renderer[] Renderers
		{
			 get { } //Length: 8
		}

		public SlotView(PlayerBody playerBody, Slot slot, Transform bone, EquipmentSlot equipmentSlot, Slot backpackSlot = null, Transform alternativeHolsterBone = null, bool loadItemForce = false) { }

		private void CancelCreating() { }

		public void ChangePositionAfterBackpackChanged() { }

		private void CreateAndParent(PlayerBody playerBody, GameObject model) { }

		[AsyncStateMachine(typeof(<CreateItemAsync>d__31))]
		private Task CreateItemAsync(Item item) { }

		public void DestroyCurrentModel() { }

		public void Dispose() { }

		public BindableState get_ContainedItem() { }

		[CompilerGenerated]
		public EquipmentSlot get_EquipmentSlot() { }

		public GameObject get_Model() { }

		public Renderer[] get_Renderers() { }

		private void LoadItem() { }

		[CompilerGenerated]
		private void set_EquipmentSlot(EquipmentSlot value) { }

		public void SetPositionTuner(ISlotModelPositionTuner tuner) { }

		private void UnsubscribeFromInner() { }

	}

	public static readonly EquipmentSlot[] SlotNames; //Field offset: 0x0
	[SerializeField]
	private Transform _meshTransform; //Field offset: 0x20
	public PlayerBones PlayerBones; //Field offset: 0x28
	public Skeleton SkeletonRootJoint; //Field offset: 0x30
	public Skeleton SkeletonHands; //Field offset: 0x38
	public BodyCustomization BodyCustomization; //Field offset: 0x40
	[CompilerGenerated]
	private bool <HaveHolster>k__BackingField; //Field offset: 0x48
	private int _layer; //Field offset: 0x4C
	private EPlayerSide _side; //Field offset: 0x50
	private bool _active; //Field offset: 0x54
	public readonly Dictionary BodySkins; //Field offset: 0x58
	private PluggableBone _watches; //Field offset: 0x60
	private BodyRenderer[] _bodyRenderers; //Field offset: 0x68
	private HoodedDress _hoodedDress; //Field offset: 0x70
	public bool IsRightLegPistolHolster; //Field offset: 0x78
	private InventoryEquipment _equipment; //Field offset: 0x80
	private Action _unsubscribeOnDispose; //Field offset: 0x88
	public readonly DictionaryListHydra SlotViews; //Field offset: 0x90
	[CompilerGenerated]
	private bool <HasIntergratedArmor>k__BackingField; //Field offset: 0x98
	public EClippingCustoms CustomizationClipping; //Field offset: 0x99
	[CompilerGenerated]
	private InventoryEquipment <Equipment>k__BackingField; //Field offset: 0xA0
	private BindableState _itemInHands; //Field offset: 0xA8
	public BindableState BodyCustomizationId; //Field offset: 0xB0
	public BindableState PlayerSide; //Field offset: 0xB8
	public BindableState PointOfView; //Field offset: 0xC0
	private string _playerProfileID; //Field offset: 0xC8
	private CompositeDisposable _dispose; //Field offset: 0xD0
	private bool _isYourPlayer; //Field offset: 0xD8

	public private InventoryEquipment Equipment
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private bool HasIntergratedArmor
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private bool HaveHolster
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public Transform MeshTransform
	{
		 get { } //Length: 5
	}

	private static PlayerBody() { }

	public PlayerBody() { }

	public void Dispose() { }

	[CompilerGenerated]
	public InventoryEquipment get_Equipment() { }

	[CompilerGenerated]
	public bool get_HasIntergratedArmor() { }

	[CompilerGenerated]
	public bool get_HaveHolster() { }

	public Transform get_MeshTransform() { }

	public Transform GetAlternativeHolsterBone(EquipmentSlot slotType) { }

	public void GetBodyRenderersNonAlloc(List preAllocatedRenederersList) { }

	public void GetRenderersNonAlloc(List preAllocatedRenederersList) { }

	public Transform GetSlotBone(EquipmentSlot slotType) { }

	public SlotView GetSlotViewByItem(Item item) { }

	public string GetSlotViewsDebugString() { }

	public Task Init(BodyCustomization customization, InventoryEquipment equipment, BindableState itemInHands, int layer, EPlayerSide playerSide, string playerProfileID = "", Dictionary alternativeBones = null, bool isYourPlayer = false) { }

	public Task Init(BodyCustomization customization, int layer, EPlayerSide playerSide) { }

	public bool IsVisible() { }

	private void OnApplicationQuit() { }

	public void OnSlotViewChanged() { }

	[CompilerGenerated]
	private void set_Equipment(InventoryEquipment value) { }

	[CompilerGenerated]
	private void set_HasIntergratedArmor(bool value) { }

	[CompilerGenerated]
	private void set_HaveHolster(bool value) { }

	private void SetCustomizationSkin(PlayerCustomizationChanged playerCustomizationChanged) { }

	private void SetCustomizationSkins(BodyCustomization customization, CustomizationSolver solver) { }

	public void SetSkin(KeyValuePair part, Skeleton skeleton) { }

	public void SetTemperatureForBody(float tempCelsio) { }

	private void SetWatches(WatchBundleInfo watchBundleInfo, Skeleton handsSkeleton) { }

	public void UpdateBodyCustomizationForObservedPlayer(bool isSpectateTarget) { }

	public void UpdatePlayerRenders(EPointOfView pointOfView, EPlayerSide side) { }

	private void ValidateHoodedDress(GameObject parentModel) { }

	public void ValidateHoodedDress(EquipmentSlot changedSlot) { }

}

