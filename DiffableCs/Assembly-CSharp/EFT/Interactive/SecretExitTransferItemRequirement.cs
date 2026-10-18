namespace EFT.Interactive;

public sealed class SecretExitTransferItemRequirement : ExfiltrationRequirement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public SecretExitTransferItemRequirement <>4__this; //Field offset: 0x10
		public ExfiltrationPoint point; //Field offset: 0x18

		public <>c__DisplayClass2_0() { }

		internal void <Start>b__0(AddItemEventArgs addItemEventArgs) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public Player player; //Field offset: 0x10

		public <>c__DisplayClass3_0() { }

		internal void <TransferExitItem>b__0(IResult error) { }

	}

	private ItemController _itemController; //Field offset: 0x30

	public SecretExitTransferItemRequirement() { }

	public virtual bool Met(Player player, ExfiltrationPoint point) { }

	public virtual void OnDestroy() { }

	public virtual void Start(ExfiltrationPoint point) { }

	public bool TransferExitItem(Player player, Item item) { }

}

