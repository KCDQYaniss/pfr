namespace EFT.UI;

public sealed class TextGameStatsVariableElement : UIElement
{
	[SerializeField]
	private TextMeshProUGUI _displayText; //Field offset: 0x70
	private StatVariable _currentVariable; //Field offset: 0x78
	private ISaveStateStorage _currentVariableValues; //Field offset: 0x80

	public TextGameStatsVariableElement() { }

	public void SetupVariable(StatVariable variable, ISaveStateStorage saveStorage) { }

	public void UpdateDisplay() { }

}

