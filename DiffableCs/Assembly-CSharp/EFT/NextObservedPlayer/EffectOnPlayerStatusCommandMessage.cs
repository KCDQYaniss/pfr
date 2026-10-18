namespace EFT.NextObservedPlayer;

public class EffectOnPlayerStatusCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	internal enum EHealthEffectType
	{
		None = 0,
		HeavyBleeding = 1,
		Fracture = 2,
		LightBleeding = 3,
		Contusion = 4,
		Pain = 5,
		Stun = 6,
		Flash = 7,
		Tremor = 8,
		Intoxication = 9,
		LethalIntoxication = 10,
		RadExposure = 11,
		Dehydration = 12,
		Exhaustion = 13,
		FullHealthRegeneration = 14,
		Regeneration = 15,
		Berserk = 16,
		BodyTemperature = 17,
		Disorientation = 18,
		ZombieInfection = 19,
		LowEdgeHealth = 20,
		PainKiller = 21,
		SandingScreen = 22,
		Wound = 23,
		TunnelVision = 24,
		Encumbered = 25,
		OverEncumbered = 26,
		ChronicStaminaFatigue = 27,
		ImmunityPreventedNegativeEffect = 28,
		HalloweenBuff = 29,
		Misfire = 30,
		StaminaZero = 31,
		Panic = 32,
		Frostbite = 33,
		TearGas = 34,
		DamageModifier = 35,
		HealthBoost = 36,
		Endurance = 37,
		Stimulator = 38,
		StimulatorBuff = 39,
		StimulatorDebuff = 40,
		MusclePain = 41,
	}

	public EHealthEffectType ChangedEffectType; //Field offset: 0x10
	public bool IsActive; //Field offset: 0x14

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public EffectOnPlayerStatusCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static EffectOnPlayerStatusCommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public static bool GetEffectTypeForChange(out EHealthEffectType effectType, IHealthEffect healthEffect) { }

	public static bool GetEffectTypeForDisplayType(out EHealthEffectType effectType, Type displayType) { }

	public override void Serialize(NetworkWriter writer) { }

}

