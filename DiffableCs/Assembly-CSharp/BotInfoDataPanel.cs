//Type is in global namespace

public class BotInfoDataPanel : MonoBehaviour
{
	public DebugTextPanelWithManualLayout TextPanel; //Field offset: 0x20
	private readonly string lightGrayColor; //Field offset: 0x28
	private readonly string lightGreenColor; //Field offset: 0x30
	private readonly StringBuilder totalString; //Field offset: 0x38
	private RectTransform _rectTransf; //Field offset: 0x40

	public RectTransform RectTransform
	{
		 get { } //Length: 176
	}

	public BotInfoDataPanel() { }

	private string BloodlessString(bool val) { }

	private string BrokenString(bool val) { }

	public RectTransform get_RectTransform() { }

	private string GetBattleStateData(DebugBotStruct actorDataStruct, bool showLabels) { }

	private string GetBehaviourData(DebugBotStruct actorDataStruct, bool showLabels) { }

	private string GetCustomData(DebugBotStruct actorDataStruct, bool showLabels) { }

	private string GetHealthData(DebugBotStruct actorDataStruct) { }

	public string GetInfoText(DebugBotStruct botData, EBotInfoMode mode, bool showHints) { }

	private string GetSpecialsData(DebugBotStruct actorDataStruct, bool showLabels) { }

	private string GetTargetVisibilityData(DebugBotStruct botData, bool showHints) { }

	private string ShowModePatrol(DebugBotStruct actorDataStruct) { }

	public void UpdateData(DebugBotStruct actorData, EBotInfoMode mode, bool showHint) { }

}

