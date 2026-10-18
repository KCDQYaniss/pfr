namespace RootMotion.FinalIK;

[RequireComponent(typeof(Animator))]
public class RagdollUtility : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <DisableRagdollSmooth>d__21 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public RagdollUtility <>4__this; //Field offset: 0x20

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <DisableRagdollSmooth>d__21(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal class Child
	{
		public Transform t; //Field offset: 0x10
		public Vector3 localPosition; //Field offset: 0x18
		public Quaternion localRotation; //Field offset: 0x24

		public Child(Transform transform) { }

		public void FixTransform(float weight) { }

		public void StoreLocalState() { }

	}

	internal class Rigidbone
	{
		public Rigidbody r; //Field offset: 0x10
		public Transform t; //Field offset: 0x18
		public Collider collider; //Field offset: 0x20
		public Joint joint; //Field offset: 0x28
		public Rigidbody c; //Field offset: 0x30
		public bool updateAnchor; //Field offset: 0x38
		public Vector3 deltaPosition; //Field offset: 0x3C
		public Quaternion deltaRotation; //Field offset: 0x48
		public float deltaTime; //Field offset: 0x58
		public Vector3 lastPosition; //Field offset: 0x5C
		public Quaternion lastRotation; //Field offset: 0x68

		public Rigidbone(Rigidbody r) { }

		public void RecordVelocity() { }

		public void WakeUp(float velocityWeight, float angularVelocityWeight) { }

	}

	[Tooltip("If you have multiple IK components, then this should be the one that solves last each frame.")]
	public IK ik; //Field offset: 0x20
	[Tooltip("How long does it take to blend from ragdoll to animation?")]
	public float ragdollToAnimationTime; //Field offset: 0x28
	[Tooltip("If true, IK can be used on top of physical ragdoll simulation.")]
	public bool applyIkOnRagdoll; //Field offset: 0x2C
	[Tooltip("How much velocity transfer from animation to ragdoll?")]
	public float applyVelocity; //Field offset: 0x30
	[Tooltip("How much angular velocity to transfer from animation to ragdoll?")]
	public float applyAngularVelocity; //Field offset: 0x34
	private Animator animator; //Field offset: 0x38
	private Rigidbone[] rigidbones; //Field offset: 0x40
	private Child[] children; //Field offset: 0x48
	private bool enableRagdollFlag; //Field offset: 0x50
	private AnimatorUpdateMode animatorUpdateMode; //Field offset: 0x54
	private IK[] allIKComponents; //Field offset: 0x58
	private bool[] fixTransforms; //Field offset: 0x60
	private float ragdollWeight; //Field offset: 0x68
	private float ragdollWeightV; //Field offset: 0x6C
	private bool fixedFrame; //Field offset: 0x70
	private bool[] disabledIKComponents; //Field offset: 0x78

	private bool ikUsed
	{
		private get { } //Length: 562
	}

	private bool isRagdoll
	{
		private get { } //Length: 239
	}

	public RagdollUtility() { }

	private void AfterAnimation() { }

	private void AfterLastIK() { }

	public void DisableRagdoll() { }

	[IteratorStateMachine(typeof(<DisableRagdollSmooth>d__21))]
	private IEnumerator DisableRagdollSmooth() { }

	public void EnableRagdoll() { }

	private void FixedUpdate() { }

	private void FixTransforms(float weight) { }

	private bool get_ikUsed() { }

	private bool get_isRagdoll() { }

	private void LateUpdate() { }

	private void OnDestroy() { }

	private void OnFinalPose() { }

	private void RagdollEnabler() { }

	private void RecordVelocities() { }

	public void Start() { }

	private void StoreLocalState() { }

	private void Update() { }

}

