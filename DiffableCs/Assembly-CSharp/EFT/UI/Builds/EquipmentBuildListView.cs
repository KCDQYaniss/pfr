namespace EFT.UI.Builds;

[UsedImplicitly]
public sealed class EquipmentBuildListView : BuildListView
{
	[SerializeField]
	private HealthParameterPanel _weight; //Field offset: 0xD0
	[SerializeField]
	private GameObject _mannequinStorageIcon; //Field offset: 0xD8

	public EquipmentBuildListView() { }

	public void Show(BuildWrapper buildWrapper, Nullable weightParameters) { }

}

