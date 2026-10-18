//Type is in global namespace

[StateBehaviorConverter(typeof(AnimatorStateDebuggerConverter))]
public class AnimatorStateDebugger : StateMachineBehaviour
{
	public string Name; //Field offset: 0x18

	public AnimatorStateDebugger() { }

	public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	public virtual void OnStateMachineEnter(Animator animator, int stateMachinePathHash) { }

	public virtual void OnStateMachineExit(Animator animator, int stateMachinePathHash) { }

}

