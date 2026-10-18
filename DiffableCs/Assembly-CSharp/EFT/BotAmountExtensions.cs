namespace EFT;

[Extension]
public static class BotAmountExtensions
{
	private const int BOT_AMOUNT_EMPTY = 0; //Field offset: 0x0
	private const int BOT_AMOUNT_LOW = 15; //Field offset: 0x0
	private const int BOT_AMOUNT_MEDIUM = 20; //Field offset: 0x0
	private const int BOT_AMOUNT_HIGH = 25; //Field offset: 0x0
	private const int BOT_AMOUNT_HORDE = 35; //Field offset: 0x0

	[Extension]
	public static int ToBotAmountSlots(EBotAmount botDifficulty, int slotsMin, int slotsMax) { }

	[Extension]
	public static int ToMaxBotsCount(EBotAmount botAmount) { }

}

