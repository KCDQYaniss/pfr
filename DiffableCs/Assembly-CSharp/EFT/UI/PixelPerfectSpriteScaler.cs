namespace EFT.UI;

[DisallowMultipleComponent]
[RequireComponent(typeof(RectTransform))]
public sealed class PixelPerfectSpriteScaler : UIBehaviour
{
	[Flags]
	private enum EScaleSide
	{
		Top = 1,
		Left = 2,
		Bottom = 4,
		Right = 8,
		All = 15,
	}

	[SerializeField]
	private EScaleSide _sidesToScale; //Field offset: 0x20
	private Image _image; //Field offset: 0x28
	private RectTransform _rectTransform; //Field offset: 0x30
	private Vector2 _defaultOffsetMin; //Field offset: 0x38
	private Vector2 _defaultOffsetMax; //Field offset: 0x40

	public PixelPerfectSpriteScaler() { }

	protected virtual void Awake() { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	private void ScreenSizeUpdateHandler() { }

	private void UpdateScale() { }

}

