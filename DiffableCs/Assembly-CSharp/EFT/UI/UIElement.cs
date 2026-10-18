namespace EFT.UI;

public class UIElement : SerializedMonoBehaviour, IUIElement, IShowable, IUIView, IDisposable
{
	protected readonly UIParent UI; //Field offset: 0x60
	private RectTransform _rectTransform; //Field offset: 0x68

	protected CancellationToken CancellationToken
	{
		 get { } //Length: 29
	}

	[CanBeNull]
	public override GameObject GameObject
	{
		 get { } //Length: 495
	}

	protected RectTransform RectTransform
	{
		 get { } //Length: 252
	}

	public override Transform Transform
	{
		 get { } //Length: 78
	}

	public UIElement() { }

	public void AddDisposable(Action action) { }

	public override void Close() { }

	protected override void CorrectPosition(MarginsRect margins = null) { }

	public override void Display() { }

	public override void Dispose() { }

	protected CancellationToken get_CancellationToken() { }

	public override GameObject get_GameObject() { }

	protected RectTransform get_RectTransform() { }

	public override Transform get_Transform() { }

	public void HideGameObject() { }

	public void ShowGameObject() { }

}

