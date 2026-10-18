namespace RootMotion.FinalIK;

public class AimPoser : MonoBehaviour
{
	internal class Pose
	{
		public bool visualize; //Field offset: 0x10
		public string name; //Field offset: 0x18
		public Vector3 direction; //Field offset: 0x20
		public float yaw; //Field offset: 0x2C
		public float pitch; //Field offset: 0x30
		private float angleBuffer; //Field offset: 0x34

		public Pose() { }

		public bool IsInDirection(Vector3 d) { }

		public void SetAngleBuffer(float value) { }

	}

	public float angleBuffer; //Field offset: 0x20
	public Pose[] poses; //Field offset: 0x28

	public AimPoser() { }

	public Pose GetPose(Vector3 localDirection) { }

	public void SetPoseActive(Pose pose) { }

}

