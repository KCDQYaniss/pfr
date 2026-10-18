namespace EFT.PlayerIcons;

public sealed class PlayerIconCreator : IconCreatorBase
{
	[CompilerGenerated]
	private struct <GetModel>d__14 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PlayerIconCreator <>4__this; //Field offset: 0x20
		public PlayerIconRequest iconRequest; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RenderModel>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PlayerIconCreator <>4__this; //Field offset: 0x20
		public PlayerIconRequest iconRequest; //Field offset: 0x28
		public SpriteFactory spriteFactory; //Field offset: 0x30
		private GameObject <model>5__2; //Field offset: 0x38
		private bool <zeroMipIsLoaded>5__3; //Field offset: 0x40
		private Sprite <sprite>5__4; //Field offset: 0x48
		private TaskAwaiter <>u__1; //Field offset: 0x50
		private TaskAwaiter <>u__2; //Field offset: 0x58
		private TaskAwaiter <>u__3; //Field offset: 0x60
		private TaskAwaiter <>u__4; //Field offset: 0x68

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WaitForRender>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PlayerIconRequest iconRequest; //Field offset: 0x20
		public PlayerIconCreator <>4__this; //Field offset: 0x28
		private int <hash>5__2; //Field offset: 0x30
		private object <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly PlayerIconCreatorModelView _modelView; //Field offset: 0x60
	private readonly Queue _renderQueue; //Field offset: 0x68
	private PlayerIconCreatorMaterialChanger _materialChanger; //Field offset: 0x70
	private PlayerIconCreatorSettings _settings; //Field offset: 0x78
	private bool _containerIsBusy; //Field offset: 0x80

	protected virtual string Folder
	{
		 get { } //Length: 49
	}

	protected virtual string IconCameraName
	{
		 get { } //Length: 49
	}

	public PlayerIconCreator() { }

	private void CompleteRender() { }

	protected virtual string get_Folder() { }

	protected virtual string get_IconCameraName() { }

	public ItemIcon GetIcon(PlayerIconRequest iconRequest) { }

	private ItemIcon GetIconInternal(PlayerIconRequest iconRequest, IntVec2 textureSize) { }

	[AsyncStateMachine(typeof(<GetModel>d__14))]
	private Task GetModel(PlayerIconRequest iconRequest) { }

	protected virtual void PoseModelByBounds(GameObject model, Camera camera, in Bounds bounds) { }

	protected virtual void PoseModelByPivot(GameObject model, Camera camera, float cameraAspect, IconSettings settings) { }

	[AsyncStateMachine(typeof(<RenderModel>d__12))]
	protected virtual Task RenderModel(PlayerIconRequest iconRequest, SpriteFactory spriteFactory) { }

	[AsyncStateMachine(typeof(<WaitForRender>d__13))]
	private Task WaitForRender(PlayerIconRequest iconRequest) { }

}

