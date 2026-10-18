namespace EFT.InventoryLogic;

public static class CurrencyUtil
{
	internal sealed class CurrencyData
	{
		public readonly ECurrencyType Type; //Field offset: 0x10
		public readonly string Char; //Field offset: 0x18
		public readonly string Name; //Field offset: 0x20
		public readonly MongoID Id; //Field offset: 0x28
		[CanBeNull]
		public readonly List FallbackIds; //Field offset: 0x40
		private readonly HashSet _allIds; //Field offset: 0x48

		public CurrencyData(ECurrencyType type, string character, string name, string id, List fallbackIds = null) { }

		public bool HasId(MongoID id) { }

	}

	public static readonly MongoID ROUBLE_ID; //Field offset: 0x0
	public static readonly MongoID DOLLAR_ID; //Field offset: 0x18
	public static readonly MongoID EURO_ID; //Field offset: 0x30
	public static readonly MongoID GP_ID; //Field offset: 0x48
	public static readonly MongoID ROUBLE_STACK_ID; //Field offset: 0x60
	public static readonly Dictionary CurrencyColors; //Field offset: 0x78
	public static readonly Dictionary CurrencyIndex; //Field offset: 0x80
	private static readonly Dictionary _idTypeIndex; //Field offset: 0x88
	private static readonly Dictionary _nameTypeIndex; //Field offset: 0x90
	private static readonly Dictionary _idCharIndex; //Field offset: 0x98
	private static readonly List _names; //Field offset: 0xA0
	private static bool _readyToUse; //Field offset: 0xA8

	public static IEnumerable CurrencyNames
	{
		 get { } //Length: 87
	}

	private static CurrencyUtil() { }

	public static IEnumerable get_CurrencyNames() { }

	[CanBeNull]
	public static string GetCurrencyChar(ECurrencyType currencyType) { }

	[CanBeNull]
	public static string GetCurrencyCharById(MongoID templateId) { }

	public static MongoID GetCurrencyId(ECurrencyType currencyType) { }

	public static string GetCurrencyString(ECurrencyType currencyType) { }

	public static ECurrencyType GetCurrencyTypeById(MongoID id) { }

	public static ECurrencyType GetCurrencyTypeByName(string name) { }

	public static void Init() { }

	public static bool IsCurrencyId(MongoID id) { }

	public static bool IsValidRagfairCurrency(ECurrencyType currencyType) { }

	public static bool TryGetCurrencyType(Nullable id, out ECurrencyType type) { }

}

