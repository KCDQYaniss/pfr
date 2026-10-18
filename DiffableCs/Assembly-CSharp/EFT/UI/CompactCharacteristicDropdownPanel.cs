namespace EFT.UI;

public class CompactCharacteristicDropdownPanel : CompactCharacteristicPanel
{
	[SerializeField]
	private GameObject _dropdownImage; //Field offset: 0xF0
	private string _availableList; //Field offset: 0xF8
	private MultiLineInfo _multiLineInfo; //Field offset: 0x100

	public CompactCharacteristicDropdownPanel() { }

	[CompilerGenerated]
	private void <Awake>b__3_0(PointerEventData arg) { }

	[CompilerGenerated]
	private void <Awake>b__3_1(PointerEventData arg) { }

	protected virtual void Awake() { }

	private void HideTooltip() { }

	protected virtual void OnDisable() { }

	public virtual void SetValues() { }

	private void ShowTooltip() { }

}

