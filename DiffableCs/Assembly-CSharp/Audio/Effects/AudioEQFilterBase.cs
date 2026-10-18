namespace Audio.Effects;

public abstract class AudioEQFilterBase : MonoBehaviour, IAudioEQFilter, IManualUpdated
{
	[SerializeField]
	protected float lerpSpeed; //Field offset: 0x20
	[SerializeField]
	protected float shelfFilterQ; //Field offset: 0x24
	protected float _targetHpf; //Field offset: 0x28
	protected float _targetLpf; //Field offset: 0x2C
	protected float _targetHpfQ; //Field offset: 0x30
	protected float _targetLpfQ; //Field offset: 0x34
	protected float _currentHpf; //Field offset: 0x38
	protected float _currentLpf; //Field offset: 0x3C
	protected float _currentHpfQ; //Field offset: 0x40
	protected float _currentLpfQ; //Field offset: 0x44
	protected bool _isInitialized; //Field offset: 0x48
	protected bool _highPassEnabled; //Field offset: 0x49
	protected bool _lowPassEnabled; //Field offset: 0x4A

	protected AudioEQFilterBase() { }

	private void ApplyCurrentValues(bool forced = false) { }

	protected abstract void ApplyHighPass(float frequency, float q) { }

	protected abstract void ApplyLowPass(float frequency, float q) { }

	public override void Init() { }

	protected abstract void InitializeComponents() { }

	public override void ManualUpdate() { }

	protected abstract void OnHighPassEnabled(bool targetState) { }

	protected abstract void OnLowPassEnabled(bool targetState) { }

	protected abstract void OnSetActive(bool active) { }

	protected override void OnUpdate() { }

	public override void ResetValues() { }

	public override void SetActive(bool active) { }

	public override void SetActiveHighPass(bool active) { }

	public override void SetActiveLowPass(bool active) { }

	public override void SetTargetHighPassSettings(float targetFrequency, float targetQ, bool applyImmediately = false) { }

	public override void SetTargetLowPassSettings(float targetFrequency, float targetQ, bool applyImmediately = false) { }

}

