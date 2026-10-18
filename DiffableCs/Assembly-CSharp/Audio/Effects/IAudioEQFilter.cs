namespace Audio.Effects;

public interface IAudioEQFilter : IManualUpdated
{

	public void Init() { }

	public void ResetValues() { }

	public void SetActiveHighPass(bool active) { }

	public void SetActiveLowPass(bool active) { }

	public void SetTargetHighPassSettings(float targetFrequency, float targetQ, bool applyImmediately = false) { }

	public void SetTargetLowPassSettings(float targetFrequency, float targetQ, bool applyImmediately = false) { }

}

