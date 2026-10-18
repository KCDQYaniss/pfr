namespace RootMotion.FinalIK;

public class HitReaction : OffsetModifier
{
	internal abstract class HitPoint
	{
		[Tooltip("Just for visual clarity, not used at all")]
		public string name; //Field offset: 0x10
		[Tooltip("Linking this hit point to a collider")]
		public Collider collider; //Field offset: 0x18
		public EBodyPartColliderType[] colliderTypes; //Field offset: 0x20
		public EBodyPart[] bodyParts; //Field offset: 0x28
		[SerializeField]
		[Tooltip("Only used if this hit point gets hit when already processing another hit")]
		private float crossFadeTime; //Field offset: 0x30
		[CompilerGenerated]
		private float <crossFader>k__BackingField; //Field offset: 0x34
		[CompilerGenerated]
		private float <timer>k__BackingField; //Field offset: 0x38
		[CompilerGenerated]
		private Vector3 <force>k__BackingField; //Field offset: 0x3C
		[CompilerGenerated]
		private Vector3 <point>k__BackingField; //Field offset: 0x48
		private float length; //Field offset: 0x54
		private float crossFadeSpeed; //Field offset: 0x58
		private float lastTime; //Field offset: 0x5C

		protected private float crossFader
		{
			[CompilerGenerated]
			 get { } //Length: 6
			[CompilerGenerated]
			private set { } //Length: 6
		}

		protected private Vector3 force
		{
			[CompilerGenerated]
			 get { } //Length: 19
			[CompilerGenerated]
			private set { } //Length: 16
		}

		protected private Vector3 point
		{
			[CompilerGenerated]
			 get { } //Length: 19
			[CompilerGenerated]
			private set { } //Length: 16
		}

		protected private float timer
		{
			[CompilerGenerated]
			 get { } //Length: 6
			[CompilerGenerated]
			private set { } //Length: 6
		}

		protected HitPoint() { }

		public void Apply(IKSolverFullBodyBiped solver, float weight) { }

		protected abstract void CrossFadeStart() { }

		[CompilerGenerated]
		protected float get_crossFader() { }

		[CompilerGenerated]
		protected Vector3 get_force() { }

		[CompilerGenerated]
		protected Vector3 get_point() { }

		[CompilerGenerated]
		protected float get_timer() { }

		protected abstract float GetLength() { }

		public void Hit(Vector3 force, Vector3 point) { }

		protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight) { }

		[CompilerGenerated]
		private void set_crossFader(float value) { }

		[CompilerGenerated]
		private void set_force(Vector3 value) { }

		[CompilerGenerated]
		private void set_point(Vector3 value) { }

		[CompilerGenerated]
		private void set_timer(float value) { }

	}

	internal class HitPointBone : HitPoint
	{
		internal class BoneLink
		{
			[Tooltip("Reference to the bone that this hit point rotates")]
			public Transform bone; //Field offset: 0x10
			[Range(0, 1)]
			[Tooltip("Weight of rotating the bone")]
			public float weight; //Field offset: 0x18
			private Quaternion lastValue; //Field offset: 0x1C
			private Quaternion current; //Field offset: 0x2C

			public BoneLink() { }

			public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader) { }

			public void CrossFadeStart() { }

		}

		[Tooltip("The angle to rotate the bone around it's rigidbody's world center of mass")]
		public AnimationCurve aroundCenterOfMass; //Field offset: 0x60
		[Tooltip("Linking this hit point to bone(s)")]
		public BoneLink[] boneLinks; //Field offset: 0x68
		private Rigidbody rigidbody; //Field offset: 0x70

		public HitPointBone() { }

		protected virtual void CrossFadeStart() { }

		protected virtual float GetLength() { }

		protected virtual void OnApply(IKSolverFullBodyBiped solver, float weight) { }

	}

	internal class HitPointEffector : HitPoint
	{
		internal class EffectorLink
		{
			[Tooltip("The FBBIK effector type")]
			public FullBodyBipedEffector effector; //Field offset: 0x10
			[Tooltip("The weight of this effector (could also be negative)")]
			public float weight; //Field offset: 0x14
			private Vector3 lastValue; //Field offset: 0x18
			private Vector3 current; //Field offset: 0x24

			public EffectorLink() { }

			public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader) { }

			public void CrossFadeStart() { }

		}

		[Tooltip("Offset magnitude in the direction of the hit force")]
		public AnimationCurve offsetInForceDirection; //Field offset: 0x60
		[Tooltip("Offset magnitude in the direction of character.up")]
		public AnimationCurve offsetInUpDirection; //Field offset: 0x68
		[Tooltip("Linking this offset to the FBBIK effectors")]
		public EffectorLink[] effectorLinks; //Field offset: 0x70

		public HitPointEffector() { }

		protected virtual void CrossFadeStart() { }

		protected virtual float GetLength() { }

		protected virtual void OnApply(IKSolverFullBodyBiped solver, float weight) { }

	}

	public List Recoil; //Field offset: 0x38
	[SerializeField]
	private HitPointEffector[] effectorHitPointsRecoil; //Field offset: 0x40
	[SerializeField]
	private HitPointBone[] boneHitPointsRecoil; //Field offset: 0x48
	[Tooltip("Hit points for the FBBIK effectors")]
	public HitPointEffector[] effectorHitPoints; //Field offset: 0x50
	[Tooltip(" Hit points for bones without an effector, such as the head")]
	public HitPointBone[] boneHitPoints; //Field offset: 0x58

	public HitReaction() { }

	public void Hit(EBodyPartColliderType colliderType, EBodyPart bodyPart, Vector3 force, Vector3 point, bool any = false) { }

	protected virtual void OnModifyOffset() { }

	protected virtual void Start() { }

}

