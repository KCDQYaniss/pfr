namespace EFT.Dialogs;

public abstract class DebugWindowBase : UIElement
{
	private const int RESIZE_HANDLE_SIZE = 25; //Field offset: 0x0
	private Rect _windowRect; //Field offset: 0x70
	protected Rect _collapsedRect; //Field offset: 0x80
	private bool _isResizing; //Field offset: 0x90
	private bool _isCollapsed; //Field offset: 0x91
	private bool _isDragging; //Field offset: 0x92
	private Vector2 _resizeStartPosition; //Field offset: 0x94
	private bool _initialized; //Field offset: 0x9C
	protected Vector2 ScrollPosition; //Field offset: 0xA0

	protected override Vector2 CollapsedSize
	{
		 get { } //Length: 25
	}

	protected override Rect DefaultWindowRect
	{
		 get { } //Length: 31
	}

	protected override Vector2 MinWindowSize
	{
		 get { } //Length: 25
	}

	protected abstract string Title
	{
		 get { } //Length: 0
	}

	protected override bool UseScrollView
	{
		 get { } //Length: 3
	}

	protected DebugWindowBase() { }

	private void ClampCollapsedToScreen() { }

	private void ClampWindowToScreen() { }

	protected abstract void DrawBody() { }

	private void DrawCollapsedWindow() { }

	protected override void DrawHeaderLeft() { }

	protected override Vector2 get_CollapsedSize() { }

	protected override Rect get_DefaultWindowRect() { }

	protected override Vector2 get_MinWindowSize() { }

	protected abstract string get_Title() { }

	protected override bool get_UseScrollView() { }

	private void HandleCollapsedDrag() { }

	private void HandleDrag(Rect headerRect) { }

	private void HandleResize() { }

	private void InitIfNeeded() { }

	private void OnGUI() { }

}

