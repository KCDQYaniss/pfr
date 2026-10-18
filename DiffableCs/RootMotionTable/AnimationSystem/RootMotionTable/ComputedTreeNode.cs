namespace AnimationSystem.RootMotionTable;

public class ComputedTreeNode : ComputedNode
{
	private CustomBlendTree _customBlendTree; //Field offset: 0x40
	private float[] _weightsBuffer; //Field offset: 0x48
	private float[] _weightsBuffer2; //Field offset: 0x50
	private float[][][] _computedWeights; //Field offset: 0x58
	private int _totalStepsX; //Field offset: 0x60
	private int _totalStepsY; //Field offset: 0x64
	private int _totalChildrens; //Field offset: 0x68
	private bool _storeRotations; //Field offset: 0x6C
	private ParameterSettings _parameterX; //Field offset: 0x70
	private ParameterSettings _parameterY; //Field offset: 0x78

	public virtual EComputedNodeType NodeType
	{
		 get { } //Length: 3
	}

	public virtual int ParameterXHash
	{
		 get { } //Length: 26
	}

	public virtual int ParameterYHash
	{
		 get { } //Length: 26
	}

	public ComputedTreeNode(IBlendParametersKeeper blendParamsKeeper) { }

	public ComputedTreeNode(CustomBlendTree customBlendTree, ICustomBlendTreeNode originalNode, IBlendParametersKeeper blendParamsKeeper, bool storeRotations) { }

	private void AllocComputedData() { }

	private void Blend(int stepX, int stepY1, int stepY2, float t, float[] weightsBuffer) { }

	private void CalculateWeights(IParametersCache allParameters) { }

	public virtual void ChildrensInitialized() { }

	public virtual void ComputeActiveClips(List nodes, IParametersCache parametersCache) { }

	public virtual float ComputeClipTime(IParametersCache allParameters) { }

	public virtual Quaternion ComputeDeltaRotation(float deltaTime, IParametersCache allParameters) { }

	public virtual Vector3 ComputeRootPosition(float deltaTime, float stateNormalizedTime, IParametersCache allParameters) { }

	public virtual void Deserialize(BinaryReader reader) { }

	public virtual EComputedNodeType get_NodeType() { }

	public virtual int get_ParameterXHash() { }

	public virtual int get_ParameterYHash() { }

	public virtual void Serialize(BinaryWriter writer) { }

	public virtual void StoreAllVariants(RootMotionBlendTable rootMotionTable) { }

}

