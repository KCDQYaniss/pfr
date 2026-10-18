namespace RootMotion.FinalIK;

public class Amplifier : OffsetModifier
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

		[Tooltip("The Transform that's motion we are reading.")]
		public Transform transform; //Field offset: 0x10
		[Tooltip("Amplify the 'transform's' position relative to this Transform.")]
		public Transform relativeTo; //Field offset: 0x18
		[Tooltip("Linking the body to effectors. One Body can be used to offset more than one effector.")]
		public EffectorLink[] effectorLinks; //Field offset: 0x20
		[Tooltip("Amplification magnitude along the up axis of the character.")]
		public float verticalWeight; //Field offset: 0x28
		[Tooltip("Amplification magnitude along the horizontal axes of the character.")]
		public float horizontalWeight; //Field offset: 0x2C
		[Tooltip("Speed of the amplifier. 0 means instant.")]
		public float speed; //Field offset: 0x30
		private Vector3 lastRelativePos; //Field offset: 0x34
		private Vector3 smoothDelta; //Field offset: 0x40
		private bool firstUpdate; //Field offset: 0x4C

		public Body() { }

		private static Vector3 Multiply(Vector3 v1, Vector3 v2) { }

		public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime) { }

	}

	[Tooltip("The amplified bodies.")]
	public Body[] bodies; //Field offset: 0x38

	public Amplifier() { }

	protected virtual void OnModifyOffset() { }

}

