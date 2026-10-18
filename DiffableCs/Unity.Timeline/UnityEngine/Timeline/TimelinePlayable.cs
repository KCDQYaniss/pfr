namespace UnityEngine.Timeline;

public class TimelinePlayable : PlayableBehaviour
{
	internal static bool muteAudioScrubbing; //Field offset: 0x0
	private IntervalTree m_IntervalTree; //Field offset: 0x10
	private List m_ActiveClips; //Field offset: 0x18
	private List m_CurrentListOfActiveClips; //Field offset: 0x20
	private int m_ActiveBit; //Field offset: 0x28
	private List m_EvaluateCallbacks; //Field offset: 0x30
	private Dictionary m_PlayableCache; //Field offset: 0x38

	private static TimelinePlayable() { }

	public TimelinePlayable() { }

	private void CacheTrack(TrackAsset track, Playable playable, int port, Playable parent) { }

	public void Compile(PlayableGraph graph, Playable timelinePlayable, IEnumerable tracks, GameObject go, bool autoRebalance, bool createOutputs) { }

	private void CompileTrackList(PlayableGraph graph, Playable timelinePlayable, IEnumerable tracks, GameObject go, bool createOutputs) { }

	public static ScriptPlayable Create(PlayableGraph graph, IEnumerable tracks, GameObject go, bool autoRebalance, bool createOutputs) { }

	private void CreateTrackOutput(PlayableGraph graph, TrackAsset track, GameObject go, Playable playable, int port) { }

	private Playable CreateTrackPlayable(PlayableGraph graph, Playable timelinePlayable, TrackAsset track, GameObject go, bool createOutputs) { }

	private void Evaluate(Playable playable, FrameData frameData) { }

	private void EvaluateAnimationPreviewUpdateCallback(TrackAsset track, AnimationPlayableOutput animOutput) { }

	private void EvaluateWeightsForAnimationPlayableOutput(TrackAsset track, AnimationPlayableOutput animOutput) { }

	private static void ForAOTCompilationOnly() { }

	public virtual void PrepareFrame(Playable playable, FrameData info) { }

}

