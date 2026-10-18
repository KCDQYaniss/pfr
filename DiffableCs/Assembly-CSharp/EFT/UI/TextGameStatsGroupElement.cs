namespace EFT.UI;

public sealed class TextGameStatsGroupElement : UIElement
{
	[SerializeField]
	private TextMeshProUGUI _titleText; //Field offset: 0x70
	[SerializeField]
	private Transform _variablesContainer; //Field offset: 0x78
	[SerializeField]
	private TextGameStatsVariableElement _variableTemplate; //Field offset: 0x80
	private List _variableElements; //Field offset: 0x88
	private Queue _variableElementsPool; //Field offset: 0x90
	private ISaveStateStorage _variableStorage; //Field offset: 0x98

	public TextGameStatsGroupElement() { }

	private void ClearVariables() { }

	public virtual void Close() { }

	private void CreateVariableElement(StatVariable variable) { }

	public void SetupGroup(StatGroup group, ISaveStateStorage variableValues) { }

}

