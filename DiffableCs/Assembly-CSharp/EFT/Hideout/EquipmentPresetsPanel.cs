namespace EFT.Hideout;

public sealed class EquipmentPresetsPanel : UIElement
{
	[SerializeField]
	private MannequinVisualSwitcher _mannequinVisualSwitcherTemplate; //Field offset: 0x70
	[SerializeField]
	private Transform _root; //Field offset: 0x78
	private HideoutAreaStashController _stashController; //Field offset: 0x80
	private IEftSession _session; //Field offset: 0x88
	private Dictionary _selectedMannequinPoses; //Field offset: 0x90

	public EquipmentPresetsPanel() { }

	public virtual void Close() { }

	private void OnPantsChanged(Item equipment, CustomizationSuite suite) { }

	private void OnPoseChanged(Item equipment, CustomizationHideoutMannequinPose pose) { }

	public void Show(Inventory inventory, HideoutAreaStashController stashController, IEftSession session) { }

}

