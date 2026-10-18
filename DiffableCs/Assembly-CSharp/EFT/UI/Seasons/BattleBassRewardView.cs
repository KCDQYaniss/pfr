namespace EFT.UI.Seasons;

public sealed class BattleBassRewardView : SeasonalRewardView
{
	[SerializeField]
	private GameObject _lockIcon; //Field offset: 0xC8
	[SerializeField]
	private GameObject _checkmarkIcon; //Field offset: 0xD0
	[SerializeField]
	private Dictionary _modeIcons; //Field offset: 0xD8
	[SerializeField]
	private CanvasGroup _iconAlpha; //Field offset: 0xE0
	[SerializeField]
	private GameObject _hoverImage; //Field offset: 0xE8

	public BattleBassRewardView() { }

	[CompilerGenerated]
	private void <Show>b__5_0(BattlePassReward _) { }

	protected virtual void OnPointerEnter() { }

	protected virtual void OnPointerExit() { }

	public void Show(BattlePassReward reward, IImageLoader imageLoader) { }

	private void UpdateStatus() { }

}

