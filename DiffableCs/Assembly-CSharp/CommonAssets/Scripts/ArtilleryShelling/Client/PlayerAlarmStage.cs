namespace CommonAssets.Scripts.ArtilleryShelling.Client;

public class PlayerAlarmStage
{
	public ArtilleryShellingZone Zone; //Field offset: 0x10
	public Vector3 NearestShellingPoint; //Field offset: 0x98
	public IPlayer Player; //Field offset: 0xA8
	public Vector2 AlarmStage; //Field offset: 0xB0
	public float ElapsedTime; //Field offset: 0xB8
	public bool AlarmOn; //Field offset: 0xBC

	public PlayerAlarmStage() { }

}

