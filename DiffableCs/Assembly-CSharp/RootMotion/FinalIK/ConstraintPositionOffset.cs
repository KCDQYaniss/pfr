namespace RootMotion.FinalIK;

public class ConstraintPositionOffset : Constraint
{
	public Vector3 offset; //Field offset: 0x20
	private Vector3 defaultLocalPosition; //Field offset: 0x2C
	private Vector3 lastLocalPosition; //Field offset: 0x38
	private bool initiated; //Field offset: 0x44

	private bool positionChanged
	{
		private get { } //Length: 199
	}

	public ConstraintPositionOffset() { }

	public ConstraintPositionOffset(Transform transform) { }

	private bool get_positionChanged() { }

	public virtual void UpdateConstraint() { }

}

