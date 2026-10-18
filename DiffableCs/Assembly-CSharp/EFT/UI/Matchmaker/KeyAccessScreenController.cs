namespace EFT.UI.Matchmaker;

public sealed class KeyAccessScreenController : EftMatchmakerScreenController
{
	public readonly InventoryController ItemController; //Field offset: 0x78
	public readonly IReadOnlyDictionary RequiredKeyCount; //Field offset: 0x80

	public virtual bool KeyScreen
	{
		 get { } //Length: 3
	}

	public virtual EEftScreenType ScreenType
	{
		 get { } //Length: 6
	}

	public KeyAccessScreenController(InventoryController itemController, IReadOnlyDictionary requiredKeyCount, MatchmakerPlayersController matchmakerPlayersController, EGameMode gameMode) { }

	public virtual bool get_KeyScreen() { }

	public virtual EEftScreenType get_ScreenType() { }

}

