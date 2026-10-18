namespace EFT.Hideout;

public sealed class EnergyController : IUpdate, IHideoutStart
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__14_0; //Field offset: 0x8
		public static Func <>9__15_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <AddGenerator>b__14_0(IGenerator registeredGenerator) { }

		internal bool <OnWorkingStateChangedHandler>b__15_0(IGenerator registeredGenerator) { }

	}

	private readonly List _generators; //Field offset: 0x10
	[CompilerGenerated]
	private Action OnEnergyGenerationChanged; //Field offset: 0x18
	private bool _switchedOn; //Field offset: 0x20
	private bool _hasFuel; //Field offset: 0x21
	private bool _isGenerationOn; //Field offset: 0x22
	[CompilerGenerated]
	private bool <IsInfinityGeneration>k__BackingField; //Field offset: 0x23

	public event Action OnEnergyGenerationChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public private bool IsEnergyGenerationOn
	{
		 get { } //Length: 5
		private set { } //Length: 33
	}

	public private bool IsInfinityGeneration
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public EnergyController() { }

	[CompilerGenerated]
	public void add_OnEnergyGenerationChanged(Action value) { }

	public void AddGenerator(IGenerator generator, bool switchedOn) { }

	private void CheckEnergyGeneration(bool hasFuel, bool switchedOn) { }

	public void Dispose() { }

	public bool get_IsEnergyGenerationOn() { }

	[CompilerGenerated]
	public bool get_IsInfinityGeneration() { }

	private void OnWorkingStateChangedHandler(IGenerator generator, bool isWorking) { }

	[CompilerGenerated]
	public void remove_OnEnergyGenerationChanged(Action value) { }

	private void set_IsEnergyGenerationOn(bool value) { }

	[CompilerGenerated]
	private void set_IsInfinityGeneration(bool value) { }

	public void SetInfinityGeneration(bool isInfinity) { }

	public void SetSwitchedStatus(bool isOn) { }

	public override void Start(float profileDecayTime) { }

	public override void Update(float deltaTime) { }

}

