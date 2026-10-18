namespace CommonAssets.Scripts.ArtilleryShelling.Client;

public class ShellingZoneState
{
	public string zoneId; //Field offset: 0x10
	public int volleyFinished; //Field offset: 0x18
	public int shotsComplete; //Field offset: 0x1C
	public int volleyPause; //Field offset: 0x20
	public bool inShelling; //Field offset: 0x24
	public Vector3 center; //Field offset: 0x28
	public Vector3[] shellingPoints; //Field offset: 0x38

	public ShellingZoneState() { }

}

