namespace JsonType;

public class TransitSettings
{
	public ELocationTransition transitionType; //Field offset: 0x10
	public string transitionRaidId; //Field offset: 0x18
	public int transitionCount; //Field offset: 0x20
	public string[] visitedLocations; //Field offset: 0x28

	public TransitSettings() { }

	public virtual string ToString() { }

}

