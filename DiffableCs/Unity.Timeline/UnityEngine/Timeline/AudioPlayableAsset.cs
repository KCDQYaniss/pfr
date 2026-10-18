namespace UnityEngine.Timeline;

public class AudioPlayableAsset : PlayableAsset, ITimelineClipAsset
{
	[CompilerGenerated]
	private sealed class <get_outputs>d__16 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private PlayableBinding <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x38
		public AudioPlayableAsset <>4__this; //Field offset: 0x40

		private override PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 19
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 83
		}

		[DebuggerHidden]
		public <get_outputs>d__16(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator() { }

		[DebuggerHidden]
		private override PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[SerializeField]
	private AudioClip m_Clip; //Field offset: 0x18
	[SerializeField]
	private bool m_Loop; //Field offset: 0x20
	[HideInInspector]
	[SerializeField]
	private float m_bufferingTime; //Field offset: 0x24
	[SerializeField]
	private AudioClipProperties m_ClipProperties; //Field offset: 0x28

	internal float bufferingTime
	{
		internal get { } //Length: 6
		internal set { } //Length: 6
	}

	public AudioClip clip
	{
		 get { } //Length: 5
		 set { } //Length: 82
	}

	public override ClipCaps clipCaps
	{
		 get { } //Length: 14
	}

	public virtual double duration
	{
		 get { } //Length: 509
	}

	public bool loop
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public virtual IEnumerable outputs
	{
		[IteratorStateMachine(typeof(<get_outputs>d__16))]
		 get { } //Length: 175
	}

	public AudioPlayableAsset() { }

	public virtual Playable CreatePlayable(PlayableGraph graph, GameObject go) { }

	internal float get_bufferingTime() { }

	public AudioClip get_clip() { }

	public override ClipCaps get_clipCaps() { }

	public virtual double get_duration() { }

	public bool get_loop() { }

	[IteratorStateMachine(typeof(<get_outputs>d__16))]
	public virtual IEnumerable get_outputs() { }

	internal void set_bufferingTime(float value) { }

	public void set_clip(AudioClip value) { }

	public void set_loop(bool value) { }

}

