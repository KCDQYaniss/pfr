namespace RootMotion.FinalIK;

public class ConstraintRotationOffset : Constraint
{
	public Quaternion offset; //Field offset: 0x20
	private Quaternion defaultRotation; //Field offset: 0x30
	private Quaternion defaultLocalRotation; //Field offset: 0x40
	private Quaternion lastLocalRotation; //Field offset: 0x50
	private Quaternion defaultTargetLocalRotation; //Field offset: 0x60
	private bool initiated; //Field offset: 0x70

	private bool rotationChanged
	{
		private get { } //Length: 203
	}

	public ConstraintRotationOffset() { }

	public ConstraintRotationOffset(Transform transform) { }

	private bool get_rotationChanged() { }

	public virtual void UpdateConstraint() { }

}

