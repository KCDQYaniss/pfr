namespace EFT;

[Flags]
public enum EPhysicalCondition
{
	None = 0,
	OnPainkillers = 1,
	LeftLegDamaged = 2,
	RightLegDamaged = 4,
	ProneDisabled = 8,
	LeftArmDamaged = 16,
	RightArmDamaged = 32,
	Tremor = 64,
	UsingMeds = 128,
	HealingLegs = 256,
	JumpDisabled = 512,
	SprintDisabled = 1024,
	ProneMovementDisabled = 2048,
	Panic = 4096,
}

