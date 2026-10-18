namespace EFT;

public sealed class LocalRaidSettings
{
	public string serverId; //Field offset: 0x10
	public string location; //Field offset: 0x18
	public EDateTime timeVariant; //Field offset: 0x20
	public ELocalMode mode; //Field offset: 0x24
	public ESideType playerSide; //Field offset: 0x28
	public ELocationTransition transitionType; //Field offset: 0x2C
	public TransitSettings transition; //Field offset: 0x30
	[JsonIgnore]
	public Location selectedLocation; //Field offset: 0x38

	public LocalRaidSettings() { }

	public virtual string ToString() { }

}

