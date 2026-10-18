//Type is in global namespace

public class CutsceneActionCameraToTimelineRoot : CutsceneBaseAction
{
	[CompilerGenerated]
	private static class <>O
	{
		public static Action <0>__OnPlayerCameraControllerCreated; //Field offset: 0x0

	}

	public static List CutsceneActionCameraToTimelineRoots; //Field offset: 0x0
	private static PlayerCameraController _playerCameraController; //Field offset: 0x8
	public string targetRootName; //Field offset: 0x40
	[HideInInspector]
	public Scene originalScene; //Field offset: 0x48
	[HideInInspector]
	public Transform originalParent; //Field offset: 0x50
	private Transform _rootObject; //Field offset: 0x58

	private static CutsceneActionCameraToTimelineRoot() { }

	public CutsceneActionCameraToTimelineRoot() { }

	private void Awake() { }

	public virtual void Init() { }

	private static void Initialize() { }

	private void OnDestroy() { }

	private static void OnPlayerCameraControllerCreated(PlayerCameraController playerCameraController, Camera camera) { }

	public virtual void OnStart() { }

}

