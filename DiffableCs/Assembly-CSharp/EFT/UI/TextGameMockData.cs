namespace EFT.UI;

public static class TextGameMockData
{
	private const string TARGRAD_TALES = "TarGrad Tales"; //Field offset: 0x0
	private const string BATTLE_FIELD = "TextGameLocation/BattleField"; //Field offset: 0x0
	private const string VILLAGE = "TextGameLocation/Village"; //Field offset: 0x0
	private const string TEMPLE = "TextGameLocation/Temple"; //Field offset: 0x0
	private const string FORT = "TextGameLocation/Fort"; //Field offset: 0x0
	private const string SWAMP = "TextGameLocation/Swamp"; //Field offset: 0x0
	private const string WITCH_HOUSE = "TextGameLocation/WitchHouse"; //Field offset: 0x0
	private const string BURNT_VILLAGE = "TextGameLocation/BurntVillage"; //Field offset: 0x0
	private const string TARGRAD = "TextGameLocation/Targard"; //Field offset: 0x0
	public static readonly MappedStatVariable MockLocationData; //Field offset: 0x0
	public static readonly Dictionary Locations; //Field offset: 0x8

	private static TextGameMockData() { }

	public static TextGameStatsData GetMockData() { }

}

