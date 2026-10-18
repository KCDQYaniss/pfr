namespace GPUInstancer;

public class MouseLook
{
	public float XSensitivity; //Field offset: 0x10
	public float YSensitivity; //Field offset: 0x14
	public bool clampVerticalRotation; //Field offset: 0x18
	public float MinimumX; //Field offset: 0x1C
	public float MaximumX; //Field offset: 0x20
	public bool smooth; //Field offset: 0x24
	public float smoothTime; //Field offset: 0x28
	public bool lockCursor; //Field offset: 0x2C
	private Quaternion m_CharacterTargetRot; //Field offset: 0x30
	private Quaternion m_CameraTargetRot; //Field offset: 0x40
	private bool m_cursorIsLocked; //Field offset: 0x50

	public MouseLook() { }

	private Quaternion ClampRotationAroundXAxis(Quaternion q) { }

	public void Init(Transform character, Transform camera) { }

	private void InternalLockUpdate() { }

	public void LookRotation(Transform character, Transform camera) { }

	public void SetCursorLock(bool value) { }

	public void UpdateCursorLock() { }

}

