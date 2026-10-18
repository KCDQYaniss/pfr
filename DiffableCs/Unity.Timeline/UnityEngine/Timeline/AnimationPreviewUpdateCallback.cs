namespace UnityEngine.Timeline;

internal class AnimationPreviewUpdateCallback : ITimelineEvaluateCallback
{
	private AnimationPlayableOutput m_Output; //Field offset: 0x10
	private PlayableGraph m_Graph; //Field offset: 0x20
	private List m_PreviewComponents; //Field offset: 0x30

	public AnimationPreviewUpdateCallback(AnimationPlayableOutput output) { }

	public override void Evaluate() { }

	private void FetchPreviewComponents() { }

}

