//Type is in global namespace

public class PathConfig
{
	public string id; //Field offset: 0x10
	public string enterPoint; //Field offset: 0x18
	public string exitPoint; //Field offset: 0x20
	public List pathPoints; //Field offset: 0x28
	public bool once; //Field offset: 0x30
	public bool flipFlop; //Field offset: 0x31
	public int flipCount; //Field offset: 0x34
	public bool circle; //Field offset: 0x38
	public int circleCount; //Field offset: 0x3C
	public bool active; //Field offset: 0x40

	public PathConfig() { }

	public List GetAllPathPoints() { }

}

