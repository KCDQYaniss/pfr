namespace UnityEngine.UIElements;

public struct UQueryBuilder`1 : IEquatable
{
	private List m_StyleSelectors; //Field offset: 0x0
	private List m_Parts; //Field offset: 0x0
	private VisualElement m_Element; //Field offset: 0x0
	private List m_Matchers; //Field offset: 0x0
	private StyleSelectorRelationship m_Relationship; //Field offset: 0x0
	private int pseudoStatesMask; //Field offset: 0x0
	private int negatedPseudoStatesMask; //Field offset: 0x0

	private List parts
	{
		private get { } //Length: 191
	}

	private List styleSelectors
	{
		private get { } //Length: 191
	}

	public UQueryBuilder`1(VisualElement visualElement) { }

	private void AddClass(string c) { }

	private void AddName(string id) { }

	private void AddPseudoStatesRuleIfNecessasy() { }

	public UQueryState Build() { }

	public UQueryBuilder Class(string classname) { }

	private bool CurrentSelectorEmpty() { }

	public override bool Equals(UQueryBuilder other) { }

	public virtual bool Equals(object obj) { }

	private void FinishCurrentSelector() { }

	private void FinishSelector() { }

	private List get_parts() { }

	private List get_styleSelectors() { }

	public virtual int GetHashCode() { }

	public UQueryBuilder Name(string id) { }

	internal UQueryBuilder SingleBaseType() { }

}

