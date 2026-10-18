namespace FastAnimatorSystem;

public abstract class AbstractBlendTreeState : AbstractAnimatorControllerState
{
	protected bool _hasComputedNode; //Field offset: 0x70
	private FastAnimatorCache _parametersCache; //Field offset: 0x78
	private ComputedNode _computedNode; //Field offset: 0x80

	public virtual bool Loop
	{
		 get { } //Length: 18
	}

	protected virtual float RealMotionDuration
	{
		 get { } //Length: 43
	}

	protected AbstractBlendTreeState(string name, int hash, float speedMultiplier, AnimatorParameter speedAnimParam, List outTransitions) { }

	protected AbstractBlendTreeState(string name, int hash, float speedMultiplier, AnimatorParameter speedAnimParam) { }

	[CompilerGenerated]
	private void <Dispose>b__10_0(int parameterHash) { }

	[CompilerGenerated]
	private void <InitParametersCacheAndRootMotionTable>b__9_0(int parameterHash) { }

	protected virtual void Dispose(bool disposing) { }

	public virtual bool get_Loop() { }

	protected virtual float get_RealMotionDuration() { }

	public void InitParametersCacheAndRootMotionTable(IParametersCache parametersCache, ComputedNode computedNode) { }

}

