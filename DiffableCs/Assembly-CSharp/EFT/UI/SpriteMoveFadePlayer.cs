namespace EFT.UI;

public sealed class SpriteMoveFadePlayer : SpriteAnimationPlayer, ITweenController
{
	internal interface ITweenController
	{

		public void Run(Tween tween) { }

		public void Stop() { }

	}

	[SerializeField]
	private Image _image; //Field offset: 0x78
	[SerializeField]
	private Vector2 _positionA; //Field offset: 0x80
	[SerializeField]
	private Vector2 _positionB; //Field offset: 0x88
	[Range(0, 1)]
	[SerializeField]
	private float _startAlpha; //Field offset: 0x90
	[Range(0, 1)]
	[SerializeField]
	private float _endAlpha; //Field offset: 0x94
	[SerializeField]
	private float _returnDuration; //Field offset: 0x98
	[SerializeField]
	private float _fadeInDuration; //Field offset: 0x9C
	[SerializeField]
	private Ease _moveToPositionBEase; //Field offset: 0xA0
	[SerializeField]
	private Ease _fadeInEase; //Field offset: 0xA4
	[SerializeField]
	private bool _smoothReturnOnMouseExit; //Field offset: 0xA8
	[SerializeField]
	private bool _completeAnimationOnMouseExit; //Field offset: 0xA9
	[SerializeField]
	private bool _loop; //Field offset: 0xAA
	private Sequence _sequence; //Field offset: 0xB0
	private bool _isHovered; //Field offset: 0xB8
	private bool _stopAfterCurrentCycle; //Field offset: 0xB9
	private ITweenController _activeTweenController; //Field offset: 0xC0

	private RectTransform ImageTransform
	{
		private get { } //Length: 235
	}

	public SpriteMoveFadePlayer() { }

	private void AnimateToIdleState(ITweenController tweenController) { }

	private void ApplyHoverPreviewState() { }

	private void ApplyIdleState() { }

	private void Awake() { }

	public virtual void Close() { }

	private override void EFT.UI.SpriteMoveFadePlayer.ITweenController.Run(Tween tween) { }

	private override void EFT.UI.SpriteMoveFadePlayer.ITweenController.Stop() { }

	private RectTransform get_ImageTransform() { }

	private void OnAnimationCompleted() { }

	private void OnCycleCompleted() { }

	private void OnDisable() { }

	public virtual void OnMouseExit() { }

	public virtual void OnMouseOver() { }

	private void PlayAnimation(ITweenController tweenController) { }

	public void ResetPreview() { }

	private void SetImageAlpha(float alpha) { }

	public virtual void SetSprites(Sprite idleSprite, Sprite hoverSprite, Sprite[] hoverAnimationSprites = null) { }

	public void StartPreview(ITweenController tweenController) { }

	private void StopAnimation() { }

	public void StopPreview(ITweenController tweenController) { }

}

