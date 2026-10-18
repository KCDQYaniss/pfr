namespace EFT.UI;

public class SeasonRankRewardView : SeasonalRewardView
{
	internal class SideNode
	{
		public EPlayerSide Side; //Field offset: 0x10
		public GameObject Icon; //Field offset: 0x18

		public SideNode() { }

	}

	[SerializeField]
	private GameObject _lockIcon; //Field offset: 0xC8
	[SerializeField]
	private GameObject _checkmarkIcon; //Field offset: 0xD0
	[SerializeField]
	private List _modeIcons; //Field offset: 0xD8
	[SerializeField]
	private CanvasGroup _iconAlpha; //Field offset: 0xE0
	[SerializeField]
	private GameObject _hoverImage; //Field offset: 0xE8

	public SeasonRankRewardView() { }

	protected virtual void OnPointerEnter() { }

	protected virtual void OnPointerExit() { }

	public void Show(SeasonRankReward reward, IImageLoader imageLoader) { }

	private void UpdateStatus() { }

}

