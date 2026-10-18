namespace EFT.UI;

public interface IItemObserverScreen
{

	public void HideModHighlight(bool overriding = false) { }

	public void HighlightMod(Transform modTransform, Color color, bool overriding = false) { }

	public Vector3 ScreenToWorldPoint(Vector3 position) { }

}

