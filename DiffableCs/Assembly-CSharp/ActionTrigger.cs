//Type is in global namespace

public class ActionTrigger : MonoBehaviour
{
	public bool State; //Field offset: 0x20
	public Animator Target; //Field offset: 0x28
	public string StateFalseAnim; //Field offset: 0x30
	public string StateTrueAnim; //Field offset: 0x38
	public int Layer; //Field offset: 0x40

	public ActionTrigger() { }

	public void Use() { }

}

