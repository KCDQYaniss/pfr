namespace EFT.UI;

public sealed class NetworkImageView : UIElement
{
	[CompilerGenerated]
	private struct <Show>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public NetworkImageView <>4__this; //Field offset: 0x20
		public string url; //Field offset: 0x28
		public IImageLoader imageLoader; //Field offset: 0x30
		public CancellationToken cancellationToken; //Field offset: 0x38
		private int <requestVersion>5__2; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private Image _image; //Field offset: 0x70
	[SerializeField]
	private GameObject _loader; //Field offset: 0x78
	[SerializeField]
	private Sprite _fallbackSprite; //Field offset: 0x80
	private int _requestVersion; //Field offset: 0x88

	public NetworkImageView() { }

	public void Clear() { }

	public virtual void Close() { }

	private void SetImageState(Sprite sprite) { }

	private void SetLoaderState(bool active) { }

	private void SetSpriteOrFallback(Sprite sprite) { }

	public void Show(Sprite sprite) { }

	public Task Show(string url, IImageLoader imageLoader) { }

	[AsyncStateMachine(typeof(<Show>d__6))]
	public Task Show(string url, IImageLoader imageLoader, CancellationToken cancellationToken) { }

	private void ShowFallback() { }

}

