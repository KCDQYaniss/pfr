namespace CommonAssets.Scripts.Cutscenes;

public class CutsceneActionDynamicCameraSettingsByReference : CutsceneBaseAction
{
	[SerializeField]
	private CutsceneCameraReference _referenceCamera; //Field offset: 0x40
	[SerializeField]
	private bool _setSettingsOn; //Field offset: 0x48

	public CutsceneActionDynamicCameraSettingsByReference() { }

	public virtual void Deinit() { }

	public virtual void Init() { }

	private void SetCameraSettings() { }

	private void Update() { }

}

