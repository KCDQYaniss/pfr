namespace EFT.CameraControl;

public class ScopeData : MonoBehaviour
{
	public ScopeReticle Reticle; //Field offset: 0x20
	public ScopeNightVisionData NightVisionData; //Field offset: 0x28
	public ScopeThermalVisionData ThermalVisionData; //Field offset: 0x30
	public ScopeEffectsData PostEffectsData; //Field offset: 0x38

	public ScopeData() { }

}

