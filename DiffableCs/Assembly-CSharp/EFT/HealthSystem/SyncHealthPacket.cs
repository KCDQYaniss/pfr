namespace EFT.HealthSystem;

public struct SyncHealthPacket : INestable
{
	internal enum ESyncType
	{
		AddEffect = 0,
		RemoveEffect = 1,
		EffectNextState = 2,
		EffectStateTime = 3,
		EffectStrength = 4,
		EffectMedResource = 5,
		EffectStimulatorBuff = 6,
		IsAlive = 7,
		BodyHealth = 8,
		Energy = 9,
		Hydration = 10,
		Temperature = 11,
		DamageCoeff = 12,
		ApplyDamage = 13,
		DestroyedBodyPart = 14,
		HealthRates = 15,
		HealerDone = 16,
		BurnEyes = 17,
		Poison = 18,
		StaminaCoeff = 19,
	}

	internal struct NetworkSyncHealthDataUnion
	{
		public SyncAddEffect AddEffect; //Field offset: 0x0
		public SyncHealthRates HealthRates; //Field offset: 0x0
		public SyncDestroyedBodyPart DestroyedBodyPart; //Field offset: 0x0
		public SyncApplyDamage ApplyDamage; //Field offset: 0x0
		public SyncStaminaCoeff StaminaCoeff; //Field offset: 0x0
		public SyncDamageCoeff DamageCoeff; //Field offset: 0x0
		public SyncHealthFactor Poison; //Field offset: 0x0
		public SyncHealthFactor Temperature; //Field offset: 0x0
		public SyncHealthFactor Hydration; //Field offset: 0x0
		public SyncHealthFactor Energy; //Field offset: 0x0
		public SyncBodyHealth BodyHealth; //Field offset: 0x0
		public SyncIsAlive IsAlive; //Field offset: 0x0
		public SyncEffectStimulatorBuff EffectStimulatorBuff; //Field offset: 0x0
		public SyncEffectMedResource EffectMedResource; //Field offset: 0x0
		public SyncEffectStrength EffectStrength; //Field offset: 0x0
		public SyncEffectStateTime EffectStateTime; //Field offset: 0x0
		public SyncEffectNextState EffectNextState; //Field offset: 0x0
		public SyncRemoveEffect RemoveEffect; //Field offset: 0x0
		public SyncHealerDone HealerDone; //Field offset: 0x0
		public SyncBurnEyes BurnEyes; //Field offset: 0x0

	}

	internal struct SyncAddEffect
	{
		internal enum EExtraDataType
		{
			None = 0,
			MedEffect = 1,
			Stimulator = 2,
		}

		internal struct ExtraDataUnion
		{
			public MedEffectStore MedEffect; //Field offset: 0x0
			public StimulatorStore Stimulator; //Field offset: 0x0

		}

		public int EffectId; //Field offset: 0x0
		public byte Type; //Field offset: 0x4
		public EBodyPart BodyPart; //Field offset: 0x8
		public float DelayTime; //Field offset: 0xC
		public float BuildUpTime; //Field offset: 0x10
		public float WorkTime; //Field offset: 0x14
		public float ResidueTime; //Field offset: 0x18
		public float Strength; //Field offset: 0x1C
		public EExtraDataType ExtraDataType; //Field offset: 0x20
		public ExtraDataUnion ExtraData; //Field offset: 0x28

		public virtual string ToString() { }

	}

	internal struct SyncApplyDamage
	{
		public EBodyPart BodyPart; //Field offset: 0x0
		public float Damage; //Field offset: 0x4
		public EDamageType DamageType; //Field offset: 0x8

		public virtual string ToString() { }

	}

	internal struct SyncBodyHealth
	{
		public EBodyPart BodyPart; //Field offset: 0x0
		public float Value; //Field offset: 0x4

		public virtual string ToString() { }

	}

	internal struct SyncBurnEyes
	{
		public Vector3 Position; //Field offset: 0x0
		public float DistanceStrength; //Field offset: 0xC
		public float NormalTime; //Field offset: 0x10

		public virtual string ToString() { }

	}

	internal struct SyncDamageCoeff
	{
		public float DamageCoeff; //Field offset: 0x0

		public virtual string ToString() { }

	}

	internal struct SyncDestroyedBodyPart
	{
		public EBodyPart BodyPart; //Field offset: 0x0
		public bool IsDestroyed; //Field offset: 0x4
		public EDamageType DamageType; //Field offset: 0x8
		public float HealthMaximum; //Field offset: 0xC

		public virtual string ToString() { }

	}

	internal struct SyncEffectMedResource
	{
		public int EffectId; //Field offset: 0x0
		public float Resource; //Field offset: 0x4

		public virtual string ToString() { }

	}

	internal struct SyncEffectNextState
	{
		public int EffectId; //Field offset: 0x0
		public float StateTime; //Field offset: 0x4

		public virtual string ToString() { }

	}

	internal struct SyncEffectStateTime
	{
		public int EffectId; //Field offset: 0x0
		public float RemainingStateTime; //Field offset: 0x4

		public virtual string ToString() { }

	}

	internal struct SyncEffectStimulatorBuff
	{
		public int EffectId; //Field offset: 0x0
		public int BuffIndex; //Field offset: 0x4
		public bool BuffActivate; //Field offset: 0x8
		public float BuffValue; //Field offset: 0xC
		public float BuffDuration; //Field offset: 0x10
		public float BuffDelay; //Field offset: 0x14

		public virtual string ToString() { }

	}

	internal struct SyncEffectStrength
	{
		public int EffectId; //Field offset: 0x0
		public float Strength; //Field offset: 0x4

		public virtual string ToString() { }

	}

	internal struct SyncHealerDone
	{
		public int EffectId; //Field offset: 0x0

		public virtual string ToString() { }

	}

	internal struct SyncHealthFactor
	{
		public float Value; //Field offset: 0x0

		public virtual string ToString() { }

	}

	internal struct SyncHealthRates
	{
		public float HealRate; //Field offset: 0x0
		public float DamageRate; //Field offset: 0x4
		public float DamageMultiplier; //Field offset: 0x8
		public float Energy; //Field offset: 0xC
		public float Hydration; //Field offset: 0x10
		public float Temperature; //Field offset: 0x14

		public virtual string ToString() { }

	}

	internal struct SyncIsAlive
	{
		public bool IsAlive; //Field offset: 0x0
		public EDamageType DamageType; //Field offset: 0x4

		public virtual string ToString() { }

	}

	internal struct SyncRemoveEffect
	{
		public int EffectId; //Field offset: 0x0

		public virtual string ToString() { }

	}

	internal struct SyncStaminaCoeff
	{
		public float StaminaCoeff; //Field offset: 0x0

		public virtual string ToString() { }

	}

	public ESyncType SyncType; //Field offset: 0x0
	public NetworkSyncHealthDataUnion Data; //Field offset: 0x8
	[CompilerGenerated]
	private INestable <Nested>k__BackingField; //Field offset: 0x48

	public override INestable Nested
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	[CompilerGenerated]
	[IsReadOnly]
	public override INestable get_Nested() { }

	[CompilerGenerated]
	public override void set_Nested(INestable value) { }

	public virtual string ToString() { }

}

