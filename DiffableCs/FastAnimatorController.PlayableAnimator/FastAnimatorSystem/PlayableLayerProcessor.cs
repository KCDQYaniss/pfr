namespace FastAnimatorSystem;

public sealed class PlayableLayerProcessor : IPlayableLayerProcessor
{
	private readonly int _layerIndex; //Field offset: 0x10
	private readonly IPlayableAnimator _animator; //Field offset: 0x18
	private readonly IAnimator _fastAnimator; //Field offset: 0x20
	private readonly AnimationMixerPlayable _mixer; //Field offset: 0x28
	private readonly PlayableNodeConnector _nodeConnector; //Field offset: 0x38
	private readonly PlayableClipBlender _clipBlender; //Field offset: 0x40
	private readonly List _activeClips; //Field offset: 0x48
	private readonly List _activeClipsNextState; //Field offset: 0x50
	private readonly List _playables; //Field offset: 0x58
	private readonly IParametersCache _parametersCache; //Field offset: 0x60
	private readonly RootMotionBlendTable _rootTable; //Field offset: 0x68
	private readonly CharacterClipsKeeper _clipsKeeper; //Field offset: 0x70
	private readonly List _paramRelatedCurvesToApply; //Field offset: 0x78
	private readonly List _paramRelatedCurvesPrevFrame; //Field offset: 0x80
	private readonly List _paramRelatedCurvesValsToApply; //Field offset: 0x88
	private readonly List _nextStateClips; //Field offset: 0x90
	private bool _profilingEnabled; //Field offset: 0x98
	private List _lastFrameActiveNodes; //Field offset: 0xA0
	private int _prevStateHash; //Field offset: 0xA8
	private int _prevNextStateHash; //Field offset: 0xAC
	private bool _forceTranisitionHappened; //Field offset: 0xB0

	public override int LayerIndex
	{
		 get { } //Length: 164
	}

	public override AnimationMixerPlayable Mixer
	{
		 get { } //Length: 11
	}

	public override int NodesCount
	{
		 get { } //Length: 65
	}

	public PlayableLayerProcessor(int layerIndex, IPlayableAnimator animator, IParametersCache parametersCache, RootMotionBlendTable rootMotionBlendTable, CharacterClipsKeeper clipsKeeper, List allClips) { }

	private void AddParameterRelatedCurve(int parameterHash, float val) { }

	private AnimationMixerPlayable CreateMixer(List clips) { }

	public override void EnableProfiling(bool val) { }

	public override int get_LayerIndex() { }

	public override AnimationMixerPlayable get_Mixer() { }

	public override int get_NodesCount() { }

	public override List GetLastProcessedActiveNodes() { }

	public override float GetNodePreviousTime(int clipIndex) { }

	public override float GetNodeTime(int clipIndex) { }

	public override bool IsNextStateClip(int clipIndex) { }

	public void Process(float dt) { }

	private void ProcessParameterRelatedCurves() { }

	public override void RaiseImmediateTransitionHappened() { }

	private void SquashEqualActiveClips() { }

}

