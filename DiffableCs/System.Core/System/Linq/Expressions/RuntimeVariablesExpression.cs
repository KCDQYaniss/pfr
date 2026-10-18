namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(RuntimeVariablesExpressionProxy))]
public sealed class RuntimeVariablesExpression : Expression
{
	[CompilerGenerated]
	private readonly ReadOnlyCollection <Variables>k__BackingField; //Field offset: 0x10

	public ReadOnlyCollection Variables
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	[CompilerGenerated]
	public ReadOnlyCollection get_Variables() { }

}

