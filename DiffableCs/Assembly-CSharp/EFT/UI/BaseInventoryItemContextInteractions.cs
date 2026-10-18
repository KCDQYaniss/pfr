namespace EFT.UI;

public abstract class BaseInventoryItemContextInteractions : BaseItemContextInteractions
{
	[CompilerGenerated]
	private struct <InstallMod>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BaseInventoryItemContextInteractions <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadWeapon>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BaseInventoryItemContextInteractions <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public const string HIDEOUT_WEAPON_MODIFICATION_REQUIRED = "bonus/UnlockWeaponModification_required"; //Field offset: 0x0
	private static readonly IReadOnlyList _interactions; //Field offset: 0x0
	private readonly CompoundItem[] _collections; //Field offset: 0x60

	protected virtual IEnumerable AvailableInteractions
	{
		 get { } //Length: 83
	}

	protected virtual IEnumerable SubInteractions
	{
		 get { } //Length: 371
	}

	private static BaseInventoryItemContextInteractions() { }

	protected BaseInventoryItemContextInteractions(ItemContext itemContext, ItemUiContext itemUiContext, CompoundItem[] collections, Action closeAction) { }

	public virtual void CreateSubInteractions(EItemInfoButton parentInteraction, ISubInteractionsWrapper subInteractionsWrapper) { }

	protected virtual void ExecuteInteractionInternal(EItemInfoButton interaction) { }

	protected virtual IEnumerable get_AvailableInteractions() { }

	protected virtual IEnumerable get_SubInteractions() { }

	[AsyncStateMachine(typeof(<InstallMod>d__12))]
	private Task InstallMod() { }

	[AsyncStateMachine(typeof(<LoadWeapon>d__11))]
	private Task LoadWeapon() { }

	private void ReloadWeapon() { }

}

