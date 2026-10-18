namespace EFT.Dialogs;

public sealed class PurchaseServicePlayerLine : TraderDialogTextLine
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__11_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <GetDiscount>b__11_0(Item x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_0
	{
		public IDialogContext context; //Field offset: 0x10

		public <>c__DisplayClass0_0() { }

		internal bool <.ctor>b__0(SubService subService) { }

	}

	[CompilerGenerated]
	private readonly IReadOnlyList <Actions>k__BackingField; //Field offset: 0x40
	private readonly TraderServiceAvailabilityData _serviceData; //Field offset: 0x48
	private readonly InventoryController _inventoryController; //Field offset: 0x50
	private readonly string _selectedSubServiceId; //Field offset: 0x58
	[CompilerGenerated]
	private readonly DialogLineTextConstructor <LineTextConstructor>k__BackingField; //Field offset: 0x60

	public virtual IReadOnlyList Actions
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public virtual DialogLineTextConstructor LineTextConstructor
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public PurchaseServicePlayerLine(DialogLineTemplate template, IDialogContext context) { }

	private bool CheckCanPurchaseService() { }

	private DialogLineTextConstructor CreateLineConstructor() { }

	[CompilerGenerated]
	public virtual IReadOnlyList get_Actions() { }

	[CompilerGenerated]
	public virtual DialogLineTextConstructor get_LineTextConstructor() { }

	private float GetDiscount() { }

	public static string ItemsToPayToString(Dictionary itemsToPay, float discount = 1) { }

}

