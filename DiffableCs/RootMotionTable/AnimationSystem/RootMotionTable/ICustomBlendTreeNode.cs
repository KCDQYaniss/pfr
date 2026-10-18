namespace AnimationSystem.RootMotionTable;

public interface ICustomBlendTreeNode
{

	public bool IsLooping
	{
		 get { } //Length: 0
	}

	public float MaxClipTime
	{
		 get { } //Length: 0
	}

	public string Name
	{
		 get { } //Length: 0
	}

	public int ParameterXHash
	{
		 get { } //Length: 0
	}

	public int ParameterYHash
	{
		 get { } //Length: 0
	}

	public Vector3 PosMotion
	{
		 get { } //Length: 0
	}

	public Quaternion PosRotation
	{
		 get { } //Length: 0
	}

	public void ComputeActiveClips(List nodes, IParametersCache parametersCache) { }

	public float ComputeClipTime(IParametersCache parametersCache) { }

	public Quaternion ComputeDeltaRotation(float deltaTime, IParametersCache parametersCache) { }

	public Vector3 ComputeRootPosition(float deltaTime, float stateNormalizedTime, IParametersCache parametersCache) { }

	public bool get_IsLooping() { }

	public float get_MaxClipTime() { }

	public string get_Name() { }

	public int get_ParameterXHash() { }

	public int get_ParameterYHash() { }

	public Vector3 get_PosMotion() { }

	public Quaternion get_PosRotation() { }

}

