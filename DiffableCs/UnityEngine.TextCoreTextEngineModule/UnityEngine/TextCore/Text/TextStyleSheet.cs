namespace UnityEngine.TextCore.Text;

[ExcludeFromObjectFactory]
[ExcludeFromPreset]
public class TextStyleSheet : ScriptableObject
{
	[SerializeField]
	private List m_StyleList; //Field offset: 0x18
	private Dictionary m_StyleLookupDictionary; //Field offset: 0x20

	internal List styles
	{
		internal get { } //Length: 7
	}

	public TextStyleSheet() { }

	internal List get_styles() { }

	public TextStyle GetStyle(int hashCode) { }

	public TextStyle GetStyle(string name) { }

	private void LoadStyleDictionaryInternal() { }

	public void RefreshStyles() { }

	private void Reset() { }

}

