//Type is in global namespace

public class HandPoser : Poser
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__0_0; //Field offset: 0x8
		public static Func <>9__1_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal Quaternion <SaveRotationL>b__0_0(Transform x) { }

		internal Quaternion <SaveRotationR>b__1_0(Transform x) { }

	}

	[CompilerGenerated]
	private sealed class <Lerp2TargetRoutine>d__13 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public float t; //Field offset: 0x20
		public HandPoser <>4__this; //Field offset: 0x28
		public Quaternion[] qts; //Field offset: 0x30
		public float str; //Field offset: 0x38
		private float <endTime>5__2; //Field offset: 0x3C

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
		public <Lerp2TargetRoutine>d__13(int <>1__state) { }

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

	private Transform[] _children; //Field offset: 0x38
	private Transform[] _firstPersonPalm; //Field offset: 0x40
	private IWeaponGripPose _ikPalm; //Field offset: 0x48
	private IWeaponGripPose _currentGrip; //Field offset: 0x50
	private Transform[] _ikQuaternions; //Field offset: 0x58
	public float GripWeight; //Field offset: 0x60
	public float IKTresholdDistance; //Field offset: 0x64
	public bool IgnoreIndexFinger; //Field offset: 0x68

	private Transform[] Children
	{
		private get { } //Length: 43
	}

	public HandPoser() { }

	public virtual void AutoMapping() { }

	public void ClearMap() { }

	public virtual void FixTransforms() { }

	private Transform[] get_Children() { }

	private Quaternion GetFingerRotation(int index) { }

	public void InitChildren() { }

	public void Lerp2Target(Quaternion[] qts, float t = 2, float str = 0.5) { }

	[IteratorStateMachine(typeof(<Lerp2TargetRoutine>d__13))]
	public IEnumerator Lerp2TargetRoutine(Quaternion[] qts, float t = 2, float str = 0.5) { }

	public void ManualUpdate(bool skip = false) { }

	public void MapGrip(Transform t) { }

	public void MapIkPalm(GripPose t) { }

	public static int NumParents(Transform child, Transform parent, int index = 0) { }

	public void RemoveGripMapping() { }

	[ContextMenu("Save as left")]
	private void SaveRotationL() { }

	[ContextMenu("Save as right")]
	private void SaveRotationR() { }

	public void SetGrip(IWeaponGripPose grip) { }

	public void SimpleGrip(bool skip = false) { }

	private void Start() { }

	public virtual void StoreDefaultState() { }

}

