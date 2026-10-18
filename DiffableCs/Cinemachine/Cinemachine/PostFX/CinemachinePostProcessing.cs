namespace Cinemachine.PostFX;

[AddComponentMenu(null)]
[SaveDuringPlay]
public class CinemachinePostProcessing : CinemachineExtension
{

	public CinemachinePostProcessing() { }

	protected virtual void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, Stage stage, ref CameraState state, float deltaTime) { }

}

