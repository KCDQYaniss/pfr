//Type is in global namespace

public class AGSMachineryBones : MonoBehaviour
{
	[SerializeField]
	private Transform _target; //Field offset: 0x20
	[SerializeField]
	private Transform _lever; //Field offset: 0x28
	[SerializeField]
	private Transform _verticalPart; //Field offset: 0x30
	[SerializeField]
	private Transform _scope; //Field offset: 0x38

	public Transform Lever
	{
		 get { } //Length: 5
	}

	public Transform Scope
	{
		 get { } //Length: 5
	}

	public Transform Target
	{
		 get { } //Length: 5
	}

	public Transform VerticalPart
	{
		 get { } //Length: 76
	}

	public AGSMachineryBones() { }

	public Transform get_Lever() { }

	public Transform get_Scope() { }

	public Transform get_Target() { }

	public Transform get_VerticalPart() { }

}

