//Type is in global namespace

public class LauncherViauslController : MonoBehaviour
{
	public const string LAUNCHER_SIGHT = "_sight"; //Field offset: 0x0
	public const string LAUNCHER_SIGHT_MODE = "LauncherSight"; //Field offset: 0x0
	private Transform _sight; //Field offset: 0x20
	private readonly List _sightTransforms; //Field offset: 0x28
	public Launcher Launcher; //Field offset: 0x30

	public LauncherViauslController() { }

	private void Awake() { }

	public void Init() { }

	private void OnEnable() { }

	public void UpdateSightMode() { }

}

