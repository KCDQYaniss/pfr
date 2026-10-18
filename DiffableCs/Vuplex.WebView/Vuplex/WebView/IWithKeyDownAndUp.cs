namespace Vuplex.WebView;

public interface IWithKeyDownAndUp
{

	public void KeyDown(string key, KeyModifier modifiers) { }

	public void KeyUp(string key, KeyModifier modifiers) { }

}

