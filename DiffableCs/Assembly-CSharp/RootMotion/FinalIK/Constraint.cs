namespace RootMotion.FinalIK;

public abstract class Constraint
{
	public Transform transform; //Field offset: 0x10
	public float weight; //Field offset: 0x18

	public bool isValid
	{
		 get { } //Length: 203
	}

	protected Constraint() { }

	public bool get_isValid() { }

	public abstract void UpdateConstraint() { }

}

