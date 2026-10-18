namespace EFT.Impostors;

internal sealed class ImpostorsDrawInstance : IDrawInstance, IDisposable
{
	internal const string SCENE_CAMERA = "SceneCamera"; //Field offset: 0x0
	internal const string OPTIC_CAMERA_TAG = "OpticCamera"; //Field offset: 0x0
	internal const string MAIN_CAMERA_TAG = "MainCamera"; //Field offset: 0x0
	internal const string UNTAGGED_CAMERA_TAG = "Untagged"; //Field offset: 0x0
	internal const string PREVIEW_SCENE_CAMERA = "Preview Scene Camera"; //Field offset: 0x0
	private readonly ImpostorsMaterialLoader _materialLoader; //Field offset: 0x10
	private readonly List _impostors; //Field offset: 0x18
	private readonly Dictionary _windsDictionary; //Field offset: 0x20
	private readonly List _winds; //Field offset: 0x28
	private readonly List _worldToLocal; //Field offset: 0x30
	private readonly List _localToWorld; //Field offset: 0x38
	private readonly List _vertices; //Field offset: 0x40
	private readonly List _propBlocks; //Field offset: 0x48
	private readonly List _bounds; //Field offset: 0x50
	private readonly DictionaryListHydra _camContexts; //Field offset: 0x58
	private IImpostorsMainCameraContext _mainCameraContext; //Field offset: 0x60
	private int[] _ids; //Field offset: 0x68
	private AmplifyImpostorsArray _impostorsArray; //Field offset: 0x70
	private EImpostorsShadowMode _shadowMode; //Field offset: 0x78
	private ComputeBuffer _localToWorldMatrixBuffer; //Field offset: 0x80
	private ComputeBuffer _worldToLocalMatrixBuffer; //Field offset: 0x88
	private ComputeBuffer _propBlockBuffer; //Field offset: 0x90
	private ComputeBuffer _impostorsVertexBuffer; //Field offset: 0x98
	private ComputeBuffer _impostorsWindBuffer; //Field offset: 0xA0

	private override ImpostorBounds[] EFT.Impostors.ImpostorsMainCameraContext.IDrawInstance.Bounds
	{
		private get { } //Length: 27
	}

	private override ComputeShader EFT.Impostors.ImpostorsMainCameraContext.IDrawInstance.CullingShader
	{
		private get { } //Length: 30
	}

	private override int[] EFT.Impostors.ImpostorsMainCameraContext.IDrawInstance.Ids
	{
		private get { } //Length: 5
	}

	private override IReadOnlyList EFT.Impostors.ImpostorsMainCameraContext.IDrawInstance.Impostors
	{
		private get { } //Length: 5
	}

	private override ComputeBuffer EFT.Impostors.ImpostorsMainCameraContext.IDrawInstance.ImpostorsVertexBuffer
	{
		private get { } //Length: 8
	}

	private override ComputeBuffer EFT.Impostors.ImpostorsMainCameraContext.IDrawInstance.ImpostorsWindBuffer
	{
		private get { } //Length: 8
	}

	private override ComputeBuffer EFT.Impostors.ImpostorsMainCameraContext.IDrawInstance.LocalToWorldMatrixBuffer
	{
		private get { } //Length: 8
	}

	private override Material EFT.Impostors.ImpostorsMainCameraContext.IDrawInstance.Material
	{
		private get { } //Length: 41
	}

	private override Mesh EFT.Impostors.ImpostorsMainCameraContext.IDrawInstance.Mesh
	{
		private get { } //Length: 30
	}

	private override ComputeBuffer EFT.Impostors.ImpostorsMainCameraContext.IDrawInstance.PropBlockBuffer
	{
		private get { } //Length: 8
	}

	private override IDictionary EFT.Impostors.ImpostorsMainCameraContext.IDrawInstance.Winds
	{
		private get { } //Length: 5
	}

	private override ComputeBuffer EFT.Impostors.ImpostorsMainCameraContext.IDrawInstance.WorldToLocalMatrixBuffer
	{
		private get { } //Length: 8
	}

	public int ImpostorsToRenderCount
	{
		 get { } //Length: 66
	}

	internal ImpostorsDrawInstance() { }

	private IImpostorsCameraContext AddContext(Camera currentCamera) { }

	internal void Clear() { }

	public override void Dispose() { }

	internal void DrawDistantShadow(Camera currentCamera, CommandBuffer shadowCommandBuffer, uint impostorsPerFrame, out int impostorsRest) { }

	private override ImpostorBounds[] EFT.Impostors.ImpostorsMainCameraContext.IDrawInstance.get_Bounds() { }

	private override ComputeShader EFT.Impostors.ImpostorsMainCameraContext.IDrawInstance.get_CullingShader() { }

	private override int[] EFT.Impostors.ImpostorsMainCameraContext.IDrawInstance.get_Ids() { }

	private override IReadOnlyList EFT.Impostors.ImpostorsMainCameraContext.IDrawInstance.get_Impostors() { }

	private override ComputeBuffer EFT.Impostors.ImpostorsMainCameraContext.IDrawInstance.get_ImpostorsVertexBuffer() { }

	private override ComputeBuffer EFT.Impostors.ImpostorsMainCameraContext.IDrawInstance.get_ImpostorsWindBuffer() { }

	private override ComputeBuffer EFT.Impostors.ImpostorsMainCameraContext.IDrawInstance.get_LocalToWorldMatrixBuffer() { }

	private override Material EFT.Impostors.ImpostorsMainCameraContext.IDrawInstance.get_Material() { }

	private override Mesh EFT.Impostors.ImpostorsMainCameraContext.IDrawInstance.get_Mesh() { }

	private override ComputeBuffer EFT.Impostors.ImpostorsMainCameraContext.IDrawInstance.get_PropBlockBuffer() { }

	private override IDictionary EFT.Impostors.ImpostorsMainCameraContext.IDrawInstance.get_Winds() { }

	private override ComputeBuffer EFT.Impostors.ImpostorsMainCameraContext.IDrawInstance.get_WorldToLocalMatrixBuffer() { }

	private override List EFT.Impostors.ImpostorsMainCameraContext.IDrawInstance.GetBounds() { }

	public void EnablesChanged() { }

	public int get_ImpostorsToRenderCount() { }

	internal void OnPreCull(Camera currentCamera) { }

	private void RecreateIds(int length, IReadOnlyList groups) { }

	private bool TryUpdateIds(IReadOnlyList groups) { }

	internal void Update(AmplifyImpostorsArray impostorsArray, IReadOnlyList groups, int firstMipLevel, EImpostorsShadowMode shadowMode) { }

	private void Update(IReadOnlyList groups, int firstMipLevel) { }

	private bool UpdateIds(IReadOnlyList groups) { }

	private void UpdateMatrixBuffers() { }

	private void UpdateWind() { }

}

