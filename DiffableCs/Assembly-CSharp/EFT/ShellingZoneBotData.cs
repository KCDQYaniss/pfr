namespace EFT;

public class ShellingZoneBotData
{
	public Vector3 Position; //Field offset: 0x10
	public float Radius; //Field offset: 0x1C
	public float RadiusSqr; //Field offset: 0x20
	public float StartTime; //Field offset: 0x24
	public float Duration; //Field offset: 0x28

	public ShellingZoneBotData(Vector3 position, float radius, float radiusSqr, float startTime = -1, float duration = -1) { }

}

