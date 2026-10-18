namespace System.Linq.Expressions;

internal class ScopeExpression : BlockExpression
{
	private IReadOnlyList _variables; //Field offset: 0x10

	protected IReadOnlyList VariablesList
	{
		 get { } //Length: 5
	}

	internal ScopeExpression(IReadOnlyList variables) { }

	protected IReadOnlyList get_VariablesList() { }

	internal virtual ReadOnlyCollection GetOrMakeVariables() { }

	internal IReadOnlyList ReuseOrValidateVariables(ReadOnlyCollection variables) { }

}

