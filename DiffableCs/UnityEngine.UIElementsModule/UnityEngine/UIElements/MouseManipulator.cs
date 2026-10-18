namespace UnityEngine.UIElements;

public abstract class MouseManipulator : Manipulator
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private List <activators>k__BackingField; //Field offset: 0x18
	private ManipulatorActivationFilter m_currentActivator; //Field offset: 0x20

	public private List activators
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected MouseManipulator() { }

	protected bool CanStartManipulation(IMouseEvent e) { }

	protected bool CanStopManipulation(IMouseEvent e) { }

	[CompilerGenerated]
	public List get_activators() { }

	[CompilerGenerated]
	private void set_activators(List value) { }

}

