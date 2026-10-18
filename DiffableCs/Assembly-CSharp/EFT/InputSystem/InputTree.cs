namespace EFT.InputSystem;

[RequireComponent(typeof(InputManager))]
public sealed class InputTree : InputNodeAbstract, IInputTree
{
	[CompilerGenerated]
	private InputManager <InputManager>k__BackingField; //Field offset: 0x70

	private InputManager InputManager
	{
		[CompilerGenerated]
		private get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public InputTree() { }

	public override void Add(InputNode node) { }

	public override void AddWithLowPriority(InputNode node) { }

	private void Awake() { }

	public override bool Contains(InputNode node) { }

	[CompilerGenerated]
	private InputManager get_InputManager() { }

	public override void Remove(InputNode node) { }

	[CompilerGenerated]
	private void set_InputManager(InputManager value) { }

}

