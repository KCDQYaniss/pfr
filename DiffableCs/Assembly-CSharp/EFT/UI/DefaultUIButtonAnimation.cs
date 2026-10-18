namespace EFT.UI;

public class DefaultUIButtonAnimation : SerializedMonoBehaviour, IButtonAnimation, ITweenAnimation
{
	protected const float NORMAL_DURATION = 0.15; //Field offset: 0x0
	protected const float HIGHLIGHTED_DURATION = 0.3; //Field offset: 0x0
	[SerializeField]
	public RectTransform Background; //Field offset: 0x60
	[SerializeField]
	public Image Image; //Field offset: 0x68
	[SerializeField]
	public Image Icon; //Field offset: 0x70
	[SerializeField]
	public TMP_Text Label; //Field offset: 0x78
	[SerializeField]
	private Dictionary _stateAttachments; //Field offset: 0x80
	private TweenerCore _normalBackgroundTween; //Field offset: 0x88
	private TweenerCore _normalLabelTween; //Field offset: 0x90
	private TweenerCore _normalImageTween; //Field offset: 0x98
	private TweenerCore _normalIconTween; //Field offset: 0xA0
	private TweenerCore _highlightedBackgroundTween; //Field offset: 0xA8
	private TweenerCore _highlightedImageTween; //Field offset: 0xB0
	private TweenerCore _highlightedLabelFadeOutTween; //Field offset: 0xB8
	private TweenerCore _highlightedLabelFadeInTween; //Field offset: 0xC0
	private TweenerCore _highlightedIconFadeOutTween; //Field offset: 0xC8
	private TweenerCore _highlightedIconFadeInTween; //Field offset: 0xD0
	[SerializeField]
	private bool _changeColors; //Field offset: 0xD8
	[SerializeField]
	protected Color _normalLabelColor; //Field offset: 0xDC
	[SerializeField]
	protected Color _highlightedLabelColor; //Field offset: 0xEC
	[Range(0, 1)]
	[SerializeField]
	protected float _backgorundNormalStateAplha; //Field offset: 0xFC
	[SerializeField]
	protected Color _normalImageColor; //Field offset: 0x100
	[SerializeField]
	protected Color _highlightedImageColor; //Field offset: 0x110
	protected Color _normalIconColor; //Field offset: 0x120
	protected Color _highlightedIconColor; //Field offset: 0x130

	public DefaultUIButtonAnimation() { }

	protected override void Awake() { }

	private void ChangeState(EButtonAnimationState state, bool animated) { }

	protected override void InitializeTweens() { }

	private void KillTweens() { }

	protected override void OnDestroy() { }

	private void PauseTweens() { }

	private static void Restart(TweenerCore tween, Color startValue, Color endValue) { }

	private static void Restart(TweenerCore tween, Vector2 startValue, Vector2 endValue) { }

	protected override void SetDisabledState(bool animated) { }

	protected override void SetHighlightedState(bool animated) { }

	protected override void SetNormalState(bool animated) { }

	private void SetPressedState(bool animated) { }

	public override void SetState(EButtonAnimationState state) { }

	private void ShowHighlightedIcon() { }

	private void ShowHighlightedLabel() { }

	public override void Stop() { }

	public override void TransitionToState(EButtonAnimationState state) { }

}

