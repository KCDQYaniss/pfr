namespace EFT.Vaulting.Debug;

public class VaultingDebugTool : MonoBehaviour
{
	private VaultingDebugToolView _view; //Field offset: 0x20
	private VaultingDebugToolController _controller; //Field offset: 0x28
	private IVaultingComponentDebug _vautingFacadeDebug; //Field offset: 0x30

	public VaultingDebugTool() { }

	public void Initialize(Player player) { }

	private void InitializeController() { }

	private void InitializeView() { }

	public void OnDestroy() { }

}

