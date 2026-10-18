namespace RootMotion.FinalIK;

public class BodyTilt : OffsetModifier
{
	[Tooltip("Speed of tilting")]
	public float tiltSpeed; //Field offset: 0x38
	[Tooltip("Sensitivity of tilting")]
	public float tiltSensitivity; //Field offset: 0x3C
	[Tooltip("The OffsetPose components")]
	public OffsetPose poseLeft; //Field offset: 0x40
	[Tooltip("The OffsetPose components")]
	public OffsetPose poseRight; //Field offset: 0x48
	private float tiltAngle; //Field offset: 0x50
	private Vector3 lastForward; //Field offset: 0x54

	public BodyTilt() { }

	protected virtual void OnModifyOffset() { }

	protected virtual void Start() { }

}

