namespace EFT.UI.Matchmaker;

public enum EMatchingStage
{
	None = 0,
	GameWorldCreating = 1,
	BundlesLoading = 2,
	PoolsCreating = 3,
	MapLoading = 4,
	DataCaching = 5,
	PlayersSearching = 6,
	ServerSearching = 7,
	ServerStartAwaiting = 8,
	GamePreparing = 9,
	ServerConnecting = 10,
	ServerResponseAwaiting = 11,
	LootBundlesLoading = 12,
	LootPoolsCreating = 13,
	SessionStartAwaiting = 14,
	LocalGameStarting = 15,
	PlayersAwaiting = 16,
	SynchronizationWithOtherPlayers = 17,
	GameLeaving = 18,
}

