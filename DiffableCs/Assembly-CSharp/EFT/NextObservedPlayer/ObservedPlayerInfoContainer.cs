namespace EFT.NextObservedPlayer;

public class ObservedPlayerInfoContainer
{
	[CompilerGenerated]
	private string <Id>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private EPlayerSide <Side>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <NickName>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private float <Overweight>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private float <TransitionSpeed>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private bool <IsHeavyBreathing>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private float <WalkOverweight>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	private float <SoundRadius>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private bool <BreathIsAudible>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	private float <MinStepSound>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private float <BotSoundCoef>k__BackingField; //Field offset: 0x44
	[CompilerGenerated]
	private bool <HeavyVestNoBodyDamageDeflectChance>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private float <WeaponDurabilityLosOnShotReduce>k__BackingField; //Field offset: 0x4C
	[CompilerGenerated]
	private float <CovertMovementSpeed>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private float <CovertMovementHardSurfaceReduction>k__BackingField; //Field offset: 0x54
	[CompilerGenerated]
	private float <CovertMovementSoftSurfaceReduction>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private float <CovertMovementEquipment>k__BackingField; //Field offset: 0x5C
	[CompilerGenerated]
	private float <AimingVolumeReduction>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private float <PerkBushNoiseMultiplier>k__BackingField; //Field offset: 0x64
	[CompilerGenerated]
	private float <PerkBushSlowdownMultiplier>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private float <PerkRunSpeedMultiplier>k__BackingField; //Field offset: 0x6C

	public private float AimingVolumeReduction
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private float BotSoundCoef
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private bool BreathIsAudible
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private float CovertMovementEquipment
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private float CovertMovementHardSurfaceReduction
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private float CovertMovementSoftSurfaceReduction
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private float CovertMovementSpeed
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private bool HeavyVestNoBodyDamageDeflectChance
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private string Id
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private bool IsHeavyBreathing
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private float MinStepSound
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private string NickName
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private float Overweight
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private float PerkBushNoiseMultiplier
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private float PerkBushSlowdownMultiplier
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private float PerkRunSpeedMultiplier
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private EPlayerSide Side
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private float SoundRadius
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private float TransitionSpeed
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private float WalkOverweight
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private float WeaponDurabilityLosOnShotReduce
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public ObservedPlayerInfoContainer() { }

	private void ApplyPerkParametersCommand(PerksParamsCommandMessage perksParamsCommandMessage) { }

	private void ApplyPhysicalParametersCommand(PhysicalParametersCommandMessage physicalParametersCommandMessage) { }

	private void ApplySkillParametersCommand(SkillsParamsCommandMessage skillsParamsCommandMessage) { }

	public void Execute(ICommandMessage command) { }

	[CompilerGenerated]
	public float get_AimingVolumeReduction() { }

	[CompilerGenerated]
	public float get_BotSoundCoef() { }

	[CompilerGenerated]
	public bool get_BreathIsAudible() { }

	[CompilerGenerated]
	public float get_CovertMovementEquipment() { }

	[CompilerGenerated]
	public float get_CovertMovementHardSurfaceReduction() { }

	[CompilerGenerated]
	public float get_CovertMovementSoftSurfaceReduction() { }

	[CompilerGenerated]
	public float get_CovertMovementSpeed() { }

	[CompilerGenerated]
	public bool get_HeavyVestNoBodyDamageDeflectChance() { }

	[CompilerGenerated]
	public string get_Id() { }

	[CompilerGenerated]
	public bool get_IsHeavyBreathing() { }

	[CompilerGenerated]
	public float get_MinStepSound() { }

	[CompilerGenerated]
	public string get_NickName() { }

	[CompilerGenerated]
	public float get_Overweight() { }

	[CompilerGenerated]
	public float get_PerkBushNoiseMultiplier() { }

	[CompilerGenerated]
	public float get_PerkBushSlowdownMultiplier() { }

	[CompilerGenerated]
	public float get_PerkRunSpeedMultiplier() { }

	[CompilerGenerated]
	public EPlayerSide get_Side() { }

	[CompilerGenerated]
	public float get_SoundRadius() { }

	[CompilerGenerated]
	public float get_TransitionSpeed() { }

	[CompilerGenerated]
	public float get_WalkOverweight() { }

	[CompilerGenerated]
	public float get_WeaponDurabilityLosOnShotReduce() { }

	[CompilerGenerated]
	private void set_AimingVolumeReduction(float value) { }

	[CompilerGenerated]
	private void set_BotSoundCoef(float value) { }

	[CompilerGenerated]
	private void set_BreathIsAudible(bool value) { }

	[CompilerGenerated]
	private void set_CovertMovementEquipment(float value) { }

	[CompilerGenerated]
	private void set_CovertMovementHardSurfaceReduction(float value) { }

	[CompilerGenerated]
	private void set_CovertMovementSoftSurfaceReduction(float value) { }

	[CompilerGenerated]
	private void set_CovertMovementSpeed(float value) { }

	[CompilerGenerated]
	private void set_HeavyVestNoBodyDamageDeflectChance(bool value) { }

	[CompilerGenerated]
	private void set_Id(string value) { }

	[CompilerGenerated]
	private void set_IsHeavyBreathing(bool value) { }

	[CompilerGenerated]
	private void set_MinStepSound(float value) { }

	[CompilerGenerated]
	private void set_NickName(string value) { }

	[CompilerGenerated]
	private void set_Overweight(float value) { }

	[CompilerGenerated]
	private void set_PerkBushNoiseMultiplier(float value) { }

	[CompilerGenerated]
	private void set_PerkBushSlowdownMultiplier(float value) { }

	[CompilerGenerated]
	private void set_PerkRunSpeedMultiplier(float value) { }

	[CompilerGenerated]
	private void set_Side(EPlayerSide value) { }

	[CompilerGenerated]
	private void set_SoundRadius(float value) { }

	[CompilerGenerated]
	private void set_TransitionSpeed(float value) { }

	[CompilerGenerated]
	private void set_WalkOverweight(float value) { }

	[CompilerGenerated]
	private void set_WeaponDurabilityLosOnShotReduce(float value) { }

	public void SetUpSpawnInfo(ObservedPlayerSpawnMessage spawnMessage) { }

}

