namespace EFT;

public sealed class RunddansGlobalSettings
{
	public bool active; //Field offset: 0x10
	public string[] locations; //Field offset: 0x18
	public string[] nonExitsLocations; //Field offset: 0x20
	public string[] sleighLocations; //Field offset: 0x28
	public string[] consumables; //Field offset: 0x30
	public string[] accessKeys; //Field offset: 0x38
	public float interactionDistance; //Field offset: 0x40
	public float repairSec; //Field offset: 0x44
	public float multitoolRepairSec; //Field offset: 0x48
	public Vector2 secToBreak; //Field offset: 0x4C
	public Vector2 durability; //Field offset: 0x54
	public float grenadeDistanceToBreak; //Field offset: 0x5C
	public float knifeCritChanceToBreak; //Field offset: 0x60
	public float rainForFrozen; //Field offset: 0x64
	public float initialFrozenDelaySec; //Field offset: 0x68
	public float applyFrozenEverySec; //Field offset: 0x6C
	public float fireDistanceToHeat; //Field offset: 0x70
	public int drunkImmunitySec; //Field offset: 0x74

	public int ApplyFrozenEveryMS
	{
		 get { } //Length: 18
	}

	public float FireDistanceToHeatSqr
	{
		 get { } //Length: 10
	}

	public RunddansGlobalSettings() { }

	public int get_ApplyFrozenEveryMS() { }

	public float get_FireDistanceToHeatSqr() { }

}

