namespace CommonAssets.Scripts.Game.GameTriggers.Handlers;

public class HandlerPlayContinousSound : MonoBehaviour, ITriggerEntity
{
	[CompilerGenerated]
	private sealed class <get_InputTriggerIds>d__21 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private string <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public HandlerPlayContinousSound <>4__this; //Field offset: 0x28

		private override string System.Collections.Generic.IEnumerator<System.String>.Current
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
		public <get_InputTriggerIds>d__21(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

		[DebuggerHidden]
		private override string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <get_OutputTriggerIds>d__24 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private string <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20

		private override string System.Collections.Generic.IEnumerator<System.String>.Current
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
		public <get_OutputTriggerIds>d__24(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

		[DebuggerHidden]
		private override string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <PlaySoundCoroutine>d__14 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public HandlerPlayContinousSound <>4__this; //Field offset: 0x20

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
		public <PlaySoundCoroutine>d__14(int <>1__state) { }

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

	private struct PlaySoundBankConfig
	{
		public SoundBank SoundBank; //Field offset: 0x0
		[Range(0, 1)]
		public float Volume; //Field offset: 0x8
		public AudioSourceGroupType GroupType; //Field offset: 0xC
		public int RollOff; //Field offset: 0x10
		public float Pitch; //Field offset: 0x14
		public bool IsForceStereo; //Field offset: 0x18
		public EOcclusionTest OcclusionTest; //Field offset: 0x1C
		public AudioMixerGroup MixerGroup; //Field offset: 0x20

	}

	[SerializeField]
	private string _playTriggerId; //Field offset: 0x20
	[SerializeField]
	private string _stopTriggerId; //Field offset: 0x28
	[SerializeField]
	private PlaySoundBankConfig _soundsConfig; //Field offset: 0x30
	[SerializeField]
	private Transform _overrideSoundPosition; //Field offset: 0x58
	[SerializeField]
	private float _playingCooldown; //Field offset: 0x60
	[SerializeField]
	private bool _trackListenerPosChange; //Field offset: 0x64
	private AudioHandle _betterSourceHandle; //Field offset: 0x68
	private float _nextPlayingTime; //Field offset: 0x78
	private Coroutine _playingCoroutine; //Field offset: 0x80
	private bool _isPlaying; //Field offset: 0x88
	private Transform _listenerTransform; //Field offset: 0x90
	private Vector3 _prevListenerPos; //Field offset: 0x98

	public override GameObject GameObject
	{
		 get { } //Length: 78
	}

	public override IEnumerable InputTriggerIds
	{
		[IteratorStateMachine(typeof(<get_InputTriggerIds>d__21))]
		 get { } //Length: 175
	}

	public override bool IsClientAuthority
	{
		 get { } //Length: 3
	}

	public override IEnumerable OutputTriggerIds
	{
		[IteratorStateMachine(typeof(<get_OutputTriggerIds>d__24))]
		 get { } //Length: 80
	}

	public HandlerPlayContinousSound() { }

	[CompilerGenerated]
	private void <Start>b__13_0(TriggerEvent _) { }

	[CompilerGenerated]
	private void <Start>b__13_1(TriggerEvent _) { }

	public override GameObject get_GameObject() { }

	[IteratorStateMachine(typeof(<get_InputTriggerIds>d__21))]
	public override IEnumerable get_InputTriggerIds() { }

	public override bool get_IsClientAuthority() { }

	[IteratorStateMachine(typeof(<get_OutputTriggerIds>d__24))]
	public override IEnumerable get_OutputTriggerIds() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void PlaySound() { }

	private void PlaySound(PlaySoundBankConfig soundBankConfig) { }

	[IteratorStateMachine(typeof(<PlaySoundCoroutine>d__14))]
	private IEnumerator PlaySoundCoroutine() { }

	private void Start() { }

	private void StopSound() { }

	public override bool TryRenameId(string oldId, string newId) { }

}

