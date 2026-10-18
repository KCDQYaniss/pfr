namespace UnityEngine.UIElements;

internal class StyleMatchingContext
{
	private List m_StyleSheetStack; //Field offset: 0x10
	public StyleVariableContext variableContext; //Field offset: 0x18
	public VisualElement currentElement; //Field offset: 0x20
	public Action processResult; //Field offset: 0x28
	public AncestorFilter ancestorFilter; //Field offset: 0x30

	public int styleSheetCount
	{
		 get { } //Length: 65
	}

	public StyleMatchingContext(Action processResult) { }

	public void AddStyleSheet(StyleSheet sheet) { }

	public int get_styleSheetCount() { }

	public StyleSheet GetStyleSheetAt(int index) { }

	public void RemoveStyleSheetRange(int index, int count) { }

}

