//Type is in global namespace

public class FastAnimatorStateDebugger : FastStateBehavior
{
	public string Name; //Field offset: 0x18

	public FastAnimatorStateDebugger() { }

	public virtual void OnStateEnter(FastAnimatorProcessor fastAnimatorProcessor, in AnimatorStateInfoWrapper layerInfo, int layerIndex) { }

	public virtual void OnStateExit(FastAnimatorProcessor fastAnimatorProcessor, in AnimatorStateInfoWrapper layerInfo, int layerIndex) { }

}

