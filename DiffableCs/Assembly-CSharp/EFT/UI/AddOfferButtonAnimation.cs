namespace EFT.UI;

public class AddOfferButtonAnimation : DefaultUIButtonAnimation
{
	[SerializeField]
	private TMP_Text _levelLabel; //Field offset: 0x140
	private TweenerCore _normalLevelTween; //Field offset: 0x148
	private TweenerCore _highlightedLevelFadeOutTween; //Field offset: 0x150
	private TweenerCore _highlightedLevelFadeInTween; //Field offset: 0x158

	public AddOfferButtonAnimation() { }

	private void HighlightLevelLabel(bool animated) { }

	protected virtual void InitializeTweens() { }

	protected virtual void OnDestroy() { }

	private static void Restart(TweenerCore tween, Color startValue, Color endValue) { }

	protected virtual void SetHighlightedState(bool animated) { }

	protected virtual void SetNormalState(bool animated) { }

	private void ShowHighlightedLevel() { }

	public virtual void Stop() { }

}

