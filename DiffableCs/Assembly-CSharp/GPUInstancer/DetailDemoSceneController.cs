namespace GPUInstancer;

public class DetailDemoSceneController : MonoBehaviour
{
	private enum CameraModes
	{
		FPMode = 0,
		SpaceshipMode = 1,
		MowerMode = 2,
	}

	private enum QualityMode
	{
		Low = 0,
		Mid = 1,
		High = 2,
	}

	public GameObject fpController; //Field offset: 0x20
	public GameObject spaceshipCamera; //Field offset: 0x28
	public GameObject grassMowerCamera; //Field offset: 0x30
	public GPUInstancerDetailManager detailManager; //Field offset: 0x38
	public bool persistRemoval; //Field offset: 0x40
	private GameObject _uiCanvas; //Field offset: 0x48
	private GameObject _spaceShipControlsText; //Field offset: 0x50
	private GameObject _grassMowerControlsText; //Field offset: 0x58
	private GameObject _loadingTerrainDetailsText; //Field offset: 0x60
	private Text _currentQualityModeText; //Field offset: 0x68
	private Transform _spaceShip; //Field offset: 0x70
	private Transform _grassMower; //Field offset: 0x78
	private GameObject _activeCameraGO; //Field offset: 0x80
	private CameraModes _currentCameraMode; //Field offset: 0x88
	private ParticleSystem _spaceShipThrusterGlow; //Field offset: 0x90
	private QualityMode _currentQualityMode; //Field offset: 0x98
	private List detailMapData; //Field offset: 0xA0

	public DetailDemoSceneController() { }

	private void Awake() { }

	private void DisableLoadingTerrainDetailsText() { }

	private void SetCameraMode(CameraModes cameraMode) { }

	private void SetPrototypesByQuality(QualityMode qualityMode) { }

	private void SetQualityMode(QualityMode qualityMode) { }

	private void SwitchCameraMode() { }

	private void Update() { }

}

