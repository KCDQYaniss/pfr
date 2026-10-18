namespace EFT.UI;

[UsedImplicitly]
public sealed class EquipmentBuildPanel : UIElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__12_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <SavePreset>b__12_0() { }

	}

	[CompilerGenerated]
	private struct <SavePreset>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EquipmentBuildPanel <>4__this; //Field offset: 0x20
		private CancellationToken <cancellationToken>5__2; //Field offset: 0x28
		private EditBuildNameWindowContext <buildWindowContext>5__3; //Field offset: 0x30
		private MongoID <nextBuildId>5__4; //Field offset: 0x38
		private string <newBuildName>5__5; //Field offset: 0x50
		private EquipmentBuild <buildToSave>5__6; //Field offset: 0x58
		private Task <acceptResult>5__7; //Field offset: 0x60
		private EquipmentBuild <foundBuild>5__8; //Field offset: 0x68
		private TaskAwaiter <>u__1; //Field offset: 0x70
		private TaskAwaiter <>u__2; //Field offset: 0x78
		private TaskAwaiter <>u__3; //Field offset: 0x80

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private Button _presetSaveButton; //Field offset: 0x70
	[SerializeField]
	private Button _presetLoadButton; //Field offset: 0x78
	[SerializeField]
	private TextMeshProUGUI _lastPresetName; //Field offset: 0x80
	private readonly BindableEvent _onShowEquipmentBuilds; //Field offset: 0x88
	private EquipmentBuildsStorage _buildsStorage; //Field offset: 0x90
	private ItemUiContext _itemUiContext; //Field offset: 0x98
	private Profile _profile; //Field offset: 0xA0
	private InventoryEquipment _equipmentToSave; //Field offset: 0xA8

	public IBindableEvent OnShowEquipmentBuilds
	{
		 get { } //Length: 8
	}

	public EquipmentBuildPanel() { }

	[CompilerGenerated]
	private void <Awake>b__10_0() { }

	[UsedImplicitly]
	private void Awake() { }

	public IBindableEvent get_OnShowEquipmentBuilds() { }

	[AsyncStateMachine(typeof(<SavePreset>d__12))]
	private Task SavePreset() { }

	public void SetEquipmentToSave(InventoryEquipment equipment) { }

	public void Show(EquipmentBuildsStorage buildsStorage, InventoryEquipment inventoryEquipment, Profile profile) { }

}

