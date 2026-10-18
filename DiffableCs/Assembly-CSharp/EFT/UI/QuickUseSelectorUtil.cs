namespace EFT.UI;

public static class QuickUseSelectorUtil
{
	public static readonly IReadOnlyDictionary SlotBySelectCommandDictionary; //Field offset: 0x0
	public static readonly IReadOnlyDictionary SlotByConfirmCommandDictionary; //Field offset: 0x8

	private static QuickUseSelectorUtil() { }

	public static bool TryGetSelectDirection(ECommand command, out bool isNext) { }

}

