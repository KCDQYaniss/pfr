namespace EFT.UI;

public class InventoryScreenQuickAccessPanel : UIInputNode
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Callback <>9__27_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <ShowGrenadeSelector>b__27_0(Result callback) { }

	}

	[CompilerGenerated]
	private struct <ShowAmmoSelector>d__34 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public InventoryScreenQuickAccessPanel <>4__this; //Field offset: 0x20
		public EBoundItem slot; //Field offset: 0x28
		public IEnumerable ammo; //Field offset: 0x30
		public InventoryController controller; //Field offset: 0x38
		public Weapon weapon; //Field offset: 0x40
		private BoundSlotView <slotView>5__2; //Field offset: 0x48
		private TaskAwaiter <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowGrenadeSelector>d__27 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public InventoryScreenQuickAccessPanel <>4__this; //Field offset: 0x20
		public EBoundItem slot; //Field offset: 0x28
		public ThrowWeap grenade; //Field offset: 0x30
		public InventoryController controller; //Field offset: 0x38
		private QuickSlotView <slotView>5__2; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowHealingSelector>d__28 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public InventoryScreenQuickAccessPanel <>4__this; //Field offset: 0x20
		public EBoundItem boundIndex; //Field offset: 0x28
		public Item item; //Field offset: 0x30
		public IHealthController healthController; //Field offset: 0x38
		public List limbs; //Field offset: 0x40
		private BoundItemView <view>5__2; //Field offset: 0x48
		private TaskAwaiter <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal class BoundItemViewDictionary : SerializableEnumDictionary
	{

		public BoundItemViewDictionary() { }

	}

	internal class BoundSlotViewDictionary : SerializableEnumDictionary
	{

		public BoundSlotViewDictionary() { }

	}

	[CompilerGenerated]
	private bool <IsDisabled>k__BackingField; //Field offset: 0x80
	[SerializeField]
	private FastAccessGrenadeItemView _grenadeSlot; //Field offset: 0x88
	[SerializeField]
	private BoundSlotViewDictionary _boundSlots; //Field offset: 0x90
	[SerializeField]
	private BoundItemViewDictionary _boundItems; //Field offset: 0x98
	[SerializeField]
	private HealingLimbSelector healingSelector; //Field offset: 0xA0
	[SerializeField]
	private AmmoSelector ammoSelector; //Field offset: 0xA8
	[SerializeField]
	private GrenadeSelector grenadeSelector; //Field offset: 0xB0
	private BattleUIComponentAnimation _animation; //Field offset: 0xB8
	private GamePlayerOwner _playerOwner; //Field offset: 0xC0
	private InsuranceCompany _insurance; //Field offset: 0xC8

	public bool IsDisabled
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public InventoryScreenQuickAccessPanel() { }

	public void AnimatedHide(float delaySeconds = 0) { }

	public void AnimatedShow(bool autohide) { }

	[CompilerGenerated]
	public bool get_IsDisabled() { }

	public void Hide() { }

	public void RefreshBoundSlotSelectView(Item itemInHads) { }

	public void RefreshSelection(Item itemInHands) { }

	[CompilerGenerated]
	public void set_IsDisabled(bool value) { }

	public void SetItemSelected(EBoundItem slot, bool isSelected) { }

	private void SetVisibility(bool visible) { }

	protected virtual ECursorResult ShouldLockCursor() { }

	public void Show(InventoryController inventoryController, ItemUiContext itemUiContext) { }

	public void Show(InventoryController inventoryController, ItemUiContext itemUiContext, GamePlayerOwner owner, InsuranceCompany insurance) { }

	[AsyncStateMachine(typeof(<ShowAmmoSelector>d__34))]
	private Task ShowAmmoSelector(EBoundItem slot, InventoryController controller, IEnumerable ammo, Weapon weapon) { }

	[AsyncStateMachine(typeof(<ShowGrenadeSelector>d__27))]
	private Task ShowGrenadeSelector(EBoundItem slot, InventoryController controller, ThrowWeap grenade) { }

	[AsyncStateMachine(typeof(<ShowHealingSelector>d__28))]
	private Task ShowHealingSelector(EBoundItem boundIndex, Item item, IHealthController healthController, List limbs) { }

	public void ShowQuickdrawGlowForPistols(bool show, float duration) { }

	protected virtual void TranslateAxes(ref float[] axes) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	private bool TryFindSlotWithItem(Item item, out EBoundItem result) { }

	private bool TryShowAmmoSelector() { }

	private bool TryShowSelectors(EBoundItem boundIndex, Item item) { }

	private void ValidateCollections() { }

}

