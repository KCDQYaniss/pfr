namespace Vuplex.WebView;

public interface IWithNative2DMode
{

	public bool Native2DModeEnabled
	{
		 get { } //Length: 0
	}

	public Rect Rect
	{
		 get { } //Length: 0
	}

	public bool Visible
	{
		 get { } //Length: 0
	}

	public void BringToFront() { }

	public bool get_Native2DModeEnabled() { }

	public Rect get_Rect() { }

	public bool get_Visible() { }

	public Task InitInNative2DMode(Rect rect) { }

	public void SetNativeZoomEnabled(bool enabled) { }

	public void SetRect(Rect rect) { }

	public void SetVisible(bool visible) { }

}

