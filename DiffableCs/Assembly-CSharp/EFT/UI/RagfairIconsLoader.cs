namespace EFT.UI;

public sealed class RagfairIconsLoader
{
	[CompilerGenerated]
	private struct <LoadTexture>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Dictionary cache; //Field offset: 0x20
		public string url; //Field offset: 0x28
		public Action callback; //Field offset: 0x30
		public RagfairIconsLoader <>4__this; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly Dictionary _iconsCache; //Field offset: 0x10
	private readonly Dictionary _avatarsCache; //Field offset: 0x18
	private readonly IImageLoader _session; //Field offset: 0x20

	public RagfairIconsLoader(IImageLoader session) { }

	public void GetIcon(string url, Action callback) { }

	public Task LoadAvatar(string avatar) { }

	[AsyncStateMachine(typeof(<LoadTexture>d__6))]
	private Task LoadTexture(string url, Dictionary cache, Action callback) { }

}

