//Type is in global namespace

[AddComponentMenu("Time of Day/Camera Main Script")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class TOD_Camera : MonoBehaviour
{
	public TOD_Sky sky; //Field offset: 0x20
	public bool DomePosToCamera; //Field offset: 0x28
	public Vector3 DomePosOffset; //Field offset: 0x2C
	public bool DomeScaleToFarClip; //Field offset: 0x38
	public float DomeScaleFactor; //Field offset: 0x3C
	private Camera cameraComponent; //Field offset: 0x40
	private Transform cameraTransform; //Field offset: 0x48

	public bool HDR
	{
		 get { } //Length: 293
	}

	public TOD_Camera() { }

	public void DoDomePosToCamera() { }

	public void DoDomeScaleToFarClip() { }

	public bool get_HDR() { }

	protected void OnEnable() { }

	protected void OnPreCull() { }

	protected void OnValidate() { }

	protected void Update() { }

}

