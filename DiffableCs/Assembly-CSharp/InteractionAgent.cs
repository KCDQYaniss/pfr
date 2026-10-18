//Type is in global namespace

public class InteractionAgent
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__12_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <.ctor>b__12_0(bool b) { }

	}

	[CompilerGenerated]
	private bool <SomethingClosely>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private Action OnChangeCloseness; //Field offset: 0x18
	private Transform _transform; //Field offset: 0x20
	private int _lastHash; //Field offset: 0x28
	private float _radius; //Field offset: 0x2C
	private IntVec2[] _shifts; //Field offset: 0x30
	private LinkedList _recivers; //Field offset: 0x38

	public event Action OnChangeCloseness
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public private bool SomethingClosely
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public InteractionAgent(Transform transform, float radius) { }

	[CompilerGenerated]
	public void add_OnChangeCloseness(Action value) { }

	[CompilerGenerated]
	public bool get_SomethingClosely() { }

	private IntVec2[] GetShifts(float radius) { }

	[CompilerGenerated]
	public void remove_OnChangeCloseness(Action value) { }

	[CompilerGenerated]
	private void set_SomethingClosely(bool value) { }

	public void Update() { }

}

