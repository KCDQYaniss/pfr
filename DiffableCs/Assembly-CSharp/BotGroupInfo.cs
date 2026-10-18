//Type is in global namespace

public class BotGroupInfo : MonoBehaviour
{
	public TextMeshProUGUI field; //Field offset: 0x20
	private DebugGroupStruct _group; //Field offset: 0x28

	public BotGroupInfo() { }

	public void UpdateData(DebugGroupStruct group) { }

}

