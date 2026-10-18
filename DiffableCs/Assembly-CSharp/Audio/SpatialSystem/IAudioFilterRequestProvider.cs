namespace Audio.SpatialSystem;

public interface IAudioFilterRequestProvider : IManualUpdated
{

	public void ClearAll() { }

	public void ClearOcclusionRequest(bool applyImmediately = false) { }

	public void ClearSpatialRequest() { }

	public void SetOcclusionRequest(in FilterBandRequest request, bool applyImmediately = false) { }

	public void SetSpatialRequest(in FilterBandRequest request, bool applyImmediately = false) { }

}

