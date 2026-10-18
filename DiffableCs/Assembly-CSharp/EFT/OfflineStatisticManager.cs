namespace EFT;

public sealed class OfflineStatisticManager : HealthStatisticsManager
{
	private float _fractionalExperience; //Field offset: 0x58

	public OfflineStatisticManager() { }

	public void EndStatisticsSession() { }

	protected virtual void ExperienceGained(float experience) { }

	protected virtual void LogDamage(EBodyPart bodyPart, float damage, DamageInfo damageInfo) { }

	protected virtual void OnHealthChanged(EBodyPart bodyPart, float diff, DamageInfo damageInfo) { }

	protected virtual void RemoveOldDamage(EBodyPart bodyPart, float healthDiff) { }

	protected virtual void ShowHealingNotification(float exp) { }

	protected virtual void ShowStatNotification(LocalizationKey localizationKey1, LocalizationKey localizationKey2, int value) { }

	protected virtual void StartDamageHistory() { }

}

