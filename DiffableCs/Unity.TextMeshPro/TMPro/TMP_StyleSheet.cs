namespace TMPro;

[ExcludeFromPreset]
public class TMP_StyleSheet : ScriptableObject
{
	[SerializeField]
	private List m_StyleList; //Field offset: 0x18
	private Dictionary m_StyleLookupDictionary; //Field offset: 0x20

	internal List styles
	{
		internal get { } //Length: 5
	}

	public TMP_StyleSheet() { }

	internal List get_styles() { }

	public TMP_Style GetStyle(int hashCode) { }

	public TMP_Style GetStyle(string name) { }

	private void LoadStyleDictionaryInternal() { }

	public void RefreshStyles() { }

	private void Reset() { }

}

