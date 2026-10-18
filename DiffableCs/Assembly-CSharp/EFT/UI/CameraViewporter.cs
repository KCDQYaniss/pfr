namespace EFT.UI;

[ExecuteInEditMode]
public sealed class CameraViewporter : MonoBehaviour
{
	[SerializeField]
	private WeaponPreview _weaponPreview; //Field offset: 0x20
	private Canvas _canvas; //Field offset: 0x28
	private RectTransform _rectTransform; //Field offset: 0x30

	public Camera TargetCamera
	{
		 get { } //Length: 27
	}

	public CameraViewporter() { }

	public Camera get_TargetCamera() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void Update() { }

	public Vector2 WorldToLocalScreenPosition(Vector3 worldPosition) { }

}

