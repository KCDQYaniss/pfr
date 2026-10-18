namespace Vuplex.WebView;

public interface IWithPointerDownAndUp
{

	public void PointerDown(Vector2 normalizedPoint) { }

	public void PointerDown(Vector2 normalizedPoint, PointerOptions options) { }

	public void PointerUp(Vector2 normalizedPoint) { }

	public void PointerUp(Vector2 normalizedPoint, PointerOptions options) { }

}

