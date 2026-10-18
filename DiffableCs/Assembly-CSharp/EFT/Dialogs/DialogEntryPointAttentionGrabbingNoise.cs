namespace EFT.Dialogs;

public class DialogEntryPointAttentionGrabbingNoise : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <PlayIntervalAudioCoroutine>d__12 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public DialogEntryPointAttentionGrabbingNoise <>4__this; //Field offset: 0x20

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
		public <PlayIntervalAudioCoroutine>d__12(int <>1__state) { }

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

	private struct TraderAudioPool
	{
		public ETraderType TraderType; //Field offset: 0x0
		public AudioClip[] AudioClips; //Field offset: 0x8

	}

	[SerializeField]
	private AudioClip[] _defaultAudioClips; //Field offset: 0x20
	[SerializeField]
	private List _traderAudioPools; //Field offset: 0x28
	[SerializeField]
	private AudioSource _audioSource; //Field offset: 0x30
	[SerializeField]
	private float _audioClipsIntervalSeconds; //Field offset: 0x38
	[SerializeField]
	private bool _loopSound; //Field offset: 0x3C
	private Coroutine _audioCoroutine; //Field offset: 0x40
	private Dictionary _traderAudioClips; //Field offset: 0x48
	private AudioClip[] _selectedAudioClips; //Field offset: 0x50

	public DialogEntryPointAttentionGrabbingNoise() { }

	private void Awake() { }

	[IteratorStateMachine(typeof(<PlayIntervalAudioCoroutine>d__12))]
	private IEnumerator PlayIntervalAudioCoroutine() { }

	public void StartNoise(ETraderType traderType = -1) { }

	public void StopNoise() { }

}

