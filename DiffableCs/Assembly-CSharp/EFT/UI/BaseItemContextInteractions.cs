namespace EFT.UI;

public abstract class BaseItemContextInteractions : ContextInteractions
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_0
	{
		public BaseItemContextInteractions <>4__this; //Field offset: 0x10
		public Action handler; //Field offset: 0x18

		public <>c__DisplayClass22_0() { }

		internal void <SubscribeOnEffectsChange>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass30_0
	{
		public BaseItemContextInteractions <>4__this; //Field offset: 0x10
		public Action unsubscriber; //Field offset: 0x18

		public <>c__DisplayClass30_0() { }

		internal void <SubscribeOnRedraw>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_0
	{
		public BaseItemContextInteractions <>4__this; //Field offset: 0x10
		public Action unsubscriber; //Field offset: 0x18

		public <>c__DisplayClass31_0() { }

		internal void <SubscribeOnClose>b__0(ItemEventArgs activeEvent) { }

		internal void <SubscribeOnClose>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass32_0
	{
		public IItemOwner itemOwner; //Field offset: 0x10
		public Action handler; //Field offset: 0x18

		public <>c__DisplayClass32_0() { }

		internal void <SubscribeOnActiveEvents>b__0() { }

	}

	[CompilerGenerated]
	private struct <Disassemble>d__58 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BaseItemContextInteractions <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <EquipItem>d__60 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BaseItemContextInteractions <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PutInStash>d__46 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BaseItemContextInteractions <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SetPinLock>d__70 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BaseItemContextInteractions <>4__this; //Field offset: 0x20
		public EItemPinLockState state; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ToggleItem>d__53 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public BaseItemContextInteractions <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Uninstall>d__45 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BaseItemContextInteractions <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UnloadAmmo>d__47 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BaseItemContextInteractions <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UnloadWeapon>d__59 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BaseItemContextInteractions <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UnpackItem>d__36 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BaseItemContextInteractions <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private static Action OnRedrawByItemRequired; //Field offset: 0x0
	[CompilerGenerated]
	private static Action OnCloseByItemRequired; //Field offset: 0x8
	protected readonly Item Item; //Field offset: 0x38
	protected readonly ItemContext ItemContext; //Field offset: 0x40
	protected readonly ItemUiContext ItemUiContext; //Field offset: 0x48
	private readonly Action _onCloseAction; //Field offset: 0x50
	private readonly ItemContextInteractionsSwitcher _contextInteractionsSwitcher; //Field offset: 0x58

	public static event Action OnCloseByItemRequired
	{
		[CompilerGenerated]
		 add { } //Length: 304
		[CompilerGenerated]
		 remove { } //Length: 304
	}

	public static event Action OnRedrawByItemRequired
	{
		[CompilerGenerated]
		 add { } //Length: 293
		[CompilerGenerated]
		 remove { } //Length: 293
	}

	public virtual IEnumerable AllInteractions
	{
		 get { } //Length: 20
	}

	protected abstract IEnumerable AvailableInteractions
	{
		 get { } //Length: 0
	}

	public virtual bool HasInteractions
	{
		 get { } //Length: 204
	}

	protected BaseItemContextInteractions(ItemContext itemContext, ItemUiContext itemUiContext, Action closeAction) { }

	private void ActiveEventsHandler(ItemEventArgs activeEvent) { }

	[CompilerGenerated]
	public static void add_OnCloseByItemRequired(Action value) { }

	[CompilerGenerated]
	public static void add_OnRedrawByItemRequired(Action value) { }

	private void AddOffer() { }

	private void AddToFavorites() { }

	private void ButtonItemOverlook() { }

	private bool CanDiscard() { }

	private bool CheckContainerForUnremovableItems(CompoundItem compoundItem) { }

	private void CheckMagazine() { }

	protected void CloseHandler(string itemId) { }

	[AsyncStateMachine(typeof(<Disassemble>d__58))]
	private Task Disassemble() { }

	private void DiscardItem() { }

	private void EditBuild() { }

	private void EditTag() { }

	[AsyncStateMachine(typeof(<EquipItem>d__60))]
	private Task EquipItem() { }

	private void ExamineItem() { }

	protected virtual void ExecuteInteractionInternal(EItemInfoButton interaction) { }

	private void FilterSearch() { }

	private void FoldItem() { }

	public virtual IEnumerable get_AllInteractions() { }

	protected abstract IEnumerable get_AvailableInteractions() { }

	public virtual bool get_HasInteractions() { }

	private void HealAll() { }

	protected void InspectItem() { }

	protected override void Insure() { }

	private void InventoryLockHandler(bool isLocked) { }

	public virtual bool IsActive(EItemInfoButton button) { }

	public virtual IResult IsInteractive(EItemInfoButton button) { }

	private void LinkedSearch() { }

	private void Metrics() { }

	private void NeededSearch() { }

	private void OpenItem() { }

	protected override void PlayTape() { }

	[AsyncStateMachine(typeof(<PutInStash>d__46))]
	protected Task PutInStash() { }

	private void ReadNote() { }

	protected void RedrawHandler(string itemId) { }

	[CompilerGenerated]
	public static void remove_OnCloseByItemRequired(Action value) { }

	[CompilerGenerated]
	public static void remove_OnRedrawByItemRequired(Action value) { }

	private void RemoveFromFavorites() { }

	private void RepairItem() { }

	public static void RequestCloseForItem(string templateId) { }

	protected override void RequestRedrawForItem() { }

	public static void RequestRedrawForItem(string templateId) { }

	private void ResetTag() { }

	protected override void Search(RagfairSearch ragfairSearch) { }

	[AsyncStateMachine(typeof(<SetPinLock>d__70))]
	private Task SetPinLock(EItemPinLockState state) { }

	private void ShowPlayerProfile() { }

	protected void StopTape() { }

	private Action SubscribeOnActiveEvents(Action handler) { }

	public virtual Action SubscribeOnClose() { }

	public Action SubscribeOnEffectsChange(Action handler) { }

	public virtual Action SubscribeOnRedraw() { }

	[AsyncStateMachine(typeof(<ToggleItem>d__53))]
	private void ToggleItem() { }

	private void TopUpItem() { }

	[AsyncStateMachine(typeof(<Uninstall>d__45))]
	private Task Uninstall() { }

	[AsyncStateMachine(typeof(<UnloadAmmo>d__47))]
	private Task UnloadAmmo() { }

	[AsyncStateMachine(typeof(<UnloadWeapon>d__59))]
	private Task UnloadWeapon() { }

	[AsyncStateMachine(typeof(<UnpackItem>d__36))]
	private Task UnpackItem() { }

	private void UseAll() { }

	private void UseItem() { }

	private void ViewMap() { }

}

