namespace EFT.CameraControl;

public class ScopeReticle : MonoBehaviour
{
	public Mesh Mesh; //Field offset: 0x20
	public Material Material; //Field offset: 0x28
	public Vector3 Position; //Field offset: 0x30
	public Vector3 Rotation; //Field offset: 0x3C
	public float Scale; //Field offset: 0x48

	public ScopeReticle() { }

}

