//Type is in global namespace

public class ShortStatsPanel : MonoBehaviour
{
	[SerializeField]
	private LocalizedText _raids; //Field offset: 0x20
	[SerializeField]
	private LocalizedText _kills; //Field offset: 0x28
	[SerializeField]
	private LocalizedText _leaveRate; //Field offset: 0x30
	[SerializeField]
	private LocalizedText _survivalRate; //Field offset: 0x38
	[SerializeField]
	private LocalizedText _killsDeathRate; //Field offset: 0x40
	[SerializeField]
	private LocalizedText _onlineTime; //Field offset: 0x48

	public ShortStatsPanel() { }

	public void SetStats(float raids, float kills, float leaveRate, float survivalRate, float killsDeathRate, string onlineTime) { }

}

