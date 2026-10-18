namespace EFT.UI;

public sealed class ScreenPositionAnchor : MonoBehaviour
{
	private enum EAnchorType
	{
		RelativeByHeight = 0,
		RelativeByWidth = 1,
		Absolute = 2,
	}

	[SerializeField]
	private Camera _camera; //Field offset: 0x20
	[SerializeField]
	private EAnchorType _type; //Field offset: 0x28
	[SerializeField]
	private TextAnchor _alignment; //Field offset: 0x2C
	[SerializeField]
	private Vector2 _position; //Field offset: 0x30
	private int _screenHeight; //Field offset: 0x38
	private int _screenWidth; //Field offset: 0x3C

	public ScreenPositionAnchor() { }

	public void OnEnable() { }

	public void SetCamera(Camera newCam) { }

	public void Update() { }

}

