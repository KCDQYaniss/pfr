namespace RootMotion.FinalIK;

public class ConstraintRotation : Constraint
{
	public Quaternion rotation; //Field offset: 0x20

	public ConstraintRotation() { }

	public ConstraintRotation(Transform transform) { }

	public virtual void UpdateConstraint() { }

}

