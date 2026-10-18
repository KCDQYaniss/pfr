namespace UnityEngine.UIElements.StyleSheets;

internal class StylePropertyValueMatcher : BaseStyleMatcher
{
	private List m_Values; //Field offset: 0x20

	private StylePropertyValue current
	{
		private get { } //Length: 178
	}

	public virtual bool isCurrentComma
	{
		 get { } //Length: 176
	}

	public virtual bool isCurrentVariable
	{
		 get { } //Length: 3
	}

	public virtual int valueCount
	{
		 get { } //Length: 65
	}

	public StylePropertyValueMatcher() { }

	private StylePropertyValue get_current() { }

	public virtual bool get_isCurrentComma() { }

	public virtual bool get_isCurrentVariable() { }

	public virtual int get_valueCount() { }

	public MatchResult Match(Expression exp, List values) { }

	protected virtual bool MatchAngle() { }

	protected virtual bool MatchColor() { }

	protected virtual bool MatchCustomIdent() { }

	protected virtual bool MatchInteger() { }

	protected virtual bool MatchKeyword(string keyword) { }

	protected virtual bool MatchLength() { }

	protected virtual bool MatchNumber() { }

	protected virtual bool MatchPercentage() { }

	protected virtual bool MatchResource() { }

	protected virtual bool MatchTime() { }

	protected virtual bool MatchUrl() { }

}

