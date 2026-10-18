namespace UnityEngine.Timeline;

internal class RuntimeClip : RuntimeClipBase
{
	private TimelineClip m_Clip; //Field offset: 0x18
	private Playable m_Playable; //Field offset: 0x20
	private Playable m_ParentMixer; //Field offset: 0x30

	public TimelineClip clip
	{
		 get { } //Length: 5
	}

	public virtual double duration
	{
		 get { } //Length: 29
	}

	public virtual bool enable
	{
		 set { } //Length: 344
	}

	public Playable mixer
	{
		 get { } //Length: 11
	}

	public Playable playable
	{
		 get { } //Length: 11
	}

	public virtual double start
	{
		 get { } //Length: 45
	}

	public RuntimeClip(TimelineClip clip, Playable clipPlayable, Playable parentMixer) { }

	private void Create(TimelineClip clip, Playable clipPlayable, Playable parentMixer) { }

	public virtual void DisableAt(double localTime, double rootDuration, FrameData frameData) { }

	public virtual void EvaluateAt(double localTime, FrameData frameData) { }

	public TimelineClip get_clip() { }

	public virtual double get_duration() { }

	public Playable get_mixer() { }

	public Playable get_playable() { }

	public virtual double get_start() { }

	public virtual void set_enable(bool value) { }

	public void SetDuration(double duration) { }

	public void SetTime(double time) { }

}

