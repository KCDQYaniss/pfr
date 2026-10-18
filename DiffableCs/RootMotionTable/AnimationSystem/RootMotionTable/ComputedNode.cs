namespace AnimationSystem.RootMotionTable;

public abstract class ComputedNode : ICustomBlendTreeNode
{
	internal enum EComputedNodeType
	{
		None = 0,
		Clip = 1,
		Tree = 2,
	}

	public List Childs; //Field offset: 0x10
	[CompilerGenerated]
	private readonly int <ParameterXHash>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly int <ParameterYHash>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private readonly float <MaxClipTime>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private bool <IsLooping>k__BackingField; //Field offset: 0x24
	internal ICustomBlendTreeNode OriginalNode; //Field offset: 0x28
	internal IBlendParametersKeeper BlendParamsKeeper; //Field offset: 0x30
	protected string NodeName; //Field offset: 0x38

	public override bool IsLooping
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override float MaxClipTime
	{
		[CompilerGenerated]
		 get { } //Length: 6
	}

	public override string Name
	{
		 get { } //Length: 5
	}

	public override EComputedNodeType NodeType
	{
		 get { } //Length: 3
	}

	public override int ParameterXHash
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public override int ParameterYHash
	{
		[CompilerGenerated]
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

	internal ComputedNode(ICustomBlendTreeNode originalNode) { }

	internal ComputedNode(IBlendParametersKeeper blendParamsKeeper) { }

	public override void ChildrensInitialized() { }

	public override void ComputeActiveClips(List nodes, IParametersCache parametersCache) { }

	public override float ComputeClipTime(IParametersCache parametersCache) { }

	public override Quaternion ComputeDeltaRotation(float deltaTime, IParametersCache parametersCache) { }

	public static Vector3 ComputeRootMotion(Animator animator, float deltaTime, float stateNormalizedTime, IParametersCache allParameters, Dictionary _cachedNodes) { }

	public override Vector3 ComputeRootPosition(float deltaTime, float stateNormalizedTime, IParametersCache parametersCache) { }

	public override void Deserialize(BinaryReader reader) { }

	[CompilerGenerated]
	public override bool get_IsLooping() { }

	[CompilerGenerated]
	public override float get_MaxClipTime() { }

	public override string get_Name() { }

	public override EComputedNodeType get_NodeType() { }

	[CompilerGenerated]
	public override int get_ParameterXHash() { }

	[CompilerGenerated]
	public override int get_ParameterYHash() { }

	public override Vector3 get_PosMotion() { }

	public override Quaternion get_PosRotation() { }

	public static void ProcessParameterRec(ComputedNode node, Action paramProcessor) { }

	public override void Serialize(BinaryWriter writer) { }

	[CompilerGenerated]
	protected void set_IsLooping(bool value) { }

	public override void StoreAllVariants(RootMotionBlendTable rootMotionTable) { }

}

