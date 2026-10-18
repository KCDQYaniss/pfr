namespace EFT.UI.Builds;

[UsedImplicitly]
public sealed class MagPresetView : BuildListView
{
	[SerializeField]
	private TMP_Text _caliberField; //Field offset: 0xD0

	public MagPresetView() { }

	protected virtual void SetSelectedVisual(bool selected) { }

	public void Show(BuildWrapper presetWrapper) { }

}

