//Type is in global namespace

public class CutsceneActionCameraToOriginalRoot : CutsceneBaseAction
{
	[CompilerGenerated]
	private static class <>O
	{
		public static Action <0>__OnPlayerCameraControllerCreated; //Field offset: 0x0

	}

	private static PlayerCameraController _playerCameraController; //Field offset: 0x0
	public string toOriginalActionId; //Field offset: 0x40
	public CutsceneActionCameraToTimelineRoot cameraToTimelineAction; //Field offset: 0x48

	public CutsceneActionCameraToOriginalRoot() { }

	public virtual void Init() { }

	private static void Initialize() { }

	private static void OnPlayerCameraControllerCreated(PlayerCameraController playerCameraController, Camera camera) { }

	public virtual void OnStart() { }

}

