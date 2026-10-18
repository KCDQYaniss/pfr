namespace RootMotion.FinalIK;

public abstract class OffsetModifier : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <Initiate>d__8 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public OffsetModifier <>4__this; //Field offset: 0x20

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
		public <Initiate>d__8(int <>1__state) { }

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

	internal class OffsetLimits
	{
		[Tooltip("The effector type (this is just an enum)")]
		public FullBodyBipedEffector effector; //Field offset: 0x10
		[Tooltip("Spring force, if zero then this is a hard limit, if not, offset can exceed the limit.")]
		public float spring; //Field offset: 0x14
		[Tooltip("Which axes to limit the offset on?")]
		public bool x; //Field offset: 0x18
		[Tooltip("Which axes to limit the offset on?")]
		public bool y; //Field offset: 0x19
		[Tooltip("Which axes to limit the offset on?")]
		public bool z; //Field offset: 0x1A
		[Tooltip("The limits")]
		public float minX; //Field offset: 0x1C
		[Tooltip("The limits")]
		public float maxX; //Field offset: 0x20
		[Tooltip("The limits")]
		public float minY; //Field offset: 0x24
		[Tooltip("The limits")]
		public float maxY; //Field offset: 0x28
		[Tooltip("The limits")]
		public float minZ; //Field offset: 0x2C
		[Tooltip("The limits")]
		public float maxZ; //Field offset: 0x30

		public OffsetLimits() { }

		public void Apply(IKEffector e, Quaternion rootRotation) { }

		private float Spring(float value, float limit, bool negative) { }

		private float SpringAxis(float value, float min, float max) { }

	}

	[Tooltip("The master weight")]
	public float weight; //Field offset: 0x20
	[SerializeField]
	[Tooltip("Reference to the FBBIK component")]
	protected FullBodyBipedIK ik; //Field offset: 0x28
	private float lastTime; //Field offset: 0x30

	protected float deltaTime
	{
		 get { } //Length: 80
	}

	protected OffsetModifier() { }

	protected void ApplyLimits(OffsetLimits[] limits) { }

	protected float get_deltaTime() { }

	[IteratorStateMachine(typeof(<Initiate>d__8))]
	private IEnumerator Initiate() { }

	private void ModifyOffset() { }

	protected override void OnDestroy() { }

	protected abstract void OnModifyOffset() { }

	protected override void Start() { }

}

