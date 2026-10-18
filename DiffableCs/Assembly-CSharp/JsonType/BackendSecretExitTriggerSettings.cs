namespace JsonType;

public class BackendSecretExitTriggerSettings
{
	public string Name; //Field offset: 0x10
	public float ExfiltrationTime; //Field offset: 0x18
	public string Id; //Field offset: 0x20
	public bool EligibleForScav; //Field offset: 0x28
	public bool EligibleForPMC; //Field offset: 0x29

	public BackendSecretExitTriggerSettings() { }

}

