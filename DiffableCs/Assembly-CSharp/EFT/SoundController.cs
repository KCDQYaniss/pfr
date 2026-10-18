namespace EFT;

public class SoundController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <FindAudioListener>d__8 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public SoundController <>4__this; //Field offset: 0x20

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
		public <FindAudioListener>d__8(int <>1__state) { }

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

	private static SoundController _instance; //Field offset: 0x0
	public AudioMixerGroup OccludedGroup; //Field offset: 0x20
	public AudioMixerGroup DirectGroup; //Field offset: 0x28
	public AudioMixerGroup ObstructedGroup; //Field offset: 0x30
	public Transform AudioListenerTransform; //Field offset: 0x38

	public static SoundController Instance
	{
		 get { } //Length: 826
	}

	public SoundController() { }

	public float Distance(Vector3 target) { }

	[IteratorStateMachine(typeof(<FindAudioListener>d__8))]
	private IEnumerator FindAudioListener() { }

	public static SoundController get_Instance() { }

	public void SetAudioListener(AudioListener listener) { }

	private void Start() { }

}

