namespace EFT.UI;

public sealed class TextGameStatsPanel : UIElement
{
	private static TextGameStatsData _baseStatsData; //Field offset: 0x0
	[SerializeField]
	private Transform _groupsContainer; //Field offset: 0x70
	[SerializeField]
	private TextGameStatsGroupElement _groupTemplate; //Field offset: 0x78
	private List _groupElements; //Field offset: 0x80
	private Queue _groupElementsPool; //Field offset: 0x88
	private ClientDialogController _dialogController; //Field offset: 0x90
	private readonly Dictionary _lastVariableValues; //Field offset: 0x98
	private Dictionary _currentVariableValues; //Field offset: 0xA0

	public TextGameStatsPanel() { }

	[CompilerGenerated]
	private void <Show>b__8_0() { }

	private void ClearGroups() { }

	private TextGameStatsGroupElement CreateGroupElement(StatGroup group) { }

	private bool HasChanges() { }

	private static void InitializeMockData() { }

	private void InstantiateGroups() { }

	private void OnDialogChanged(BaseTraderDialog dialog) { }

	private void RefreshPanel() { }

	public void Show(ClientDialogController dialogController) { }

}

