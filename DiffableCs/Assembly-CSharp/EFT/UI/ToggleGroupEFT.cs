namespace EFT.UI;

[ExecuteInEditMode]
[UsedImplicitly]
public sealed class ToggleGroupEFT : MonoBehaviour
{
	[SerializeField]
	[UsedImplicitly(ImplicitUseKindFlags::Assign (2))]
	private bool _allowAllOff; //Field offset: 0x20
	private readonly HashSet _toggles; //Field offset: 0x28

	public ToggleGroupEFT() { }

	public void Register(ToggleEFT newToggle) { }

	public bool TrySwitchState(ToggleEFT fromToggle, bool toOnState) { }

	public void Unregister(ToggleEFT toggle) { }

}

