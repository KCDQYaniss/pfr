namespace RootMotion.FinalIK;

public class Inertia : OffsetModifier
{
	internal class Body
	{
		internal class EffectorLink
		{
			[Tooltip("Type of the FBBIK effector to use")]
			public FullBodyBipedEffector effector; //Field offset: 0x10
			[Tooltip("Weight of using this effector")]
			public float weight; //Field offset: 0x14

			public EffectorLink() { }

		}

		[Tooltip("The Transform to follow, can be any bone of the character")]
		public Transform transform; //Field offset: 0x10
		[Tooltip("Linking the body to effectors. One Body can be used to offset more than one effector")]
		public EffectorLink[] effectorLinks; //Field offset: 0x18
		[Tooltip("The speed to follow the Transform")]
		public float speed; //Field offset: 0x20
		[Tooltip("The acceleration, smaller values means lazyer following")]
		public float acceleration; //Field offset: 0x24
		[Range(0, 1)]
		[Tooltip("Matching target velocity")]
		public float matchVelocity; //Field offset: 0x28
		[Tooltip("gravity applied to the Body")]
		public float gravity; //Field offset: 0x2C
		private Vector3 delta; //Field offset: 0x30
		private Vector3 lazyPoint; //Field offset: 0x3C
		private Vector3 direction; //Field offset: 0x48
		private Vector3 lastPosition; //Field offset: 0x54
		private bool firstUpdate; //Field offset: 0x60

		public Body() { }

		public void Reset() { }

		public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime) { }

	}

	[Tooltip("The array of Bodies")]
	public Body[] bodies; //Field offset: 0x38
	[Tooltip("The array of OffsetLimits")]
	public OffsetLimits[] limits; //Field offset: 0x40

	public Inertia() { }

	protected virtual void OnModifyOffset() { }

	public void ResetBodies() { }

}

