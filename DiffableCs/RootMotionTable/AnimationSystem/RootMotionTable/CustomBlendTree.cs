namespace AnimationSystem.RootMotionTable;

public class CustomBlendTree : ICustomBlendTreeNode
{
	internal enum EBlendType
	{
		None = 0,
		Simple1D = 1,
		FreeformDirectional2D = 2,
		FreeformCartesian2D = 3,
		SimpleDirectional2D = 4,
		Direct = 5,
	}

	private const float INVERSE_PI = 0.31830987; //Field offset: 0x0
	private const float SKIP_WEIGHT_EPSILON = 0.01; //Field offset: 0x0
	private static readonly Vector3 _cachedZeroVector; //Field offset: 0x0
	private string _name; //Field offset: 0x10
	private List _childNodes; //Field offset: 0x18
	private List _cachedNodesInfo; //Field offset: 0x20
	private EBlendType _blendType; //Field offset: 0x28
	private int _parameterXHash; //Field offset: 0x2C
	private int _parameterYHash; //Field offset: 0x30
	private int _childrenCount; //Field offset: 0x34
	private float[] _childrenThresholds; //Field offset: 0x38
	private Vector2[] _childrenPositions; //Field offset: 0x40
	private int[] _directBlendHashes; //Field offset: 0x48
	private float[] _childWeights; //Field offset: 0x50
	private Vector3[] _childRootMotions; //Field offset: 0x58
	private Quaternion[] _childRotations; //Field offset: 0x60
	private float[] _childClipTimes; //Field offset: 0x68
	private Vector2[] _workspaceBlendVectors; //Field offset: 0x70
	private float[] _constantMagnitudes; //Field offset: 0x78
	private Vector2[] _constantChildPairVectors; //Field offset: 0x80
	private float[] _constantChildPairAvgMagInv; //Field offset: 0x88
	private int[] _cropArray; //Field offset: 0x90
	private bool[] _neighborArray; //Field offset: 0x98
	private int[][] _constantChildNeighborLists; //Field offset: 0xA0
	[CompilerGenerated]
	private readonly bool <IsLooping>k__BackingField; //Field offset: 0xA8

	public int ChildrenCount
	{
		 get { } //Length: 4
	}

	public override bool IsLooping
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public override float MaxClipTime
	{
		 get { } //Length: 4
	}

	public override string Name
	{
		 get { } //Length: 5
	}

	public override int ParameterXHash
	{
		 get { } //Length: 4
	}

	public override int ParameterYHash
	{
		 get { } //Length: 4
	}

	public override Vector3 PosMotion
	{
		 get { } //Length: 79
	}

	public override Quaternion PosRotation
	{
		 get { } //Length: 71
	}

	public EBlendType Type
	{
		 get { } //Length: 5
	}

	private static CustomBlendTree() { }

	public CustomBlendTree() { }

	public CustomBlendTree(string name, EBlendType blendType, int childrenLength, int parameterXHash, int parameterYHash) { }

	private float Angle(Vector2 lhs, Vector2 rhs) { }

	private void CalculateWeights(IParametersCache parametersCache) { }

	private float CommonBlendAllChilds(in float[] childBlends, in float[] childClipTimes) { }

	private Quaternion CommonBlendAllChilds(in float[] childBlends, in Quaternion[] childRotations) { }

	private Vector3 CommonBlendAllChilds(in float[] childBlends, in Vector3[] childRootPositions) { }

	public override void ComputeActiveClips(List nodes, IParametersCache parametersCache) { }

	public void ComputeActiveNodes(List nodes, IParametersCache parametersCache, float[] weights) { }

	public float ComputeClipTime(IParametersCache parametersCache, float[] weights) { }

	public override float ComputeClipTime(IParametersCache parametersCache) { }

	public Quaternion ComputeDeltaRotation(float deltaTime, IParametersCache parametersCache, float[] weights) { }

	public override Quaternion ComputeDeltaRotation(float deltaTime, IParametersCache parametersCache) { }

	public Vector3 ComputeRootPosition(float deltaTime, float stateNormalizedTime, IParametersCache parametersCache, float[] weights) { }

	public override Vector3 ComputeRootPosition(float deltaTime, float stateNormalizedTime, IParametersCache parametersCache) { }

	public void ComputeWeights(float blendValueX, float blendValueY, ref float[] weights) { }

	public void Deserialize(BinaryReader reader) { }

	public int get_ChildrenCount() { }

	[CompilerGenerated]
	public override bool get_IsLooping() { }

	public override float get_MaxClipTime() { }

	public override string get_Name() { }

	public override int get_ParameterXHash() { }

	public override int get_ParameterYHash() { }

	public override Vector3 get_PosMotion() { }

	public override Quaternion get_PosRotation() { }

	public EBlendType get_Type() { }

	private float GetWeightFreeformDirectional(int i, int j, Vector2 blendPosition) { }

	private void GetWeights1D(float blendValue) { }

	private void GetWeights2DSimpleDirectional(float blendValueX, float blendValueY) { }

	private void GetWeightsDirectBlend(IParametersCache allParameters) { }

	private void GetWeightsFreeformCartesian(float blendValueX, float blendValueY, bool preCompute = false) { }

	private void GetWeightsFreeformDirectional(float blendValueX, float blendValueY, bool preCompute = false) { }

	public void InitBlend1DParameters(float[] childrenThresholds) { }

	public void InitBlend2DParameters(Vector2[] childrenPositions) { }

	public void InitChilds(IEnumerable nodes) { }

	public void InitDirectBlendParameters(int[] directBlendHashes) { }

	private void Precompute() { }

	public void Serialize(BinaryWriter writer) { }

	private float WeightForIndex(int index, float blend) { }

}

