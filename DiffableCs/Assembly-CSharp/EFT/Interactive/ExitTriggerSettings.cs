namespace EFT.Interactive;

public class ExitTriggerSettings
{
	public string Id; //Field offset: 0x10
	public string Name; //Field offset: 0x18
	public EExfiltrationType ExfiltrationType; //Field offset: 0x20
	public float ExfiltrationTime; //Field offset: 0x24
	public int PlayersCount; //Field offset: 0x28
	[Header("Presence settings")]
	public float Chance; //Field offset: 0x2C
	public float MinTime; //Field offset: 0x30
	public float MaxTime; //Field offset: 0x34
	public int StartTime; //Field offset: 0x38
	public string EntryPoints; //Field offset: 0x40
	public bool EventAvailable; //Field offset: 0x48

	public ExitTriggerSettings() { }

	public void Load(BackendExitTriggerSettings settings, ExfiltrationPoint point) { }

}

