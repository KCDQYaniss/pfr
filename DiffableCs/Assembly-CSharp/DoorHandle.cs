//Type is in global namespace

[ExecuteInEditMode]
public class DoorHandle : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <OpenCoroutine>d__18 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public DoorHandle <>4__this; //Field offset: 0x20
		private bool <playedUp>5__2; //Field offset: 0x28
		private float <animationTime>5__3; //Field offset: 0x2C

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
		public <OpenCoroutine>d__18(int <>1__state) { }

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

	private const int ROLL_OFF = 14; //Field offset: 0x0
	public Quaternion OpenRotation; //Field offset: 0x20
	public Quaternion DefaultRotation; //Field offset: 0x30
	public AnimationCurve OpenAnimation; //Field offset: 0x40
	public AnimationCurve LockedAnimation; //Field offset: 0x48
	public bool pos; //Field offset: 0x50
	public Vector3 OpenPosition; //Field offset: 0x54
	public Vector3 DefaultPosition; //Field offset: 0x60
	public AudioClip[] DownSound; //Field offset: 0x70
	public AudioClip[] UpSound; //Field offset: 0x78
	private float _startTime; //Field offset: 0x80
	[CompilerGenerated]
	private Action OnPlaySound; //Field offset: 0x88

	public event Action OnPlaySound
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public DoorHandle() { }

	[CompilerGenerated]
	public void add_OnPlaySound(Action value) { }

	public void Awake() { }

	[ContextMenu("Default Position")]
	public void DefPos() { }

	public void Open() { }

	[IteratorStateMachine(typeof(<OpenCoroutine>d__18))]
	public IEnumerator OpenCoroutine() { }

	[ContextMenu("Open Position")]
	public void OpenPos() { }

	[CompilerGenerated]
	public void remove_OnPlaySound(Action value) { }

	public void TryPlayDownSound() { }

}

