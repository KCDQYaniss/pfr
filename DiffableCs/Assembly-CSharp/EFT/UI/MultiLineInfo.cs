namespace EFT.UI;

public sealed class MultiLineInfo
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__6_0; //Field offset: 0x8
		public static Func <>9__6_1; //Field offset: 0x10
		public static Func <>9__6_2; //Field offset: 0x18
		public static Func <>9__6_3; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal bool <.ctor>b__6_0(ArmorSlot slot) { }

		internal int <.ctor>b__6_1(ArmorSlot armorSlot) { }

		internal int <.ctor>b__6_2(ArmorSlot armorSlot) { }

		internal bool <.ctor>b__6_3(ArmorSlot armorSlot) { }

	}

	public readonly string Header; //Field offset: 0x10
	public readonly SingleLineInfo[] Lines; //Field offset: 0x18

	public MultiLineInfo(ECurrencyType currencyType, ECharismaDiscountType charismaDiscountType, int charismaOldPrice, int charismaNewPrice, int totalCurrency, string standing = "") { }

	public MultiLineInfo(QuestChangeRequirement changeRequirement, float charismaDiscount, int freeChanges, int maxFreeChanges) { }

	public MultiLineInfo(float penetrationPower) { }

	public MultiLineInfo(CompoundItem item, bool onlyMoveAble) { }

	public MultiLineInfo(SingleLineInfo[] lineInfos, string headerText = null) { }

	[CompilerGenerated]
	internal static string <VisualizeArmorPenetrationChance>g__GetChance|8_0(float chance) { }

	private void FormCharismaDiscountData(ECurrencyType currencyType, ECharismaDiscountType charismaDiscountType, int charismaOldPrice, int charismaNewPrice, int totalCurrency, string standing, out string header, out SingleLineInfo[] lines) { }

	private string GetCurrencyColor(int currency, int totalCurrency, string type) { }

	private string VisualizeArmorPenetrationChance(int armorClass, float penetrationPower) { }

}

