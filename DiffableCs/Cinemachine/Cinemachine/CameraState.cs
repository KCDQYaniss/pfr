namespace Cinemachine;

public struct CameraState
{
	internal enum BlendHintValue
	{
		Nothing = 0,
		NoPosition = 1,
		NoOrientation = 2,
		NoTransform = 3,
		SphericalPositionBlend = 4,
		CylindricalPositionBlend = 8,
		RadialAimBlend = 16,
		IgnoreLookAtTarget = 32,
		NoLens = 64,
	}

	internal struct CustomBlendable
	{
		public Object m_Custom; //Field offset: 0x0
		public float m_Weight; //Field offset: 0x8

		public CustomBlendable(Object custom, float weight) { }

	}

	public static Vector3 kNoPoint; //Field offset: 0x0
	public LensSettings Lens; //Field offset: 0x0
	public Vector3 ReferenceUp; //Field offset: 0x34
	public Vector3 ReferenceLookAt; //Field offset: 0x40
	public Vector3 RawPosition; //Field offset: 0x4C
	public Quaternion RawOrientation; //Field offset: 0x58
	public Vector3 PositionDampingBypass; //Field offset: 0x68
	public float ShotQuality; //Field offset: 0x74
	public Vector3 PositionCorrection; //Field offset: 0x78
	public Quaternion OrientationCorrection; //Field offset: 0x84
	public BlendHintValue BlendHint; //Field offset: 0x94
	private CustomBlendable mCustom0; //Field offset: 0x98
	private CustomBlendable mCustom1; //Field offset: 0xA8
	private CustomBlendable mCustom2; //Field offset: 0xB8
	private CustomBlendable mCustom3; //Field offset: 0xC8
	private List m_CustomOverflow; //Field offset: 0xD8
	[CompilerGenerated]
	private int <NumCustomBlendables>k__BackingField; //Field offset: 0xE0

	public Quaternion CorrectedOrientation
	{
		 get { } //Length: 365
	}

	public Vector3 CorrectedPosition
	{
		 get { } //Length: 67
	}

	public static CameraState Default
	{
		 get { } //Length: 606
	}

	public Quaternion FinalOrientation
	{
		 get { } //Length: 696
	}

	public Vector3 FinalPosition
	{
		 get { } //Length: 67
	}

	public bool HasLookAt
	{
		 get { } //Length: 82
	}

	public private int NumCustomBlendables
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	private static CameraState() { }

	public void AddCustomBlendable(CustomBlendable b) { }

	private static Vector3 ApplyPosBlendHint(Vector3 posA, BlendHintValue hintA, Vector3 posB, BlendHintValue hintB, Vector3 original, Vector3 blended) { }

	private static Quaternion ApplyRotBlendHint(Quaternion rotA, BlendHintValue hintA, Quaternion rotB, BlendHintValue hintB, Quaternion original, Quaternion blended) { }

	private int FindCustomBlendable(Object custom) { }

	public Quaternion get_CorrectedOrientation() { }

	public Vector3 get_CorrectedPosition() { }

	public static CameraState get_Default() { }

	public Quaternion get_FinalOrientation() { }

	public Vector3 get_FinalPosition() { }

	public bool get_HasLookAt() { }

	[CompilerGenerated]
	[IsReadOnly]
	public int get_NumCustomBlendables() { }

	public CustomBlendable GetCustomBlendable(int index) { }

	private static float InterpolateFOV(float fovA, float fovB, float dA, float dB, float t) { }

	private Vector3 InterpolatePosition(Vector3 posA, Vector3 pivotA, Vector3 posB, Vector3 pivotB, float t) { }

	public static CameraState Lerp(CameraState stateA, CameraState stateB, float t) { }

	[CompilerGenerated]
	private void set_NumCustomBlendables(int value) { }

}

