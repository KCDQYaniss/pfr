//Type is in global namespace

public class AuthorityBlendValue : StateMachineBehaviour
{
	[HideInInspector]
	public ValueBlender Blender; //Field offset: 0x18
	[HideInInspector]
	public ValueBlender Temporary_Right_Hand_Copy; //Field offset: 0x20
	public float Speed; //Field offset: 0x28
	public float Target; //Field offset: 0x2C
	public bool RightHand; //Field offset: 0x30

	public AuthorityBlendValue() { }

	public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

}

