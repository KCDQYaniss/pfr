namespace UnityEngine.Timeline;

internal class ActivationMixerPlayable : PlayableBehaviour
{
	private PostPlaybackState m_PostPlaybackState; //Field offset: 0x10
	private bool m_BoundGameObjectInitialStateIsActive; //Field offset: 0x14
	private GameObject m_BoundGameObject; //Field offset: 0x18

	public PostPlaybackState postPlaybackState
	{
		 get { } //Length: 164
		 set { } //Length: 4
	}

	public ActivationMixerPlayable() { }

	public static ScriptPlayable Create(PlayableGraph graph, int inputCount) { }

	public PostPlaybackState get_postPlaybackState() { }

	public virtual void OnPlayableDestroy(Playable playable) { }

	public virtual void ProcessFrame(Playable playable, FrameData info, object playerData) { }

	public void set_postPlaybackState(PostPlaybackState value) { }

}

