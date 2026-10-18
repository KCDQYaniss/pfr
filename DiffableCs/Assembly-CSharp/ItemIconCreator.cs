//Type is in global namespace

public sealed class ItemIconCreator : IconCreatorBase
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__14_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <RenderModel>b__14_0(Item x) { }

	}

	[CompilerGenerated]
	private struct <RenderModel>d__14 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Item item; //Field offset: 0x20
		public ItemIconCreator <>4__this; //Field offset: 0x28
		public SpriteFactory spriteFactory; //Field offset: 0x30
		private Item <clone>5__2; //Field offset: 0x38
		private Token <bundles>5__3; //Field offset: 0x40
		private GameObject <model>5__4; //Field offset: 0x48
		private bool <zeroMipIsLoaded>5__5; //Field offset: 0x50
		private PreviewPivot <previewPivot>5__6; //Field offset: 0x58
		private TaskAwaiter <>u__1; //Field offset: 0x60
		private object <>u__2; //Field offset: 0x68
		private TaskAwaiter <>u__3; //Field offset: 0x70
		private YieldAwaiter <>u__4; //Field offset: 0x78
		private TaskAwaiter <>u__5; //Field offset: 0x80
		private TaskAwaiter <>u__6; //Field offset: 0x88

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RequestMipZero>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public GameObject obj; //Field offset: 0x20
		private PooledObject <materialPool>5__2; //Field offset: 0x28
		private PooledObject <namesPool>5__3; //Field offset: 0x38
		private PooledObject <uniqueNamesPool>5__4; //Field offset: 0x48
		private PooledObject <texturesPool>5__5; //Field offset: 0x58
		private List <textures>5__6; //Field offset: 0x68
		private bool <loadedCompletely>5__7; //Field offset: 0x70
		private YieldAwaiter <>u__1; //Field offset: 0x71

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ResetRequestedMip>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public GameObject obj; //Field offset: 0x20
		private YieldAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private struct T2DInfo
	{
		[CompilerGenerated]
		private readonly Texture2D <Tex2d>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private int <RequestsCount>k__BackingField; //Field offset: 0x8

		public private int RequestsCount
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 4
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public Texture2D Tex2d
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 4
		}

		public T2DInfo(Texture2D tex2d) { }

		[CompilerGenerated]
		[IsReadOnly]
		public int get_RequestsCount() { }

		[CompilerGenerated]
		[IsReadOnly]
		public Texture2D get_Tex2d() { }

		public T2DInfo IncRequestCount() { }

		[CompilerGenerated]
		private void set_RequestsCount(int value) { }

	}

	private static int requests; //Field offset: 0x0
	private static float mipBudget; //Field offset: 0x4
	private readonly IEasyAssets _easyAssets; //Field offset: 0x60
	private readonly ObjectsFactory _objectsFactory; //Field offset: 0x68

	protected virtual string Folder
	{
		 get { } //Length: 59
	}

	public ItemIconCreator(IEasyAssets easyAssets, ObjectsFactory objectsFactory) { }

	public static void CenterByBounds(GameObject model, Camera camera, float cameraAspect, IconSettings iconSettings) { }

	protected virtual string get_Folder() { }

	public ItemIcon GetItemIcon(Item item, in IntVec2 size, bool forcedGeneration = false) { }

	protected virtual void PoseModelByBounds(GameObject model, Camera camera, in Bounds bounds) { }

	protected virtual void PoseModelByPivot(GameObject model, Camera camera, float cameraAspect, IconSettings settings) { }

	[AsyncStateMachine(typeof(<RenderModel>d__14))]
	protected virtual Task RenderModel(Item item, SpriteFactory spriteFactory) { }

	[AsyncStateMachine(typeof(<RequestMipZero>d__12))]
	private Task RequestMipZero(GameObject obj) { }

	[AsyncStateMachine(typeof(<ResetRequestedMip>d__13))]
	private Task ResetRequestedMip(GameObject obj) { }

}

