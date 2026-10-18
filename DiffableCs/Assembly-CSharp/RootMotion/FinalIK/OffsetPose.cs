namespace RootMotion.FinalIK;

public class OffsetPose : MonoBehaviour
{
	internal class EffectorLink
	{
		public FullBodyBipedEffector effector; //Field offset: 0x10
		public Vector3 offset; //Field offset: 0x14
		public Vector3 pin; //Field offset: 0x20
		public Vector3 pinWeight; //Field offset: 0x2C

		public EffectorLink() { }

		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation) { }

	}

	public EffectorLink[] effectorLinks; //Field offset: 0x20

	public OffsetPose() { }

	public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation) { }

	public void Apply(IKSolverFullBodyBiped solver, float weight) { }

}

