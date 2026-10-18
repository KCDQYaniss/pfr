namespace FastAnimatorSystem;

public interface IPlayableAnimator
{

	public IAnimator FastAnimator
	{
		 get { } //Length: 0
	}

	public PlayableGraph Graph
	{
		 get { } //Length: 0
	}

	public int LayersCount
	{
		 get { } //Length: 0
	}

	public bool ManualUpdateMode
	{
		 get { } //Length: 0
	}

	public IAnimator get_FastAnimator() { }

	public PlayableGraph get_Graph() { }

	public int get_LayersCount() { }

	public bool get_ManualUpdateMode() { }

	public AnimationClip GetClipByIndex(int layerIndex, int clipIndex) { }

	public IPlayableLayerProcessor GetLayerProcessor(int layerIndex) { }

	public float GetLayerWeight(int layerIndex) { }

	public void Play() { }

	public void Process(bool isVisible, float dt) { }

	public void RaiseImmediateTransitionHappened(int layerIndex) { }

	public void SetCuller(IPlayableAnimatorCuller culler) { }

	public void SetLayerWeight(int layerIndex, float weight) { }

	public void Stop() { }

}

