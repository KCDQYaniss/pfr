namespace EFT.UI;

public abstract class LabelsTooltip`1 : Tooltip
{
	[SerializeField]
	private TMP_Text _headerText; //Field offset: 0x0
	[SerializeField]
	private GameObject _labelTemplate; //Field offset: 0x0
	[SerializeField]
	private Transform _labelsParent; //Field offset: 0x0
	[SerializeField]
	private Transform _conditionsText; //Field offset: 0x0
	[SerializeField]
	private LayoutElement _layoutElement; //Field offset: 0x0
	[SerializeField]
	protected List _labelsPool; //Field offset: 0x0

	protected LabelsTooltip`1() { }

	protected override void Show(string title, int labelsCount) { }

	private void TryCreateNewLabels(int labelsCount) { }

}

