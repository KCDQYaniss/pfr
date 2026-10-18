namespace EFT;

[GenerateBinarySerialization]
public sealed class TraderServiceAvailabilityData
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__8_0; //Field offset: 0x8
		public static Func <>9__8_1; //Field offset: 0x10
		public static Func <>9__9_0; //Field offset: 0x18
		public static Func <>9__9_1; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal string <.ctor>b__8_0(SubService subService) { }

		internal int <.ctor>b__8_1(SubService subService) { }

		internal string <.ctor>b__9_0(SubService subService) { }

		internal int <.ctor>b__9_1(SubService subService) { }

	}

	public MongoID TraderId; //Field offset: 0x10
	public ETraderServiceType ServiceType; //Field offset: 0x28
	public bool CanAfford; //Field offset: 0x2C
	public bool WasPurchasedInThisRaid; //Field offset: 0x2D
	public Dictionary ItemsToPay; //Field offset: 0x30
	public MongoID[] UniqueItems; //Field offset: 0x38
	public Dictionary SubServices; //Field offset: 0x40

	public TraderServiceAvailabilityData() { }

	public TraderServiceAvailabilityData(ETraderServiceType serviceType, MongoID traderId, bool canAfford, bool wasPurchasedInThisRaid, Dictionary itemsToPay, MongoID[] uniqueItems, IEnumerable subServices) { }

	public TraderServiceAvailabilityData(ServiceData serviceData) { }

}

