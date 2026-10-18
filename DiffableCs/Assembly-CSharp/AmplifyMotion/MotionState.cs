namespace AmplifyMotion;

internal abstract class MotionState
{
	internal struct MaterialDesc
	{
		public Material material; //Field offset: 0x0
		public MaterialPropertyBlock propertyBlock; //Field offset: 0x8
		public bool coverage; //Field offset: 0x10
		public bool cutoff; //Field offset: 0x11

	}

	internal struct Matrix3x4
	{
		public float m00; //Field offset: 0x0
		public float m01; //Field offset: 0x4
		public float m02; //Field offset: 0x8
		public float m03; //Field offset: 0xC
		public float m10; //Field offset: 0x10
		public float m11; //Field offset: 0x14
		public float m12; //Field offset: 0x18
		public float m13; //Field offset: 0x1C
		public float m20; //Field offset: 0x20
		public float m21; //Field offset: 0x24
		public float m22; //Field offset: 0x28
		public float m23; //Field offset: 0x2C

		public Vector4 GetRow(int i) { }

		public static Matrix3x4 op_Implicit(Matrix4x4 from) { }

		public static Matrix4x4 op_Implicit(Matrix3x4 from) { }

		public static Matrix3x4 op_Multiply(Matrix3x4 a, Matrix3x4 b) { }

	}

	public const int AsyncUpdateTimeout = 100; //Field offset: 0x0
	private static HashSet m_materialWarnings; //Field offset: 0x0
	protected bool m_error; //Field offset: 0x10
	protected bool m_initialized; //Field offset: 0x11
	protected Transform m_transform; //Field offset: 0x18
	protected AmplifyMotionCamera m_owner; //Field offset: 0x20
	protected AmplifyMotionObjectBase m_obj; //Field offset: 0x28

	public bool Error
	{
		 get { } //Length: 5
	}

	public bool Initialized
	{
		 get { } //Length: 5
	}

	public AmplifyMotionCamera Owner
	{
		 get { } //Length: 5
	}

	private static MotionState() { }

	public MotionState(AmplifyMotionCamera owner, AmplifyMotionObjectBase obj) { }

	internal override void AsyncUpdate() { }

	public bool get_Error() { }

	public bool get_Initialized() { }

	public AmplifyMotionCamera get_Owner() { }

	internal override void Initialize() { }

	protected static bool MatrixChanged(Matrix3x4 a, Matrix3x4 b) { }

	protected static void MulAddPoint3x4_XYZW(ref Vector3 result, ref Matrix3x4 mat, Vector4 vec) { }

	protected static void MulPoint3x4_XYZ(ref Vector3 result, ref Matrix3x4 mat, Vector4 vec) { }

	protected static void MulPoint3x4_XYZW(ref Vector3 result, ref Matrix3x4 mat, Vector4 vec) { }

	protected MaterialDesc[] ProcessSharedMaterials(Material[] mats) { }

	internal override void RenderDebugHUD() { }

	internal override void RenderVectors(Camera camera, CommandBuffer renderCB, float scale, Quality quality) { }

	internal override void Shutdown() { }

	internal abstract void UpdateTransform(CommandBuffer updateCB, bool starting) { }

}

