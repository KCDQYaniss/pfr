namespace EFT.UI;

public sealed class CommonUI : MonoBehaviourSingleton
{
	public EftBattleUIScreen EftBattleUIScreen; //Field offset: 0x20
	public MenuScreen MenuScreen; //Field offset: 0x28
	public ReconnectionScreen ReconnectionScreen; //Field offset: 0x30
	public CutsceneScreen CutsceneScreen; //Field offset: 0x38
	public TransferItemsScreen TransferItemsScreen; //Field offset: 0x40
	public InventoryScreen InventoryScreen; //Field offset: 0x48
	public ScavengerInventoryScreen ScavengerInventoryScreen; //Field offset: 0x50
	public WeaponModdingScreen WeaponModdingScreen; //Field offset: 0x58
	public EditBuildScreen EditBuildScreen; //Field offset: 0x60
	public SettingsScreen SettingsScreen; //Field offset: 0x68
	public HandbookScreen HandbookScreen; //Field offset: 0x70
	public ChatScreen ChatScreen; //Field offset: 0x78
	public HideoutScreenRear HideoutScreenRear; //Field offset: 0x80
	public HideoutScreenOverlay HideoutScreenOverlay; //Field offset: 0x88
	public TraderDialogScreen TraderDialogScreen; //Field offset: 0x90
	public TransferItemsInRaidScreen TransferItemsInRaidScreen; //Field offset: 0x98
	public CreditsScreen CreditsScreen; //Field offset: 0xA0
	public SpectatorScreen SpectatorScreen; //Field offset: 0xA8

	public CommonUI() { }

	public virtual void Awake() { }

	public virtual void OnDestroy() { }

}

