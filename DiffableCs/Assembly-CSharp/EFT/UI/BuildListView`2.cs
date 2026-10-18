namespace EFT.UI;

public abstract class BuildListView`2 : ButtonFeedback
{
	[SerializeField]
	private TextMeshProUGUI _buildName; //Field offset: 0x0
	[SerializeField]
	private Button _deleteButton; //Field offset: 0x0
	[SerializeField]
	private Button _renameButton; //Field offset: 0x0
	[SerializeField]
	private GameObject _selectedBackground; //Field offset: 0x0
	protected TWrapper BuildWrapper; //Field offset: 0x0

	protected BuildListView`2() { }

	[CompilerGenerated]
	private void <Show>b__6_0() { }

	[UsedImplicitly]
	private void Awake() { }

	private void DeletePreset() { }

	private void EditPreset() { }

	public virtual void OnPointerClick(PointerEventData eventData) { }

	protected virtual void PointerEnterHandler() { }

	protected virtual void PointerExitHandler() { }

	protected override void SetSelectedVisual(bool selected) { }

	protected void Show(TWrapper buildWrapper) { }

}

