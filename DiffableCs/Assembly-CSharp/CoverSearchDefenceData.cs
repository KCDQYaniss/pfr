//Type is in global namespace

public class CoverSearchDefenceData
{
	[Obsolete]
	public float minDefenceLevel; //Field offset: 0x10
	[Obsolete]
	public int maxDangerLevel; //Field offset: 0x14

	public CoverSearchDefenceData(float minDefenceLevel, int maxDangerLevel) { }

	public CoverSearchDefenceData(float minDefenceLevel) { }

	public virtual string ToString() { }

}

