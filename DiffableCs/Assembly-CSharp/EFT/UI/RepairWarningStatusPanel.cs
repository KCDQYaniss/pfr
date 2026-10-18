namespace EFT.UI;

public class RepairWarningStatusPanel : UIElement
{
	[SerializeField]
	private RepairWarningStatus _errorPanelTemplate; //Field offset: 0x70
	[SerializeField]
	private RepairWarningStatus _warningPanelTemplate; //Field offset: 0x78
	[SerializeField]
	private RepairWarningStatus _infoPanelTemplate; //Field offset: 0x80
	[SerializeField]
	private RepairWarningStatus _commonBuffPanelTemplate; //Field offset: 0x88
	[SerializeField]
	private RepairWarningStatus _rareBuffPanelTemplate; //Field offset: 0x90
	[SerializeField]
	private RectTransform _warningsPlaceholder; //Field offset: 0x98
	[SerializeField]
	private ConditionCharacteristicsSlider _characteristicsSlider; //Field offset: 0xA0
	[SerializeField]
	private CanvasGroup _repairerParametersPanel; //Field offset: 0xA8
	public readonly BindableEvent OnRepairStatusChanged; //Field offset: 0xB0
	private readonly Dictionary _repairWarnings; //Field offset: 0xB8
	private RepairWarningStatus _maximumDurabilityWarning; //Field offset: 0xC0
	private RepairWarningStatus _buffPossibilityInfo; //Field offset: 0xC8
	private RepairWarningStatus _commonBuff; //Field offset: 0xD0
	private RepairWarningStatus _rareBuff; //Field offset: 0xD8
	private Vector2 _range; //Field offset: 0xE0

	private RepairWarningStatus BuffPossibilityInfo
	{
		private get { } //Length: 462
	}

	private RepairWarningStatus CommonBuffInfo
	{
		private get { } //Length: 462
	}

	private RepairWarningStatus MaximumDurabilityWarning
	{
		private get { } //Length: 462
	}

	private RepairWarningStatus RareBuffInfo
	{
		private get { } //Length: 462
	}

	public RepairWarningStatusPanel() { }

	private RepairWarningStatus get_BuffPossibilityInfo() { }

	private RepairWarningStatus get_CommonBuffInfo() { }

	private RepairWarningStatus get_MaximumDurabilityWarning() { }

	private RepairWarningStatus get_RareBuffInfo() { }

	private void SetCanvasGroupActive(bool value) { }

	public void SetCriticalCondition(ERepairStatusWarning repairStatus, bool hasError, bool isWarningPanelVisible = true) { }

	public void ShowBuffPossibilityInfo(bool isVisible) { }

	public void ShowCommonBuffInfo(bool isVisible) { }

	public void ShowDurabilityWarning(float percent) { }

	public void ShowRareBuffInfo(bool isVisible) { }

	public void UpdateDegradationPrediction(Vector2 range) { }

}

