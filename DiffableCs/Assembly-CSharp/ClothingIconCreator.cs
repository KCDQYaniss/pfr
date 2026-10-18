//Type is in global namespace

public sealed class ClothingIconCreator : IconCreatorBase
{
	[CompilerGenerated]
	private struct <RenderModel>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ClothingIconCreator <>4__this; //Field offset: 0x20
		public CustomizationClothing clothing; //Field offset: 0x28
		public SpriteFactory spriteFactory; //Field offset: 0x30
		private GameObject <baseModel>5__2; //Field offset: 0x38
		private SkinnedMeshRenderer <skinnedMesh>5__3; //Field offset: 0x40
		private object <>u__1; //Field offset: 0x48
		private TaskAwaiter <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const float ADDITIONAL_X_SHIFT = 0.05; //Field offset: 0x0
	private const float ADDITIONAL_Y_SHIFT = 0.03; //Field offset: 0x0
	private const float DEFAULT_Z_POSITION = 3; //Field offset: 0x0
	private static readonly Quaternion _defaultRotation; //Field offset: 0x0
	private readonly IEasyAssets _easyAssets; //Field offset: 0x60
	private GameObject _clothingMeshContainer; //Field offset: 0x68
	private MeshFilter _filter; //Field offset: 0x70
	private MeshRenderer _renderer; //Field offset: 0x78
	private bool _containerIsBusy; //Field offset: 0x80

	protected virtual string Folder
	{
		 get { } //Length: 49
	}

	private static ClothingIconCreator() { }

	public ClothingIconCreator(IEasyAssets easyAssets) { }

	public void Begin() { }

	public void End() { }

	protected virtual string get_Folder() { }

	protected virtual Bounds GetBounds(GameObject model) { }

	public ClothingIcon GetIcon(CustomizationClothing clothing, IntVec2 textureSize) { }

	protected virtual void PoseModelByBounds(GameObject model, Camera camera, in Bounds bounds) { }

	protected virtual void PoseModelByPivot(GameObject model, Camera camera, float cameraAspect, IconSettings settings) { }

	[AsyncStateMachine(typeof(<RenderModel>d__15))]
	protected virtual Task RenderModel(CustomizationClothing clothing, SpriteFactory spriteFactory) { }

}

