namespace EFT.UI;

public sealed class SpriteSequencePlayer : SpriteAnimationPlayer
{
	[CompilerGenerated]
	private struct <PlayAnimation>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SpriteSequencePlayer <>4__this; //Field offset: 0x20
		private int <frameDuration>5__2; //Field offset: 0x28
		private int <totalSprites>5__3; //Field offset: 0x2C
		private CancellationToken <cancellationToken>5__4; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private Image _image; //Field offset: 0x78
	[SerializeField]
	private Sprite[] _hoverSprites; //Field offset: 0x80
	private bool _isHovered; //Field offset: 0x88
	private int _spriteNumber; //Field offset: 0x8C
	private Task _animationTask; //Field offset: 0x90
	private Sprite[] _runtimeHoverSprites; //Field offset: 0x98

	private Sprite[] HoverSprites
	{
		private get { } //Length: 20
	}

	public SpriteSequencePlayer() { }

	private Sprite[] get_HoverSprites() { }

	public virtual void OnMouseExit() { }

	public virtual void OnMouseOver() { }

	[AsyncStateMachine(typeof(<PlayAnimation>d__11))]
	private Task PlayAnimation() { }

	public virtual void SetSprites(Sprite idleSprite, Sprite hoverSprite, Sprite[] hoverAnimationSprites = null) { }

}

