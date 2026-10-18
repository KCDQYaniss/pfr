namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(MemberInitExpressionProxy))]
public sealed class MemberInitExpression : Expression
{
	[CompilerGenerated]
	private readonly NewExpression <NewExpression>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly ReadOnlyCollection <Bindings>k__BackingField; //Field offset: 0x18

	public ReadOnlyCollection Bindings
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public NewExpression NewExpression
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	[CompilerGenerated]
	public ReadOnlyCollection get_Bindings() { }

	[CompilerGenerated]
	public NewExpression get_NewExpression() { }

}

