namespace EFT;

public sealed class LocationTransit
{
	public string hash; //Field offset: 0x10
	public int playersCount; //Field offset: 0x18
	public string ip; //Field offset: 0x20
	public string location; //Field offset: 0x28
	public Dictionary profiles; //Field offset: 0x30
	public string transitionRaidId; //Field offset: 0x38
	public ERaidMode raidMode; //Field offset: 0x40
	public ESideType side; //Field offset: 0x44
	public EDateTime dayTime; //Field offset: 0x48

	public LocationTransit() { }

	public virtual string ToString() { }

}

