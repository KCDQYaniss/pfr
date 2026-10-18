namespace FastAnimatorSystem;

[Extension]
public static class AnimatorStatesManager
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison <>9__4_0; //Field offset: 0x8
		public static Comparison <>9__8_0; //Field offset: 0x10
		public static Comparison <>9__11_0; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal int <AddStateMachine>b__4_0(AbstractInnerStateMachine m1, AbstractInnerStateMachine m2) { }

		internal int <SortStates>b__8_0(AbstractAnimatorControllerState s1, AbstractAnimatorControllerState s2) { }

		internal int <SortTransitions>b__11_0(AnimatorControllerTransition t1, AnimatorControllerTransition t2) { }

	}


	[Extension]
	public static void AddBehavior(AbstractState abstractState, FastStateBehavior behavior) { }

	[Extension]
	public static void AddLayer(FastAnimatorController controllerData, LayerStateMachine layerStateMachine) { }

	[Extension]
	public static void AddParameter(FastAnimatorController controllerData, AnimatorParameter parameter) { }

	[Extension]
	public static void AddState(AbstractInnerStateMachine stateMachine, AbstractAnimatorControllerState state) { }

	[Extension]
	public static void AddStateMachine(AbstractInnerStateMachine parentInnerStateMachine, StateMachine childInnerStateMachine) { }

	[Extension]
	public static void AddTransition(AbstractAnimatorControllerState stateMachine, AnimatorControllerTransition transition) { }

	private static bool CyclesCheck(AbstractInnerStateMachine parent, StateMachine child) { }

	[Extension]
	public static void RemoveLayer(FastAnimatorController controllerData, LayerStateMachine layerStateMachine) { }

	[Extension]
	public static void RemoveParameter(FastAnimatorController controllerData, AnimatorParameter parameter) { }

	[Extension]
	public static void RemoveState(AbstractInnerStateMachine stateMachine, AbstractAnimatorControllerState state) { }

	[Extension]
	public static void RemoveStateMachine(AbstractInnerStateMachine innerStateMachine, StateMachine layerStateMachine) { }

	[Extension]
	public static void RemoveTransition(AbstractAnimatorControllerState stateMachine, AnimatorControllerTransition transition) { }

	[Extension]
	public static void SortStates(AbstractInnerStateMachine stateMachine) { }

	[Extension]
	public static void SortTransitions(AbstractAnimatorControllerState stateMachine) { }

}

