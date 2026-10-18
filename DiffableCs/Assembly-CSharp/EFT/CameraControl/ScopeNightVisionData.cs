namespace EFT.CameraControl;

public class ScopeNightVisionData : MonoBehaviour
{
	public bool NightVision; //Field offset: 0x20
	public float Intensity; //Field offset: 0x24
	public float MaskSize; //Field offset: 0x28
	public float NoiseIntensity; //Field offset: 0x2C
	public float NoiseScale; //Field offset: 0x30
	public Color Color; //Field offset: 0x34

	public ScopeNightVisionData() { }

}

