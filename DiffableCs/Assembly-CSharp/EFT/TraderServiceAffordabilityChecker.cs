namespace EFT;

public sealed class TraderServiceAffordabilityChecker
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__4_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <CanAfford>b__4_0(ItemCounter itemCount) { }

	}

	public readonly ETraderServiceType ServiceType; //Field offset: 0x10
	private readonly Dictionary _itemsToPay; //Field offset: 0x18

	public TraderServiceAffordabilityChecker(ETraderServiceType serviceType) { }

	public bool CanAfford() { }

	public void CountItem(Item item) { }

}

