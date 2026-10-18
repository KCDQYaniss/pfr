namespace System.Linq.Expressions.Interpreter;

[DebuggerTypeProxy(typeof(DebugView))]
[IsReadOnly]
internal struct InstructionArray
{
	public sealed class DebugView
	{
		private readonly InstructionArray _array; //Field offset: 0x10

		public DebugView(InstructionArray array) { }

		[CompilerGenerated]
		private int <GetInstructionViews>b__4_0(int index) { }

		public InstructionView[] GetInstructionViews(bool includeDebugCookies = false) { }

	}

	internal readonly int MaxStackDepth; //Field offset: 0x0
	internal readonly int MaxContinuationDepth; //Field offset: 0x4
	internal readonly Instruction[] Instructions; //Field offset: 0x8
	internal readonly object[] Objects; //Field offset: 0x10
	internal readonly RuntimeLabel[] Labels; //Field offset: 0x18
	internal readonly List DebugCookies; //Field offset: 0x20

	internal InstructionArray(int maxStackDepth, int maxContinuationDepth, Instruction[] instructions, object[] objects, RuntimeLabel[] labels, List debugCookies) { }

}

