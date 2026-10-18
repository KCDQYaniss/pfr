namespace EFT.UI;

public sealed class OpenBuildWindow : BaseUiWindow
{
	[SerializeField]
	private DefaultUIButton _openButton; //Field offset: 0x80
	[SerializeField]
	private BuildsCategoriesPanel _categoriesPanel; //Field offset: 0x88
	private WeaponBuildsStorage _buildsStorage; //Field offset: 0x90
	private NodeBaseView _selectedItemPanel; //Field offset: 0x98
	private Action _onBuildSelected; //Field offset: 0xA0
	private string _selectedId; //Field offset: 0xA8

	public OpenBuildWindow() { }

	protected virtual void Awake() { }

	public virtual void Close() { }

	private void OnBuildOpened(NodeBaseView view, string buildId) { }

	private void OnBuildSelected(NodeBaseView view, string buildId) { }

	private void OpenSelectedBuild() { }

	public void Show(RagFair ragfair, Handbook handbook, WeaponBuildsStorage storage, string selectedWeaponTemplateId, Action onBuildSelected) { }

}

