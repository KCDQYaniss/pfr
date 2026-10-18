namespace Audio.SpatialSystem;

public class AudioFilterRequestProvider : IDisposable, IAudioFilterRequestProvider, IManualUpdated
{
	private readonly AudioFilterBlendController _blendController; //Field offset: 0x10
	private FilterBandRequest _spatialRequest; //Field offset: 0x18
	private FilterBandRequest _occlusionRequest; //Field offset: 0x30

	public AudioFilterRequestProvider(AudioFilterBlendController controller) { }

	private override void Audio.SpatialSystem.IAudioFilterRequestProvider.SetOcclusionRequest(in FilterBandRequest request, bool applyImmediately) { }

	private override void Audio.SpatialSystem.IAudioFilterRequestProvider.SetSpatialRequest(in FilterBandRequest request, bool applyImmediately) { }

	public override void ClearAll() { }

	public override void ClearOcclusionRequest(bool applyImmediately = false) { }

	public override void ClearSpatialRequest() { }

	public override void Dispose() { }

	public override void ManualUpdate() { }

	public override void SetActive(bool active) { }

	public void SetOcclusionRequest(in FilterBandRequest request, bool applyImmediately = false) { }

	public void SetSpatialRequest(in FilterBandRequest request, bool applyImmediately = false) { }

}

