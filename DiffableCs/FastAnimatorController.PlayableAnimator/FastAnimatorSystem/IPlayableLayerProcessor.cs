namespace FastAnimatorSystem;

public interface IPlayableLayerProcessor
{

	public int LayerIndex
	{
		 get { } //Length: 0
	}

	public AnimationMixerPlayable Mixer
	{
		 get { } //Length: 0
	}

	public int NodesCount
	{
		 get { } //Length: 0
	}

	public void EnableProfiling(bool val) { }

	public int get_LayerIndex() { }

	public AnimationMixerPlayable get_Mixer() { }

	public int get_NodesCount() { }

	public List GetLastProcessedActiveNodes() { }

	public float GetNodePreviousTime(int clipIndex) { }

	public float GetNodeTime(int clipIndex) { }

	public bool IsNextStateClip(int clipIndex) { }

	public void RaiseImmediateTransitionHappened() { }

}

