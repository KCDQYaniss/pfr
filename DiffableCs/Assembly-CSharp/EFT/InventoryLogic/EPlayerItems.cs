namespace EFT.InventoryLogic;

[Flags]
public enum EPlayerItems
{
	Stash = 1,
	Equipment = 2,
	QuestItems = 4,
	SortingTable = 8,
	HideoutStashes = 16,
	HideoutCustomizationStash = 32,
	All = 63,
	InRaidItems = 6,
	LobbyHandoverItems = 13,
	NonQuestItems = 59,
	NonQuestItemsExceptHideoutStashes = 11,
}

