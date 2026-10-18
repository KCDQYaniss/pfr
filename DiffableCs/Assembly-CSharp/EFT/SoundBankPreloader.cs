namespace EFT;

public class SoundBankPreloader : MonoBehaviour
{
	[SerializeField]
	private List _soundBanks; //Field offset: 0x20
	[SerializeField]
	private bool _loadOnEnable; //Field offset: 0x28
	[SerializeField]
	private bool _unloadOnDisable; //Field offset: 0x29
	private bool _isLoaded; //Field offset: 0x2A

	public SoundBankPreloader() { }

	private void Awake() { }

	public void LoadData() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnValidate() { }

	public void UnloadData() { }

	private void Validate() { }

}

