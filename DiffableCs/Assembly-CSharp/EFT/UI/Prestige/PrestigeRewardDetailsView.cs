namespace EFT.UI.Prestige;

[UsedImplicitly]
public sealed class PrestigeRewardDetailsView : UIElement
{
	[SerializeField]
	private Image _image; //Field offset: 0x70
	[SerializeField]
	private TMP_Text _rewardType; //Field offset: 0x78
	[SerializeField]
	private TMP_Text _rewardName; //Field offset: 0x80
	[SerializeField]
	private RewardGameModeView _gameModeTemplate; //Field offset: 0x88
	[SerializeField]
	private Transform _gameModesContainer; //Field offset: 0x90
	[SerializeField]
	private Button _infoButton; //Field offset: 0x98
	[SerializeField]
	private Button _soundButton; //Field offset: 0xA0
	[SerializeField]
	private Button _playButton; //Field offset: 0xA8
	[SerializeField]
	private TMP_Text _description; //Field offset: 0xB0
	private PrestigeReward _reward; //Field offset: 0xB8
	private Dictionary _gameModes; //Field offset: 0xC0

	public PrestigeRewardDetailsView() { }

	private void SetupActionButtons() { }

	public void Show(PrestigeReward reward, IImageLoader session, bool bigImage = true) { }

}

