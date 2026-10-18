//Type is in global namespace

public class SimpleSparksTest : MonoBehaviour
{
	public SimpleSparksRenderer Renderer; //Field offset: 0x20
	public float Speed; //Field offset: 0x28
	public float Gravity; //Field offset: 0x2C
	[Range(0, 0.9999999)]
	public float Drag; //Field offset: 0x30
	public float Radius; //Field offset: 0x34
	public float LifeTime; //Field offset: 0x38
	[Range(0, 255)]
	public byte Emission; //Field offset: 0x3C
	[Range(0, 255)]
	public byte Size; //Field offset: 0x3D
	[Range(0, 255)]
	public byte TurbulenceAmp; //Field offset: 0x3E
	[Range(0, 255)]
	public byte TurbulenceFreq; //Field offset: 0x3F
	public int Count; //Field offset: 0x40
	public int CountRnd; //Field offset: 0x44
	public bool Check; //Field offset: 0x48
	public bool Once; //Field offset: 0x49

	public SimpleSparksTest() { }

	public void Awake() { }

	private void Update() { }

}

