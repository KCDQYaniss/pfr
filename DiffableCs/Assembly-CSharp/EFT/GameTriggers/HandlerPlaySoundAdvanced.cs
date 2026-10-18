namespace EFT.GameTriggers;

[Obfuscation(Exclude = True)]
public class HandlerPlaySoundAdvanced : MonoBehaviour, ITriggerEntity
{
	[CompilerGenerated]
	private sealed class <get_InputTriggerIds>d__18 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private string <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public HandlerPlaySoundAdvanced <>4__this; //Field offset: 0x28

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
		public <get_InputTriggerIds>d__18(int <>1__state) { }

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
	private sealed class <get_OutputTriggerIds>d__21 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
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
		public <get_OutputTriggerIds>d__21(int <>1__state) { }

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

	public struct PlaySoundConfig
	{
		public AudioClip AudioClip; //Field offset: 0x0
		[Range(0, 1)]
		public float Volume; //Field offset: 0x8
		public float StartFade; //Field offset: 0xC
		public float EndFade; //Field offset: 0x10
		public AudioSourceGroupType GroupType; //Field offset: 0x14
		public int RollOff; //Field offset: 0x18
		public float Pitch; //Field offset: 0x1C
		public bool IsForceStereo; //Field offset: 0x20
		public bool Loop; //Field offset: 0x21
		public EOcclusionTest OcclusionTest; //Field offset: 0x24
		public AudioMixerGroup MixerGroup; //Field offset: 0x28
		public AnimationCurve SpreadCurve; //Field offset: 0x30
		public bool EnableHighPassFilter; //Field offset: 0x38
		public bool NeedSubtitles; //Field offset: 0x39
		public string SubtitlesId; //Field offset: 0x40

	}

	[SerializeField]
	private string _playTriggerId; //Field offset: 0x20
	[SerializeField]
	private string _stopTriggerId; //Field offset: 0x28
	[SerializeField]
	private PlaySoundConfig[] _soundsPool; //Field offset: 0x30
	[SerializeField]
	private bool _playOnce; //Field offset: 0x38
	[SerializeField]
	private Transform _overrideSoundPosition; //Field offset: 0x40
	[SerializeField]
	private bool _trackTransform; //Field offset: 0x48
	[SerializeField]
	private AnimationCurve _rolloffCurve; //Field offset: 0x50
	private BetterSource _betterSource; //Field offset: 0x58
	private bool _isPlayed; //Field offset: 0x60
	private PlaySoundConfig _lastPlayedSoundConfig; //Field offset: 0x68

	public override GameObject GameObject
	{
		 get { } //Length: 78
	}

	public override IEnumerable InputTriggerIds
	{
		[IteratorStateMachine(typeof(<get_InputTriggerIds>d__18))]
		 get { } //Length: 175
	}

	public override bool IsClientAuthority
	{
		 get { } //Length: 3
	}

	public override IEnumerable OutputTriggerIds
	{
		[IteratorStateMachine(typeof(<get_OutputTriggerIds>d__21))]
		 get { } //Length: 80
	}

	public HandlerPlaySoundAdvanced() { }

	public override GameObject get_GameObject() { }

	[IteratorStateMachine(typeof(<get_InputTriggerIds>d__18))]
	public override IEnumerable get_InputTriggerIds() { }

	public override bool get_IsClientAuthority() { }

	[IteratorStateMachine(typeof(<get_OutputTriggerIds>d__21))]
	public override IEnumerable get_OutputTriggerIds() { }

	private void PlaySound(TriggerEvent triggerEvent) { }

	private void PlaySound(PlaySoundConfig soundConfig) { }

	private void PlaySubtitles(PlaySoundConfig soundConfig) { }

	private void ReleaseSource() { }

	private void Start() { }

	private void StopSound(TriggerEvent triggerEvent) { }

	public override bool TryRenameId(string oldId, string newId) { }

}

