namespace EFT;

public abstract class HealthStatisticsManager
{
	private float _totalHealValue; //Field offset: 0x10
	private float _totalEnergyValue; //Field offset: 0x14
	private float _totalHydrationValue; //Field offset: 0x18
	private DamageStats _lastDamage; //Field offset: 0x20
	private EBodyPart _lastDamagedPart; //Field offset: 0x28
	protected DamageHistory DamageHistory; //Field offset: 0x30
	protected float HealingExp; //Field offset: 0x38
	[CompilerGenerated]
	private ExperienceSettings <GlobalExpConfig>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private Profile <Profile>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private IHealthController <HealthController>k__BackingField; //Field offset: 0x50

	protected private ExperienceSettings GlobalExpConfig
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected private IHealthController HealthController
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected private Profile Profile
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected HealthStatisticsManager() { }

	public override void BeginStatisticsSession() { }

	private void ConsumeEnergyExperience() { }

	public void ConsumeExperience() { }

	private void ConsumeHealExperience() { }

	private void ConsumeHydrationExperience() { }

	protected void EndStatisticsSession() { }

	protected override void ExperienceGained(float experience) { }

	[CompilerGenerated]
	protected ExperienceSettings get_GlobalExpConfig() { }

	[CompilerGenerated]
	protected IHealthController get_HealthController() { }

	[CompilerGenerated]
	protected Profile get_Profile() { }

	public void Init(Profile profile, IHealthController healthController) { }

	protected override bool IsRestoreHealsByHealing(DamageInfo damageInfo) { }

	protected override void LogDamage(EBodyPart bodyPart, float damage, DamageInfo damageInfo) { }

	private void OnApplyDamage(EBodyPart bodyPart, float damage, DamageInfo damageInfo) { }

	private void OnBodyPartDestroyed(EBodyPart bodyPart, EDamageType damageType) { }

	protected override void OnBodyPartRestored(EBodyPart bodyPart, ValueStruct oldHealth) { }

	private void OnEffectAdded(IHealthEffect effect) { }

	private void OnEffectRemoved(IHealthEffect effect) { }

	private void OnEnergyChanged(float diff) { }

	private void OnHealerDone(IHealthEffect effect) { }

	protected override void OnHealthChanged(EBodyPart bodyPart, float diff, DamageInfo damageInfo) { }

	private void OnHydrationChanged(float diff) { }

	protected override void OnPlayerDied(EDamageType damageType) { }

	protected override void RemoveOldDamage(EBodyPart bodyPart, float healthDiff) { }

	[CompilerGenerated]
	private void set_GlobalExpConfig(ExperienceSettings value) { }

	[CompilerGenerated]
	private void set_HealthController(IHealthController value) { }

	[CompilerGenerated]
	private void set_Profile(Profile value) { }

	protected override void ShowHealingNotification(float exp) { }

	protected abstract void ShowStatNotification(LocalizationKey localizationKey1, LocalizationKey localizationKey2, int value) { }

	protected override void StartDamageHistory() { }

}

