namespace EFT.Interactive;

public class VisualOnlyFlare : MonoBehaviour
{
	private const float TIME_TO_END_FLARE = 3; //Field offset: 0x0
	private FlareCartridgeSettings _settings; //Field offset: 0x20
	private Rigidbody _rigidbody; //Field offset: 0x28
	private GameObject _projectileAmmo; //Field offset: 0x30
	private GameObject _flareEffectPrefab; //Field offset: 0x38
	private float _startTime; //Field offset: 0x40
	private float _startHeight; //Field offset: 0x44
	private bool _flareStarted; //Field offset: 0x48
	private bool _flareStopped; //Field offset: 0x49

	public VisualOnlyFlare() { }

	public void Init(FlareCartridgeSettings settings) { }

	public void Launch() { }

	private void StartFlare() { }

	private void Update() { }

}

