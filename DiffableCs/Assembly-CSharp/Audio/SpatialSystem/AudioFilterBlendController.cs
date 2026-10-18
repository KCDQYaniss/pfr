namespace Audio.SpatialSystem;

public class AudioFilterBlendController : IManualUpdated
{
	private const float APPLY_EPS_FREQ = 1; //Field offset: 0x0
	private const float APPLY_EPS_Q = 0.001; //Field offset: 0x0
	private FilterBandRequest _spatialRequest; //Field offset: 0x10
	private bool _hasSpatialRequest; //Field offset: 0x28
	private FilterBandRequest _occluderRequest; //Field offset: 0x2C
	private bool _hasOccluderRequest; //Field offset: 0x44
	private float _smoothSpeed; //Field offset: 0x48
	private readonly IAudioEQFilter _eqFilter; //Field offset: 0x50
	private float _currentLowPassFreq; //Field offset: 0x58
	private float _currentHighPassFreq; //Field offset: 0x5C
	private float _currentLowPassQ; //Field offset: 0x60
	private float _currentHighPassQ; //Field offset: 0x64
	private float _targetLowPassFreq; //Field offset: 0x68
	private float _targetHighPassFreq; //Field offset: 0x6C
	private float _targetLowPassQ; //Field offset: 0x70
	private float _targetHighPassQ; //Field offset: 0x74
	private bool _hasTargetLowPass; //Field offset: 0x78
	private bool _hasTargetHighPass; //Field offset: 0x79
	private float _appliedLowPassFreq; //Field offset: 0x7C
	private float _appliedHighPassFreq; //Field offset: 0x80
	private float _appliedLowPassQ; //Field offset: 0x84
	private float _appliedHighPassQ; //Field offset: 0x88

	public AudioFilterBlendController(IAudioEQFilter eqFilter) { }

	private void ApplyHighPassIfNeeded() { }

	private void ApplyLowPassIfNeeded() { }

	public void ApplyNow(float lpFreq, float hpFreq, float lpQ, float hpQ) { }

	public void ApplyTargetsNow() { }

	public void ClearAllRequests() { }

	public void ClearRequest(ERequestSource source, bool applyImmediately = false) { }

	private void ComputeHighPassTarget() { }

	private void ComputeLowPassTarget() { }

	public override void ManualUpdate() { }

	private void RecalculateTargets() { }

	private void ResetTargets() { }

	public override void SetActive(bool active) { }

	public void SetSmoothSpeed(float smoothSpeed) { }

	private bool ShouldApplyHighPass(float freq, float q) { }

	private bool ShouldApplyLowPass(float freq, float q) { }

	public void Update(in FilterBandRequest request) { }

}

