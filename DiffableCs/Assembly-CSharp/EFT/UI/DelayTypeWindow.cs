namespace EFT.UI;

public sealed class DelayTypeWindow : BaseMessageWindow
{
	[CompilerGenerated]
	private struct <SetupImageAsync>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public IImageLoader imageLoader; //Field offset: 0x20
		public string imageUrl; //Field offset: 0x28
		public DelayTypeWindow <>4__this; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private Image _traderImage; //Field offset: 0xF0
	[SerializeField]
	private Sprite _fallbackSprite; //Field offset: 0xF8
	[SerializeField]
	private TypeWriterComponent _typeWriterComponent; //Field offset: 0x100

	protected virtual bool CloseOnAccept
	{
		 get { } //Length: 3
	}

	public DelayTypeWindow() { }

	protected virtual void Accept() { }

	public virtual void Close() { }

	protected virtual bool get_CloseOnAccept() { }

	[AsyncStateMachine(typeof(<SetupImageAsync>d__6))]
	private Task SetupImageAsync(IImageLoader imageLoader, string imageUrl) { }

	public DialogWindowContext Show(string title, string message, IImageLoader imageLoader, string imageUrl = null, float time = 0) { }

}

