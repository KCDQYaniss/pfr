namespace CommonAssets.Scripts.Cutscenes;

public class CutsceneActionDisableHeadEffects : CutsceneBaseAction
{
	private bool _needEnableNightVision; //Field offset: 0x40
	private bool _needEnableThermalVision; //Field offset: 0x41
	private bool _needEnableVisorEffect; //Field offset: 0x42
	private bool _needEnableFaceCoverMask; //Field offset: 0x43

	public CutsceneActionDisableHeadEffects() { }

	public virtual void Deinit() { }

	private void DisableHeadEffects() { }

	private void EnableHeadEffects() { }

	public virtual void Init() { }

	private FaceShieldComponent ItemGetFaceShield(Item item) { }

	private bool PlayerHasFaceMask() { }

	private bool PlayerHasFaceShields(out FaceShieldComponent faceShieldComponent) { }

	private bool PlayerHasNightVision(out NightVision nightVisionComponent) { }

	private bool PlayerHasThermalVision(out ThermalVision thermalVisionComponent) { }

}

