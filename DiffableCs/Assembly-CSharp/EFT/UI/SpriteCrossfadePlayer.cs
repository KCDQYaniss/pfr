namespace EFT.UI;

public sealed class SpriteCrossfadePlayer : SpriteAnimationPlayer
{
	[SerializeField]
	private Image _image; //Field offset: 0x78
	[SerializeField]
	private Sprite _idleSprite; //Field offset: 0x80
	[SerializeField]
	private Sprite _hoverSprite; //Field offset: 0x88
	private Sprite _runtimeIdleSprite; //Field offset: 0x90
	private Sprite _runtimeHoverSprite; //Field offset: 0x98
	private float _defaultAlpha; //Field offset: 0xA0
	private float _progress; //Field offset: 0xA4
	private Tween _progressTween; //Field offset: 0xA8

	private Sprite HoverSprite
	{
		private get { } //Length: 20
	}

	private Sprite IdleSprite
	{
		private get { } //Length: 20
	}

	public SpriteCrossfadePlayer() { }

	[CompilerGenerated]
	private float <AnimateProgress>b__17_0() { }

	[CompilerGenerated]
	private void <AnimateProgress>b__17_1() { }

	private void AnimateProgress(float targetProgress) { }

	private void ApplyProgress(float progress) { }

	private void ApplySprites() { }

	private void Awake() { }

	public virtual void Close() { }

	private Sprite get_HoverSprite() { }

	private Sprite get_IdleSprite() { }

	public virtual void OnMouseExit() { }

	public virtual void OnMouseOver() { }

	private static void SetImageAlpha(Image image, float alpha) { }

	public virtual void SetSprites(Sprite idleSprite, Sprite hoverSprite, Sprite[] hoverAnimationSprites = null) { }

}

