namespace EFT.InventoryLogic.Operations;

public abstract class BattlePassOperation`1 : AbstractAsyncOperation, IMultipleItemsOperation, IInventoryOperation
{
	internal abstract class BattlePassOperationCommand : CommandWithOwner
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func <>9__8_0; //Field offset: 0x0

			private static <>c() { }

			public <>c() { }

			internal DestroyedItem <.ctor>b__8_0(KeyValuePair item) { }

		}

		[JsonProperty("battlePassId")]
		public readonly MongoID BattlePassId; //Field offset: 0x0
		[JsonProperty("items")]
		public readonly IEnumerable Items; //Field offset: 0x0

		[JsonProperty("Action")]
		public string Action
		{
			 get { } //Length: 20
		}

		protected abstract string ActionName
		{
			 get { } //Length: 0
		}

		public virtual bool Queued
		{
			 get { } //Length: 3
		}

		protected BattlePassOperationCommand(BattlePassOperationResult result, OwnerInfo owner) { }

		public string get_Action() { }

		protected abstract string get_ActionName() { }

		public virtual bool get_Queued() { }

	}

	protected readonly TResult Result; //Field offset: 0x0

	private override IEnumerable EFT.InventoryLogic.Operations.IMultipleItemsOperation.Items
	{
		private get { } //Length: 84
	}

	protected BattlePassOperation`1(ushort id, TResult battlePassResult) { }

	public virtual void Dispose() { }

	private override IEnumerable EFT.InventoryLogic.Operations.IMultipleItemsOperation.get_Items() { }

	protected virtual Task ExecuteInternal() { }

	public virtual InventoryOperationDescriptor ToDescriptor() { }

}

