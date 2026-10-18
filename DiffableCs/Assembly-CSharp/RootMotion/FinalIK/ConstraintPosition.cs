namespace RootMotion.FinalIK;

public class ConstraintPosition : Constraint
{
	public Vector3 position; //Field offset: 0x20

	public ConstraintPosition() { }

	public ConstraintPosition(Transform transform) { }

	public virtual void UpdateConstraint() { }

}

