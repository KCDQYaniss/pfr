namespace EFT.UI;

public sealed class SeasonsRanksRewardView : UIElement
{
	[SerializeField]
	private Image _rewardImage; //Field offset: 0x70
	[SerializeField]
	private Image _side; //Field offset: 0x78
	[SerializeField]
	private Button _inspect; //Field offset: 0x80
	[SerializeField]
	private GameObject _doneIcon; //Field offset: 0x88

	public SeasonsRanksRewardView() { }

	public void Show(PrestigeReward reward, IImageLoader session) { }

}

