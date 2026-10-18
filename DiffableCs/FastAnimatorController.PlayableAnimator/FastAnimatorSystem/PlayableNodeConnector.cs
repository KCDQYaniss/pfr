namespace FastAnimatorSystem;

public class PlayableNodeConnector
{
	private IPlayableAnimator _animator; //Field offset: 0x10
	private IPlayableLayerProcessor _layerProcessor; //Field offset: 0x18
	private List _playables; //Field offset: 0x20
	private List _previousConnected; //Field offset: 0x28

	public PlayableNodeConnector(IPlayableAnimator animator, IPlayableLayerProcessor layerProcessor, List playables) { }

	public void Process(List activeNodes) { }

}

