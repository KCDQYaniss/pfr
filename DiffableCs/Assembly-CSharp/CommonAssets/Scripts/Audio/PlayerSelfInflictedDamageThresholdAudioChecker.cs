namespace CommonAssets.Scripts.Audio;

public class PlayerSelfInflictedDamageThresholdAudioChecker
{
	private const int DEFAULT_TICK_COUNT = 16; //Field offset: 0x0
	private readonly List _activeSelfInflictedDamageEffects; //Field offset: 0x10
	private readonly List _selfInflictedHealthEffects; //Field offset: 0x18
	private readonly ThresholdCounter _thresholdCounter; //Field offset: 0x20

	public PlayerSelfInflictedDamageThresholdAudioChecker() { }

	public void AddHealthEffect(IHealthEffect healthEffect) { }

	private void FillSelfInflictedHealthEffects() { }

	public void RemoveHealthEffect(IHealthEffect healthEffect) { }

	public bool TryReachThreshold(EDamageType damageType) { }

}

