namespace FastAnimatorSystem;

public class PlayableClipBlender
{
	private double _currentStateNormalizedTime; //Field offset: 0x10
	private double _nextStateNormalizedTime; //Field offset: 0x18
	private IPlayableAnimator _animator; //Field offset: 0x20
	private IPlayableLayerProcessor _layerProcessor; //Field offset: 0x28
	private List _allClips; //Field offset: 0x30
	private List _playables; //Field offset: 0x38
	private int _swapCounter; //Field offset: 0x40
	private bool _prev; //Field offset: 0x44

	public PlayableClipBlender(IPlayableLayerProcessor layerProcessor, List playables, List allClips) { }

	public void BlendClips(bool isInTransition, bool isTransitionWasInterrupted, float startTranNormalizedOffset, List nextStateNodeIndexes, List nodes, float stateSpeed, float nextStateSpeed) { }

	private float GetTotalWeight(bool isInTransition, List nextStateNodeIndexes, List nodes, bool calcOnlyCurrentStateWeights = true) { }

	private void ResetTimeDuringTransition(bool isInTransition, bool isTransitionWasInterrupted, float startTranNormalizedOffset) { }

}

