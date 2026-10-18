namespace EFT.UI.Prestige;

[UsedImplicitly]
public sealed class RewardGameModeView : UIElement
{
	[SerializeField]
	private GameObject _onState; //Field offset: 0x70
	[SerializeField]
	private GameObject _offState; //Field offset: 0x78
	[SerializeField]
	private TMP_Text _modeName; //Field offset: 0x80

	public RewardGameModeView() { }

	public void Show(ERewardGameMode viewMode) { }

}

