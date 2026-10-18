namespace EFT.UI;

[IsReadOnly]
public struct CharacterSelectionSlotViewModel
{
	private const string REGULAR_TITLE_KEY = "CharacterSelection/Title/Regular"; //Field offset: 0x0
	private const string TOOLTIP_UNAVAILABLE_KEY = "CharacterSelection/Tooltip/Unavailable"; //Field offset: 0x0
	private const string TOOLTIP_CURRENT_PROFILE_KEY = "CharacterSelection/Tooltip/CurrentProfile"; //Field offset: 0x0
	private const string CURRENT_ACTION_KEY = "CharacterSelection/Current"; //Field offset: 0x0
	private const string LOCKED_ACTION_KEY = "CharacterSelection/Locked"; //Field offset: 0x0
	private const string UNAVAILABLE_ACTION_KEY = "CharacterSelection/Unavailable"; //Field offset: 0x0
	private const string SELECT_ACTION_KEY = "CharacterSelection/Select"; //Field offset: 0x0
	private const string AVAILABLE_FOR_PURCHASE_ACTION_KEY = "CharacterSelection/AvailableForPurchase"; //Field offset: 0x0
	private const string PVE_DETAILS_KEY = "CharacterSelection/Slot/Pve/Details"; //Field offset: 0x0
	private const string REGULAR_DETAILS_KEY = "CharacterSelection/Slot/Regular/Details"; //Field offset: 0x0
	private const string MODE_TYPE_SEASONAL_KEY = "CharacterSelection/ModeType/Seasonal"; //Field offset: 0x0
	private const string MODE_TYPE_REGULAR_KEY = "CharacterSelection/ModeType/Regular"; //Field offset: 0x0
	private const string SEASONAL_TITLE_KEY = "CharacterSelection/Title/Seasonal"; //Field offset: 0x0
	private const string PVE_TITLE_KEY = "CharacterSelection/Title/Pve"; //Field offset: 0x0
	private const string SEASONAL_DETAILS_KEY = "CharacterSelection/Slot/Seasonal/Details"; //Field offset: 0x0
	public readonly string ModeTitle; //Field offset: 0x0
	public readonly string ModeType; //Field offset: 0x8
	public readonly string CharacterDescription; //Field offset: 0x10
	public readonly bool ActionAvailable; //Field offset: 0x18
	public readonly string ActionText; //Field offset: 0x20
	public readonly string DisabledTooltipKey; //Field offset: 0x28
	public readonly bool PurchaseVisible; //Field offset: 0x30
	public readonly bool PurchaseAvailable; //Field offset: 0x31
	public readonly string PurchaseText; //Field offset: 0x38

	private CharacterSelectionSlotViewModel(string modeTitle, string modeType, string characterDescription, string actionText, bool actionAvailable, string disabledTooltipKey, bool purchaseVisible, bool purchaseAvailable, string purchaseText) { }

	private static bool CanPurchase(EGameMode gameMode, CharacterSelectionProfileData profileData) { }

	public static CharacterSelectionSlotViewModel Create(EGameMode gameMode, CharacterSelectionProfileData profileData, bool isCurrent, ExtensionsSettings extensionsSettings) { }

	private static string GetActionText(CharacterSelectionProfileData profileData, bool isCurrent) { }

	private static string GetCharacterDescription(EGameMode gameMode) { }

	private static string GetDisabledTooltipKey(bool actionAvailable, bool isCurrent) { }

	private static string GetModeTitle(EGameMode gameMode) { }

	private static string GetModeType(EGameMode gameMode) { }

}

