//Type is in global namespace

public struct DebugHeathsDataStructInner
{
	public bool Inited; //Field offset: 0x0
	public int HealthHead; //Field offset: 0x4
	public int HealthBody; //Field offset: 0x8
	public int HealthStomach; //Field offset: 0xC
	public int HealthLeftArm; //Field offset: 0x10
	public int HealthRightArm; //Field offset: 0x14
	public int HealthLeftLeg; //Field offset: 0x18
	public int HealthRightLeg; //Field offset: 0x1C
	public int MaxHealthHead; //Field offset: 0x20
	public int MaxHealthBody; //Field offset: 0x24
	public int MaxHealthStomach; //Field offset: 0x28
	public int MaxHealthLeftArm; //Field offset: 0x2C
	public int MaxHealthRightArm; //Field offset: 0x30
	public int MaxHealthLeftLeg; //Field offset: 0x34
	public int MaxHealthRightLeg; //Field offset: 0x38
	public bool HealthHeadBL; //Field offset: 0x3C
	public bool HealthBodyBL; //Field offset: 0x3D
	public bool HealthStomachBL; //Field offset: 0x3E
	public bool HealthLeftArmBL; //Field offset: 0x3F
	public bool HealthRightArmBL; //Field offset: 0x40
	public bool HealthLeftLegBL; //Field offset: 0x41
	public bool HealthRightLegBL; //Field offset: 0x42
	public bool HealthHeadBroken; //Field offset: 0x43
	public bool HealthBodyBroken; //Field offset: 0x44
	public bool HealthStomachBroken; //Field offset: 0x45
	public bool HealthLeftArmBroken; //Field offset: 0x46
	public bool HealthRightArmBroken; //Field offset: 0x47
	public bool HealthLeftLegBroken; //Field offset: 0x48
	public bool HealthRightLegBroken; //Field offset: 0x49
	public uint EffectsUint; //Field offset: 0x4C
	public float Energy; //Field offset: 0x50
	public float Hydration; //Field offset: 0x54

	public EDebugBotEffect Effects
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public EDebugBotEffect get_Effects() { }

	public void set_Effects(EDebugBotEffect value) { }

}

