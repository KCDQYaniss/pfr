//Type is in global namespace

public class NavGraphFindDebugSerializer : ISerializer
{
	[JsonProperty("centerPosition")]
	public Vector3 _centerPosition; //Field offset: 0x10
	[JsonProperty("startPoint")]
	public int _startPoint; //Field offset: 0x1C
	[JsonProperty("shootType")]
	public CoverShootType _shootType; //Field offset: 0x20
	[JsonProperty("botId")]
	public int _botId; //Field offset: 0x24
	[JsonProperty("steps")]
	public NavGraphFindDebugStepInfo[] _steps; //Field offset: 0x28
	[JsonProperty("endInfo")]
	public string _endInfo; //Field offset: 0x30
	[JsonProperty("zoneName")]
	public string _zoneName; //Field offset: 0x38
	[JsonProperty("ResultWayIds")]
	public int[] ResultWayIds; //Field offset: 0x40

	public NavGraphFindDebugSerializer() { }

	public override NavGraphFindDebug Deserialize() { }

	public override object Serialize(NavGraphFindDebug t) { }

}

