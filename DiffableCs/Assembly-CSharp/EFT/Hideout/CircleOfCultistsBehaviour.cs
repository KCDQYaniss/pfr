namespace EFT.Hideout;

public class CircleOfCultistsBehaviour : BaseItemSlotsAreaBehaviour, ITooltipHideoutArea
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__5_0; //Field offset: 0x8
		public static Func <>9__5_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <CalculateExpBonus>b__5_0(Item i) { }

		internal string <CalculateExpBonus>b__5_1() { }

	}


	public CircleOfCultistsBehaviour() { }

	private void CalculateExpBonus() { }

	public virtual bool CanAcceptItem(Item item) { }

	public virtual void Init(AreaData area, AreaInfo profileInfo, InventoryController inventoryController, IEftSession session) { }

	public virtual void InstallConsumableItems(Item[] installedSupplies) { }

	protected virtual void OnInitializeItemInserted(Item item, int slotIndex) { }

	protected virtual void SetItems(Item[] installedSupplies) { }

	public override bool TryGetTooltipText(out string tooltip) { }

}

