//Type is in global namespace

public class BotZoneEntranceInfo : MonoBehaviour
{
	[FormerlySerializedAs("EntraceList")]
	public List EntranceList; //Field offset: 0x20
	private Dictionary _inGameData; //Field offset: 0x28

	public BotZoneEntranceInfo() { }

	public BotZoneEntrance GetClosest(Vector3 pos, int areaId) { }

	public void Init() { }

	public void OnDrawGizmosSelected() { }

}

