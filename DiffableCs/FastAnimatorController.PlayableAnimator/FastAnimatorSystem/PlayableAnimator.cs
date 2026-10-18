namespace FastAnimatorSystem;

public sealed class PlayableAnimator : MonoBehaviour, IPlayableAnimator
{
	public Animator outputAnimator; //Field offset: 0x20
	public InitialLayerInfo[] initialLayerInfo; //Field offset: 0x28
	private bool _initialized; //Field offset: 0x30
	private PlayableGraph _playableGraph; //Field offset: 0x38
	private List _layerProcessors; //Field offset: 0x48
	private List[] _allClips; //Field offset: 0x50
	private AnimationPlayableOutput _output; //Field offset: 0x58
	private AnimationLayerMixerPlayable _layerMixer; //Field offset: 0x68
	private IAnimator _animator; //Field offset: 0x78
	private IPlayableAnimatorCuller _culler; //Field offset: 0x80
	private bool _manualUpdate; //Field offset: 0x88

	public override IAnimator FastAnimator
	{
		 get { } //Length: 5
	}

	public override PlayableGraph Graph
	{
		 get { } //Length: 11
	}

	public bool Initialized
	{
		 get { } //Length: 5
	}

	public override int LayersCount
	{
		 get { } //Length: 78
	}

	public override bool ManualUpdateMode
	{
		 get { } //Length: 8
	}

	public PlayableAnimator() { }

	private void CreateLayerMixer() { }

	public override IAnimator get_FastAnimator() { }

	public override PlayableGraph get_Graph() { }

	public bool get_Initialized() { }

	public override int get_LayersCount() { }

	public override bool get_ManualUpdateMode() { }

	public override AnimationClip GetClipByIndex(int layerIndex, int clipIndex) { }

	public override IPlayableLayerProcessor GetLayerProcessor(int layerIndex) { }

	public override float GetLayerWeight(int layerIndex) { }

	public void Init(IAnimator animator, IParametersCache parametersCache, RootMotionBlendTable rootMotionBlendTable, CharacterClipsKeeper clipsKeeper, bool manualUpdate) { }

	private void OnAnimatorMove() { }

	private void OnDestroy() { }

	public override void Play() { }

	public override void Process(bool isVisible, float dt) { }

	public override void RaiseImmediateTransitionHappened(int layerIndex) { }

	public override void SetCuller(IPlayableAnimatorCuller culler) { }

	public override void SetLayerWeight(int layerIndex, float weight) { }

	public override void Stop() { }

}

