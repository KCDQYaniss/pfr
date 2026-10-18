namespace AnimationSystem.RootMotionTable;

public class ComputedClipNode : ComputedNode
{
	private const int POSITION_AND_ROTATION_CURVES_COUNT = 7; //Field offset: 0x0
	private Vector3 _posMotion; //Field offset: 0x40
	private float _timeScale; //Field offset: 0x4C
	private float _maxClipTime; //Field offset: 0x50
	private int _clipIndex; //Field offset: 0x54
	private bool _useCurvesForDeltaPosition; //Field offset: 0x58
	private MotionInfo _motionInfo; //Field offset: 0x5C
	private bool _storesRotation; //Field offset: 0x6C
	private AnimationCurve[] _rootCurves; //Field offset: 0x70

	public virtual EComputedNodeType NodeType
	{
		 get { } //Length: 3
	}

	public ComputedClipNode(IBlendParametersKeeper blendParametersKeeper) { }

	public ComputedClipNode(ICustomBlendTreeNode originalNode, int clipIndex, float timeScale, bool useCurvesForDP, AnimationCurve[] rootCurves) { }

	public virtual void ComputeActiveClips(List nodes, IParametersCache parametersCache) { }

	public virtual float ComputeClipTime(IParametersCache parametersCache) { }

	public virtual Quaternion ComputeDeltaRotation(float deltaTime, IParametersCache parametersCache) { }

	public virtual Vector3 ComputeRootPosition(float deltaTime, float stateNormalizedTime, IParametersCache parametersCache) { }

	public virtual void Deserialize(BinaryReader reader) { }

	private void DeserializeCurve(BinaryReader reader, out AnimationCurve curve) { }

	public virtual EComputedNodeType get_NodeType() { }

	public virtual void Serialize(BinaryWriter writer) { }

	private void SerializeCurve(BinaryWriter writer, AnimationCurve curve) { }

	public virtual void StoreAllVariants(RootMotionBlendTable rootMotionTable) { }

}

