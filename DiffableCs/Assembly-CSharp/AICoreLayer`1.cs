//Type is in global namespace

public abstract class AICoreLayer`1
{
	[CompilerGenerated]
	private Action OnEndCurDecision; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnStartCurDecision; //Field offset: 0x0
	[CompilerGenerated]
	private bool <IsActive>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private float <LastChangeDecision>k__BackingField; //Field offset: 0x0

	public event Action OnEndCurDecision
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnStartCurDecision
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public private bool IsActive
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private float LastChangeDecision
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public abstract int Priority
	{
		 get { } //Length: 0
	}

	protected AICoreLayer`1() { }

	public void Activate() { }

	[CompilerGenerated]
	public void add_OnEndCurDecision(Action value) { }

	[CompilerGenerated]
	public void add_OnStartCurDecision(Action value) { }

	protected override void DecisionChanged(Nullable prevDecision, AICoreActionResult nextDecision) { }

	public override void Dispose() { }

	[CompilerGenerated]
	public bool get_IsActive() { }

	[CompilerGenerated]
	public float get_LastChangeDecision() { }

	public abstract int get_Priority() { }

	public override string GetCustomData() { }

	public abstract AICoreActionResult GetDecision() { }

	protected override void ManualUpdate() { }

	public abstract string Name() { }

	protected override void OnActivate() { }

	public override void OnDrawGizmos() { }

	[CompilerGenerated]
	public void remove_OnEndCurDecision(Action value) { }

	[CompilerGenerated]
	public void remove_OnStartCurDecision(Action value) { }

	[CompilerGenerated]
	private void set_IsActive(bool value) { }

	[CompilerGenerated]
	private void set_LastChangeDecision(float value) { }

	public abstract AICoreActionEnd ShallEndCurrentDecision(AICoreActionResult curDecision) { }

	public abstract bool ShallUseNow() { }

	public Nullable Update(Nullable prevDecision) { }

}

