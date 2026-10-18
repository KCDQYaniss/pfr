//Type is in global namespace

public abstract class IconCreatorBase`2 : IDisposable
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_0
	{
		private struct <<GetItemSpriteAsync>b__0>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
			public <>c__DisplayClass22_0 <>4__this; //Field offset: 0x0
			public GameObject model; //Field offset: 0x0
			public PreviewPivot pivot; //Field offset: 0x0
			private TaskAwaiter <>u__1; //Field offset: 0x0

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public IconCreatorBase <>4__this; //Field offset: 0x0
		public IntVec2 size; //Field offset: 0x0

		public <>c__DisplayClass22_0() { }

		[AsyncStateMachine(typeof(<<GetItemSpriteAsync>b__0>d))]
		internal Task <GetItemSpriteAsync>b__0(GameObject model, PreviewPivot pivot) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass23_0
	{
		private struct <<FillIconWithNewSpriteAsync>g__CreateIcon|0>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
			public <>c__DisplayClass23_0 <>4__this; //Field offset: 0x0
			public GameObject model; //Field offset: 0x0
			public PreviewPivot pivot; //Field offset: 0x0
			private TaskAwaiter <>u__1; //Field offset: 0x0
			private object <>u__2; //Field offset: 0x0
			private Sprite <result>5__2; //Field offset: 0x0

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public IconCreatorBase <>4__this; //Field offset: 0x0
		public IntVec2 size; //Field offset: 0x0

		public <>c__DisplayClass23_0() { }

		[AsyncStateMachine(typeof(<<FillIconWithNewSpriteAsync>g__CreateIcon|0>d))]
		internal Task <FillIconWithNewSpriteAsync>g__CreateIcon|0(GameObject model, PreviewPivot pivot) { }

	}

	[CompilerGenerated]
	private struct <FillIconWithNewSpriteAsync>d__23 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public IconCreatorBase <>4__this; //Field offset: 0x0
		public IntVec2 size; //Field offset: 0x0
		public TIcon icon; //Field offset: 0x0
		public TItem item; //Field offset: 0x0
		public bool requireZeroMip; //Field offset: 0x0
		public bool saveToFile; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0
		private TaskAwaiter <>u__2; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetItemSpriteAsync>d__22 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public IconCreatorBase <>4__this; //Field offset: 0x0
		public IntVec2 size; //Field offset: 0x0
		public TItem item; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Init>d__19 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public IconCreatorBase <>4__this; //Field offset: 0x0
		private StreamReader <reader>5__2; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadFromUserCacheAsync>d__28 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public IconCreatorBase <>4__this; //Field offset: 0x0
		public TIcon icon; //Field offset: 0x0
		public IntVec2 size; //Field offset: 0x0
		public string iconPath; //Field offset: 0x0
		private Texture2D <texture>5__2; //Field offset: 0x0
		private FileStream <reader>5__3; //Field offset: 0x0
		private byte[] <buffer>5__4; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PrepareCameraAsync>d__21 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public IconCreatorBase <>4__this; //Field offset: 0x0
		private ResourceRequest <loadOperation>5__2; //Field offset: 0x0
		private object <>u__1; //Field offset: 0x0
		private TaskAwaiter <>u__2; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SaveIconAsync>d__27 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public IconCreatorBase <>4__this; //Field offset: 0x0
		public TIcon icon; //Field offset: 0x0
		private FileStream <writer>5__2; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal struct RenderModelResult
	{
		public Sprite sprite; //Field offset: 0x0
		public bool zeroMipWasLoaded; //Field offset: 0x0

	}

	internal sealed class SpriteFactory : MulticastDelegate
	{

		public SpriteFactory(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(GameObject model, PreviewPivot pivot, AsyncCallback callback, object object) { }

		public override Task EndInvoke(IAsyncResult result) { }

		public override Task Invoke(GameObject model, PreviewPivot pivot) { }

	}

	private readonly Dictionary _memoryCacheIndex; //Field offset: 0x0
	private readonly Dictionary _fileCacheIndex; //Field offset: 0x0
	private readonly string _cachePath; //Field offset: 0x0
	private readonly string _indexPath; //Field offset: 0x0
	private Nullable _prevTextureLimit; //Field offset: 0x0
	private bool _isIconCreating; //Field offset: 0x0
	private int _queueCount; //Field offset: 0x0
	private int _maxFileId; //Field offset: 0x0
	private IconCamera _renderCamera; //Field offset: 0x0
	private bool _isCameraLoading; //Field offset: 0x0
	protected IconCreatorGraphicsSettings _graphicsSettings; //Field offset: 0x0

	protected abstract string Folder
	{
		 get { } //Length: 0
	}

	protected override string IconCameraName
	{
		 get { } //Length: 49
	}

	protected Camera RenderCamera
	{
		 get { } //Length: 27
	}

	protected IconCreatorBase`2() { }

	private Sprite CaptureSpriteOfModel(GameObject model, in IntVec2 size, PreviewPivot previewPivot) { }

	private void CheckCacheFolder() { }

	private static void CleanIcon(TIcon icon) { }

	public void ClearMemoryCache() { }

	private static Sprite CreateSprite(Texture2D texture) { }

	public override void Dispose() { }

	[AsyncStateMachine(typeof(<FillIconWithNewSpriteAsync>d__23))]
	protected Task FillIconWithNewSpriteAsync(TIcon icon, TItem item, IntVec2 size, bool saveToFile, bool requireZeroMip) { }

	protected abstract string get_Folder() { }

	protected override string get_IconCameraName() { }

	protected Camera get_RenderCamera() { }

	protected override Bounds GetBounds(GameObject model) { }

	[AsyncStateMachine(typeof(<GetItemSpriteAsync>d__22))]
	public Task GetItemSpriteAsync(TItem item, IntVec2 size) { }

	private string GetPngPath(int fileId) { }

	private static Texture2D GetTexture(int width, int height) { }

	[AsyncStateMachine(typeof(<Init>d__19))]
	public Task Init() { }

	[AsyncStateMachine(typeof(<LoadFromUserCacheAsync>d__28))]
	protected Task LoadFromUserCacheAsync(TIcon icon, string iconPath, IntVec2 size) { }

	protected abstract void PoseModelByBounds(GameObject model, Camera camera, in Bounds bounds) { }

	protected abstract void PoseModelByPivot(GameObject model, Camera camera, float cameraAspect, IconSettings settings) { }

	[AsyncStateMachine(typeof(<PrepareCameraAsync>d__21))]
	private Task PrepareCameraAsync() { }

	protected abstract Task RenderModel(TItem item, SpriteFactory spriteFactory) { }

	[AsyncStateMachine(typeof(<SaveIconAsync>d__27))]
	private Task SaveIconAsync(TIcon icon) { }

	private void SetupScene(GameObject model, in IntVec2 textureSize, PreviewPivot previewPivot) { }

	protected bool TryGetCachedIcon(int hash, out TIcon icon) { }

	protected bool TryGetIconPath(int hash, out string path) { }

}

