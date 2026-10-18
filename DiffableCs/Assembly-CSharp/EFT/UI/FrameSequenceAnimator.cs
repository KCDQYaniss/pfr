namespace EFT.UI;

public sealed class FrameSequenceAnimator : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public FrameSequenceAnimator <>4__this; //Field offset: 0x10
		public int nextFrameIndex; //Field offset: 0x18

		public <>c__DisplayClass15_0() { }

		internal void <PlayNextTransition>b__0() { }

	}

	[SerializeField]
	private Image[] _frames; //Field offset: 0x70
	[SerializeField]
	private float _frameDuration; //Field offset: 0x78
	[SerializeField]
	private float _crossFadeDuration; //Field offset: 0x7C
	[SerializeField]
	private Ease _crossFadeEase; //Field offset: 0x80
	[SerializeField]
	private bool _playOnDisplay; //Field offset: 0x84
	[SerializeField]
	private bool _playOnAwake; //Field offset: 0x85
	[SerializeField]
	private bool _useUnscaledTime; //Field offset: 0x86
	private Sequence _sequence; //Field offset: 0x88
	private int _currentFrameIndex; //Field offset: 0x90
	private bool _isPlaying; //Field offset: 0x94

	public FrameSequenceAnimator() { }

	private void Awake() { }

	public virtual void Close() { }

	public void Play() { }

	private void PlayNextTransition() { }

	private void ResetFrames() { }

	public void Show() { }

	public void Stop(bool reset) { }

}

