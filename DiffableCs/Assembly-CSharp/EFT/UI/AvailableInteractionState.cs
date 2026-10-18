namespace EFT.UI;

public class AvailableInteractionState
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__4_0; //Field offset: 0x8
		public static Func <>9__6_0; //Field offset: 0x10
		public static Func <>9__7_0; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal bool <InitSelected>b__4_0(InteractionAction x) { }

		internal bool <SelectNextAction>b__6_0(InteractionAction x) { }

		internal bool <SelectPreviousAction>b__7_0(InteractionAction x) { }

	}

	public List Actions; //Field offset: 0x10
	public InteractionAction SelectedAction; //Field offset: 0x18
	public string Error; //Field offset: 0x20
	public BindableEvent CurrentActionChanged; //Field offset: 0x28

	public AvailableInteractionState() { }

	public void DefaultSelected() { }

	public void InitSelected() { }

	public void SelectAction(InteractionAction action) { }

	public void SelectNextAction() { }

	public void SelectPreviousAction() { }

}

