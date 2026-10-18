//Type is in global namespace

public class DebugPlayerAIData : MonoBehaviour
{
	public RectTransform IconsPanel; //Field offset: 0x20
	public DebugTextPanelWithManualLayout TextPanel; //Field offset: 0x28
	public BotInfoIcon IsInTree; //Field offset: 0x30
	public BotInfoIcon IsAggressor; //Field offset: 0x38
	public BotInfoIcon BossNoAttack; //Field offset: 0x40
	public BotInfoIcon CanBeFreeKilled; //Field offset: 0x48
	public BotInfoIcon IsPursuitable; //Field offset: 0x50
	public BotInfoIcon ScavAttacker; //Field offset: 0x58
	public BotInfoIcon IsAxe; //Field offset: 0x60
	private RectTransform _rectTransf; //Field offset: 0x68

	public RectTransform RectTransform
	{
		 get { } //Length: 176
	}

	public DebugPlayerAIData() { }

	public RectTransform get_RectTransform() { }

	public void UpdateData(DebugBotStruct actorData) { }

}

