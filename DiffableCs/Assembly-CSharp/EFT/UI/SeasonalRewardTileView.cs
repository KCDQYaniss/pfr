namespace EFT.UI;

public sealed class SeasonalRewardTileView : SeasonalRewardView
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public SeasonalReward reward; //Field offset: 0x10
		public SeasonalRewardTileView <>4__this; //Field offset: 0x18

		public <>c__DisplayClass5_0() { }

		internal void <Show>b__0() { }

		internal void <Show>g__RewardStatusChangedHandler|1(SeasonalReward _, bool __) { }

	}

	[SerializeField]
	private TMP_Text _rewardType; //Field offset: 0xC8
	[SerializeField]
	private TMP_Text _rewardName; //Field offset: 0xD0
	[SerializeField]
	private GameObject _lockIcon; //Field offset: 0xD8
	[SerializeField]
	private GameObject _checkmarkIcon; //Field offset: 0xE0
	[SerializeField]
	private GameObject _newIcon; //Field offset: 0xE8

	public SeasonalRewardTileView() { }

	public void Show(SeasonalReward reward, SeasonsHubScreenController context) { }

	private void ShowText(SeasonalReward reward) { }

	private void UpdateStatus() { }

}

