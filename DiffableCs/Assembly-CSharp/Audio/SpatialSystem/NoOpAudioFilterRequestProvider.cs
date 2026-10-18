namespace Audio.SpatialSystem;

public class NoOpAudioFilterRequestProvider : IAudioFilterRequestProvider, IManualUpdated
{

	public NoOpAudioFilterRequestProvider() { }

	private override void Audio.SpatialSystem.IAudioFilterRequestProvider.SetOcclusionRequest(in FilterBandRequest request, bool applyImmediately) { }

	private override void Audio.SpatialSystem.IAudioFilterRequestProvider.SetSpatialRequest(in FilterBandRequest request, bool applyImmediately) { }

	public override void ClearAll() { }

	public override void ClearOcclusionRequest(bool applyImmediately = false) { }

	public override void ClearSpatialRequest() { }

	public override void ManualUpdate() { }

	public override void SetActive(bool active) { }

	public void SetOcclusionRequest(in FilterBandRequest request, bool applyImmediately = false) { }

	public void SetSpatialRequest(in FilterBandRequest request, bool applyImmediately = false) { }

}

