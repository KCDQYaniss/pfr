namespace RootMotion.Demos;

public class UserControlAI : UserControlThirdPerson
{
	public Transform moveTarget; //Field offset: 0x48
	public float stoppingDistance; //Field offset: 0x50
	public float stoppingThreshold; //Field offset: 0x54

	public UserControlAI() { }

	protected virtual void Update() { }

}

