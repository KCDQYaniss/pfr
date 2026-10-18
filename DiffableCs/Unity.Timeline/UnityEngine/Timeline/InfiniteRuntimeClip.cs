namespace UnityEngine.Timeline;

internal class InfiniteRuntimeClip : RuntimeElement
{
	private static readonly long kIntervalEnd; //Field offset: 0x0
	private Playable m_Playable; //Field offset: 0x18

	public virtual bool enable
	{
		 set { } //Length: 117
	}

	public virtual long intervalEnd
	{
		 get { } //Length: 83
	}

	public virtual long intervalStart
	{
		 get { } //Length: 3
	}

	private static InfiniteRuntimeClip() { }

	public InfiniteRuntimeClip(Playable playable) { }

	public virtual void DisableAt(double localTime, double rootDuration, FrameData frameData) { }

	public virtual void EvaluateAt(double localTime, FrameData frameData) { }

	public virtual long get_intervalEnd() { }

	public virtual long get_intervalStart() { }

	public virtual void set_enable(bool value) { }

}

