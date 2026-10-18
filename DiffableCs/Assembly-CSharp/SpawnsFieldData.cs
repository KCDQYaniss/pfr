//Type is in global namespace

public class SpawnsFieldData : MonoBehaviour
{
	[SerializeField]
	private TextMeshProUGUI _aliveField; //Field offset: 0x20
	[SerializeField]
	private TextMeshProUGUI _groupsField; //Field offset: 0x28

	public SpawnsFieldData() { }

	public void UpdateView(DebugBotSpawnStruct spawn) { }

}

