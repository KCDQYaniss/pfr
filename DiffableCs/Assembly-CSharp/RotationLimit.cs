//Type is in global namespace

public class RotationLimit : MonoBehaviour
{
	public float initialXRotation; //Field offset: 0x20
	public float initialYRotation; //Field offset: 0x24
	public float initialZRotation; //Field offset: 0x28
	public float maxXRotation; //Field offset: 0x2C
	public float maxYRotation; //Field offset: 0x30
	public float maxZRotation; //Field offset: 0x34
	public float minXRotation; //Field offset: 0x38
	public float minYRotation; //Field offset: 0x3C
	public float minZRotation; //Field offset: 0x40

	public RotationLimit() { }

	private float ClampAngle(float angle, float min, float max) { }

	private void OnValidate() { }

	public void UpdateRotation() { }

}

