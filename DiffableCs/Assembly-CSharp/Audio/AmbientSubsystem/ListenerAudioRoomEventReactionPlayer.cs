namespace Audio.AmbientSubsystem;

public class ListenerAudioRoomEventReactionPlayer : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <CO_ReactionCoroutine>d__16 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public ListenerAudioRoomEventReactionPlayer <>4__this; //Field offset: 0x20
		public BetterAudio betterAudio; //Field offset: 0x28
		public EAudioRoomTypeMask listenerRoomType; //Field offset: 0x30
		private int <reactionCount>5__2; //Field offset: 0x34
		private int <i>5__3; //Field offset: 0x38

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
		public <CO_ReactionCoroutine>d__16(int <>1__state) { }

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

	private class PanSettings
	{
		[SerializeField]
		private Vector2 _lChannelPanRange; //Field offset: 0x10
		[SerializeField]
		private Vector2 _rChannelPanRange; //Field offset: 0x18

		public PanSettings() { }

		public float GetRandomPanValue() { }

	}

	[SerializeField]
	private BaseEventFilter[] _filtersToReact; //Field offset: 0x20
	[SerializeField]
	private SoundBank _reactionsSounds; //Field offset: 0x28
	[SerializeField]
	private EAudioRoomTypeMask _audioRoomTypeMask; //Field offset: 0x30
	[SerializeField]
	private Vector2Int _reactionsCountRange; //Field offset: 0x34
	[SerializeField]
	private PanSettings _panSettings; //Field offset: 0x40
	[SerializeField]
	private Vector2 _delaySecRange; //Field offset: 0x48
	[SerializeField]
	private AudioMixerGroup _audioMixerGroup; //Field offset: 0x50
	private bool _initialized; //Field offset: 0x58
	private Coroutine _reactionCoroutine; //Field offset: 0x60

	public ListenerAudioRoomEventReactionPlayer() { }

	private void Clear() { }

	[IteratorStateMachine(typeof(<CO_ReactionCoroutine>d__16))]
	private IEnumerator CO_ReactionCoroutine(BetterAudio betterAudio, EAudioRoomTypeMask listenerRoomType) { }

	private void FilterPassedHandler(BaseEventFilter filter, BaseEvent eventToReact) { }

	private void Init() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void Subscribe() { }

	private void Unsubscribe() { }

}

