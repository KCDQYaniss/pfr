namespace Audio.Effects;

[RequireComponent(typeof(AudioHighPassFilter), typeof(AudioLowPassFilter))]
public sealed class AudioBuiltinEQFilter : AudioEQFilterBase
{
	[SerializeField]
	private AudioHighPassFilter _highPassFilter; //Field offset: 0x50
	[SerializeField]
	private AudioLowPassFilter _lowPassFilter; //Field offset: 0x58

	public AudioBuiltinEQFilter() { }

	protected virtual void ApplyHighPass(float frequency, float q) { }

	protected virtual void ApplyLowPass(float frequency, float q) { }

	protected virtual void InitializeComponents() { }

	protected virtual void OnHighPassEnabled(bool targetState) { }

	protected virtual void OnLowPassEnabled(bool targetState) { }

	protected virtual void OnSetActive(bool active) { }

}

