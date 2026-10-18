namespace JsonType;

public struct ServerMapBTRSettings
{
	public string MapID; //Field offset: 0x0
	public float ChanceSpawn; //Field offset: 0x8
	public float MoveSpeed; //Field offset: 0xC
	public float ReadyToDepartureTime; //Field offset: 0x10
	public float CheckTurnDistanceTime; //Field offset: 0x14
	public float TurnCheckSensitivity; //Field offset: 0x18
	public float DecreaseSpeedOnTurnLimit; //Field offset: 0x1C
	public float EndSplineDecelerationDistance; //Field offset: 0x20
	public float AccelerationSpeed; //Field offset: 0x24
	public float DecelerationSpeed; //Field offset: 0x28
	public float BodySwingReturnSpeed; //Field offset: 0x2C
	public float BodySwingDamping; //Field offset: 0x30
	public float BodySwingIntensity; //Field offset: 0x34
	public Vector2 SpawnPeriod; //Field offset: 0x38
	public Vector2 PauseDurationRange; //Field offset: 0x40

}

