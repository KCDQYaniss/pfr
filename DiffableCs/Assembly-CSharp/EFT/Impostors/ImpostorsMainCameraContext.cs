namespace EFT.Impostors;

internal sealed class ImpostorsMainCameraContext : ImpostorsCameraContextAbstract, IImpostorsMainCameraContext, IImpostorsCameraContext, IDisposable
{
	private static class CullingShader
	{
		public static readonly int BoundsBuffer; //Field offset: 0x0
		public static readonly int ImpostorsCount; //Field offset: 0x4
		public static readonly int Frustum; //Field offset: 0x8
		public static readonly int FOVHalfAngle; //Field offset: 0xC
		public static readonly int LookMatrix; //Field offset: 0x10
		public static readonly int CamPosition; //Field offset: 0x14
		public static readonly int CrossFadeFutureBuffer; //Field offset: 0x18

		private static CullingShader() { }

	}

	private static class DrawShader
	{
		public static readonly int ImpostorsOffset; //Field offset: 0x0
		public static readonly int ToWorldMatrixBuffer; //Field offset: 0x4
		public static readonly int ToLocalMatrixBuffer; //Field offset: 0x8
		public static readonly int PropBlockBuffer; //Field offset: 0xC
		public static readonly int ImpostorsVertexBuffer; //Field offset: 0x10
		public static readonly int ImpostorWindBuffer; //Field offset: 0x14

		private static DrawShader() { }

	}

	public interface IDrawInstance
	{

		public ImpostorBounds[] Bounds
		{
			 get { } //Length: 0
		}

		public ComputeShader CullingShader
		{
			 get { } //Length: 0
		}

		public int[] Ids
		{
			 get { } //Length: 0
		}

		public IReadOnlyList Impostors
		{
			 get { } //Length: 0
		}

		public ComputeBuffer ImpostorsVertexBuffer
		{
			 get { } //Length: 0
		}

		public ComputeBuffer ImpostorsWindBuffer
		{
			 get { } //Length: 0
		}

		public ComputeBuffer LocalToWorldMatrixBuffer
		{
			 get { } //Length: 0
		}

		public Material Material
		{
			 get { } //Length: 0
		}

		public Mesh Mesh
		{
			 get { } //Length: 0
		}

		public ComputeBuffer PropBlockBuffer
		{
			 get { } //Length: 0
		}

		public IDictionary Winds
		{
			 get { } //Length: 0
		}

		public ComputeBuffer WorldToLocalMatrixBuffer
		{
			 get { } //Length: 0
		}

		public ImpostorBounds[] get_Bounds() { }

		public ComputeShader get_CullingShader() { }

		public int[] get_Ids() { }

		public IReadOnlyList get_Impostors() { }

		public ComputeBuffer get_ImpostorsVertexBuffer() { }

		public ComputeBuffer get_ImpostorsWindBuffer() { }

		public ComputeBuffer get_LocalToWorldMatrixBuffer() { }

		public Material get_Material() { }

		public Mesh get_Mesh() { }

		public ComputeBuffer get_PropBlockBuffer() { }

		public IDictionary get_Winds() { }

		public ComputeBuffer get_WorldToLocalMatrixBuffer() { }

		public List GetBounds() { }

	}

	private static class SharedShader
	{
		public static readonly int InstancesBuffer; //Field offset: 0x0
		public static readonly int CrossFadeBuffer; //Field offset: 0x4
		public static readonly int ImpostorsBuffer; //Field offset: 0x8

		private static SharedShader() { }

	}

	private const int DEFERRED_SHADER_PASS = 0; //Field offset: 0x0
	private const int DISTANT_SHADOW_CASTER_SHADER_PASS = 1; //Field offset: 0x0
	private const float PRECESSION = 1E-05; //Field offset: 0x0
	private readonly uint[] _shadowArgs; //Field offset: 0x20
	private readonly uint[] _args; //Field offset: 0x28
	private readonly Plane[] _planes; //Field offset: 0x30
	private readonly Vector4[] _frustum; //Field offset: 0x38
	private Vector3 _position; //Field offset: 0x40
	private Quaternion _rotation; //Field offset: 0x4C
	private Vector3 _forward; //Field offset: 0x5C
	private float _FOVHalfAngle; //Field offset: 0x68
	private Matrix4x4 _lookMatrix; //Field offset: 0x6C
	private IDrawInstance _drawInstance; //Field offset: 0xB0
	private Transform _cameraTransform; //Field offset: 0xB8
	private int _kernelIndex; //Field offset: 0xC0
	private ComputeBuffer _shadowArgsBuffer; //Field offset: 0xC8
	private ComputeBuffer _argsBuffer; //Field offset: 0xD0
	private ComputeBuffer _impostorsBuffer; //Field offset: 0xD8
	private ComputeBuffer _crossFadeBuffer; //Field offset: 0xE0
	private ComputeBuffer _crossFadeFutureBuffer; //Field offset: 0xE8
	private ComputeBuffer _boundsBuffer; //Field offset: 0xF0
	private ComputeBuffer _instancesBuffer; //Field offset: 0xF8
	private CommandBuffer _cullingCommandBuffer; //Field offset: 0x100
	private bool _cullingAdded; //Field offset: 0x108
	private readonly List _impostorStructs; //Field offset: 0x110
	private bool _enablesChanged; //Field offset: 0x118
	private uint _impostorsRest; //Field offset: 0x11C
	private bool _refreshed; //Field offset: 0x120

	private static CameraEvent CullingEvent
	{
		private get { } //Length: 6
	}

	internal ImpostorsMainCameraContext(IDrawInstance drawInstance, Camera camera) { }

	private void AddCullingToCamera() { }

	public virtual void Dispose() { }

	private override void EFT.Impostors.IImpostorsCameraContext.OnPreCull() { }

	private override void EFT.Impostors.IImpostorsMainCameraContext.DrawDistantShadow(CommandBuffer commandBuffer, uint impostorsPerFrame, out int impostorsRest) { }

	private override void EFT.Impostors.IImpostorsMainCameraContext.EnablesChanged() { }

	private override void EFT.Impostors.IImpostorsMainCameraContext.OnPreCull(CommandBuffer cameraCommandBuffer) { }

	private static CameraEvent get_CullingEvent() { }

	private bool IsCameraChanged() { }

	private void OnPreCull() { }

	public override void Refresh() { }

	private void RefreshArgsBuffer() { }

	private void RefreshBoundsBuffer() { }

	private void RefreshImpostorsBuffer() { }

	private void RefreshShadowArgsBuffer() { }

	private void RemoveCullingFromCamera() { }

	private void SetupCulling() { }

	private void SetupCullingCalculation() { }

	private void SetupDraw(CommandBuffer commandBuffer, ComputeBuffer argsBuffer, int shaderPass) { }

	private void SetupDraw(CommandBuffer commandBuffer) { }

	private bool TryUpdateCullingData() { }

	private bool TryUpdateEnables() { }

	private void UpdateCullingData() { }

	private void UpdateEnables() { }

	private void UpdateFrustum() { }

}

