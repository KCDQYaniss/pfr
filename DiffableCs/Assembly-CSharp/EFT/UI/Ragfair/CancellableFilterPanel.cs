namespace EFT.UI.Ragfair;

public sealed class CancellableFilterPanel : UIElement
{
	[SerializeField]
	private TextMeshProUGUI _filterNameLabel; //Field offset: 0x70
	[SerializeField]
	private Button _cancelButton; //Field offset: 0x78
	private RagFair _ragFair; //Field offset: 0x80
	private CancellableFilter _filter; //Field offset: 0x88
	private CancellableFilters _filters; //Field offset: 0x90

	public CancellableFilterPanel() { }

	[CompilerGenerated]
	private void <Awake>b__5_0() { }

	private void Awake() { }

	public void Show(RagFair ragFair, CancellableFilter filter) { }

}

