namespace JsonType;

public class BackendExitTriggerSettings
{
	public string Name; //Field offset: 0x10
	public EExfiltrationType ExfiltrationType; //Field offset: 0x18
	public ERequirementState PassageRequirement; //Field offset: 0x1C
	public float ExfiltrationTime; //Field offset: 0x20
	public int PlayersCount; //Field offset: 0x24
	public string Id; //Field offset: 0x28
	public int Count; //Field offset: 0x30
	public EquipmentSlot RequiredSlot; //Field offset: 0x34
	public string RequirementTip; //Field offset: 0x38
	public float MinTime; //Field offset: 0x40
	public float MaxTime; //Field offset: 0x44
	public string EntryPoints; //Field offset: 0x48
	public float Chance; //Field offset: 0x50
	public bool EventAvailable; //Field offset: 0x54

	public BackendExitTriggerSettings() { }

}

