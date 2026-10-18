namespace EFT.UI;

public abstract class UIInputNode : InputNode, IUIElement, IShowable, IUIView, IDisposable
{
	protected readonly UIParent UI; //Field offset: 0x70
	private RectTransform _rectTransform; //Field offset: 0x78

	public override GameObject GameObject
	{
		 get { } //Length: 78
	}

	protected override RectTransform RectTransform
	{
		 get { } //Length: 252
	}

	public override Transform Transform
	{
		 get { } //Length: 78
	}

	protected UIInputNode() { }

	public override void Close() { }

	protected void CorrectPosition(MarginsRect margins = null) { }

	public override void Display() { }

	public override void Dispose() { }

	public override GameObject get_GameObject() { }

	protected override RectTransform get_RectTransform() { }

	public override Transform get_Transform() { }

	public override void HideGameObject() { }

	protected virtual ECursorResult ShouldLockCursor() { }

	public override void ShowGameObject(bool instant = false) { }

	protected virtual void TranslateAxes(ref float[] axes) { }

}

