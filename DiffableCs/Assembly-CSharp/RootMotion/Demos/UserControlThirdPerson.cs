namespace RootMotion.Demos;

public class UserControlThirdPerson : MonoBehaviour
{
	internal struct State
	{
		public Vector3 move; //Field offset: 0x0
		public Vector3 lookPos; //Field offset: 0xC
		public bool crouch; //Field offset: 0x18
		public bool jump; //Field offset: 0x19

	}

	public bool walkByDefault; //Field offset: 0x20
	public bool canCrouch; //Field offset: 0x21
	public bool canJump; //Field offset: 0x22
	public State state; //Field offset: 0x24
	protected Transform cam; //Field offset: 0x40

	public UserControlThirdPerson() { }

	private void Start() { }

	protected override void Update() { }

}

