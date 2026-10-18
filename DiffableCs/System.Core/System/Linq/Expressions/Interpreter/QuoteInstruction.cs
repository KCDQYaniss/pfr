namespace System.Linq.Expressions.Interpreter;

internal sealed class QuoteInstruction : Instruction
{
	private sealed class ExpressionQuoter : ExpressionVisitor
	{
		private readonly Dictionary _variables; //Field offset: 0x10
		private readonly InterpretedFrame _frame; //Field offset: 0x18
		private readonly Stack _shadowedVars; //Field offset: 0x20

		internal ExpressionQuoter(Dictionary hoistedVariables, InterpretedFrame frame) { }

		private IStrongBox GetBox(ParameterExpression variable) { }

		protected private virtual Expression VisitBlock(BlockExpression node) { }

		protected virtual CatchBlock VisitCatchBlock(CatchBlock node) { }

		protected private virtual Expression VisitLambda(Expression node) { }

		protected private virtual Expression VisitParameter(ParameterExpression node) { }

	}

	private readonly Expression _operand; //Field offset: 0x10
	private readonly Dictionary _hoistedVariables; //Field offset: 0x18

	public virtual string InstructionName
	{
		 get { } //Length: 49
	}

	public virtual int ProducedStack
	{
		 get { } //Length: 6
	}

	public QuoteInstruction(Expression operand, Dictionary hoistedVariables) { }

	public virtual string get_InstructionName() { }

	public virtual int get_ProducedStack() { }

	public virtual int Run(InterpretedFrame frame) { }

}

