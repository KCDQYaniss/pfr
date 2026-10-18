namespace EFT.NextObservedPlayer;

public sealed class ObservedPlayerInventoryController : InventoryController, IOperationHandler, IDisposable
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public TaskCompletionSource weaponOut; //Field offset: 0x10

		public <>c__DisplayClass16_0() { }

		internal void <AwaitHandsChangesBeforeThrow>g__Handler|0(Item item) { }

	}

	[CompilerGenerated]
	private struct <AwaitHandsChangesBeforeThrow>d__16 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ObservedPlayerInventoryController <>4__this; //Field offset: 0x20
		private <>c__DisplayClass16_0 <>8__1; //Field offset: 0x28
		public Callback callback; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly IPlayer _player; //Field offset: 0x170
	private readonly ObservedPlayerInventoryInfo _profile; //Field offset: 0x178
	private readonly ObservedPlayerHandsController _handsController; //Field offset: 0x180
	private readonly GameWorld _gameWorld; //Field offset: 0x188
	private readonly Grid _temporaryGrid; //Field offset: 0x190

	public ObservedPlayerInventoryController(IPlayer player, ObservedPlayerInventoryInfo profile, ObservedPlayerHandsController handsController) { }

	[CompilerGenerated]
	private void <ApplySpectatorInventoryOperation>b__10_0(IResult result) { }

	public void ApplyDeath(CreateCorpsePacket packet) { }

	private void ApplyMedResource(MedEffectResourceCommandMessage commandMessage) { }

	private void ApplySpectatorInventoryOperation(SpectatorInventoryOperationCommandMessage command) { }

	private void ApplyThrowItemAsLoot(ThrowPatronAsLootCommandMessage commandMessage) { }

	[AsyncStateMachine(typeof(<AwaitHandsChangesBeforeThrow>d__16))]
	private Task AwaitHandsChangesBeforeThrow(Callback callback) { }

	public override void Dispose() { }

	private override OperationCreationResult EFT.InventoryLogic.IOperationHandler.CreateOperationFromDescriptor(InventoryOperationDescriptor descriptor) { }

	public void Execute(ICommandMessage commandMessage) { }

	public void ExecuteSpectator(ICommandMessage commandMessage) { }

	protected virtual IContainer FindContainer(ContainerDescriptor container) { }

	public virtual Option FindItemById(MongoID itemId, bool checkDistance = true, bool checkOwnership = true) { }

	public virtual void OutProcess(Item item, ItemAddress from, ItemAddress to, IInventoryOperation operation, Callback callback) { }

	public virtual bool TryFindItem(string itemId, out Item item) { }

}

