namespace RootMotion;

public class BipedLimbOrientations
{
	internal class LimbOrientation
	{
		public Vector3 upperBoneForwardAxis; //Field offset: 0x10
		public Vector3 lowerBoneForwardAxis; //Field offset: 0x1C
		public Vector3 lastBoneLeftAxis; //Field offset: 0x28

		public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis) { }

	}

	public LimbOrientation leftArm; //Field offset: 0x10
	public LimbOrientation rightArm; //Field offset: 0x18
	public LimbOrientation leftLeg; //Field offset: 0x20
	public LimbOrientation rightLeg; //Field offset: 0x28

	public static BipedLimbOrientations MaxBiped
	{
		 get { } //Length: 1131
	}

	public static BipedLimbOrientations UMA
	{
		 get { } //Length: 1131
	}

	public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg) { }

	public static BipedLimbOrientations get_MaxBiped() { }

	public static BipedLimbOrientations get_UMA() { }

}

