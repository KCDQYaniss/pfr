namespace UnityEngine.Timeline;

public class TimeControlPlayable : PlayableBehaviour
{
	private ITimeControl m_timeControl; //Field offset: 0x10
	private bool m_started; //Field offset: 0x18

	public TimeControlPlayable() { }

	public static ScriptPlayable Create(PlayableGraph graph, ITimeControl timeControl) { }

	public void Initialize(ITimeControl timeControl) { }

	public virtual void OnBehaviourPause(Playable playable, FrameData info) { }

	public virtual void OnBehaviourPlay(Playable playable, FrameData info) { }

	public virtual void PrepareFrame(Playable playable, FrameData info) { }

}

