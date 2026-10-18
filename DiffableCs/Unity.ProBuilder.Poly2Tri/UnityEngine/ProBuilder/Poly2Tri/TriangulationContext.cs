namespace UnityEngine.ProBuilder.Poly2Tri;

internal abstract class TriangulationContext
{
	[CompilerGenerated]
	private TriangulationDebugContext <DebugContext>k__BackingField; //Field offset: 0x10
	public readonly List Triangles; //Field offset: 0x18
	public readonly List Points; //Field offset: 0x20
	[CompilerGenerated]
	private TriangulationMode <TriangulationMode>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private Triangulatable <Triangulatable>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private int <StepCount>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private bool <IsDebugEnabled>k__BackingField; //Field offset: 0x3C

	public abstract TriangulationAlgorithm Algorithm
	{
		 get { } //Length: 0
	}

	public TriangulationDebugContext DebugContext
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public DTSweepDebugContext DTDebugContext
	{
		 get { } //Length: 119
	}

	public override bool IsDebugEnabled
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public private int StepCount
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private Triangulatable Triangulatable
	{
		[CompilerGenerated]
		 get { } //Length: 76
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public TriangulationMode TriangulationMode
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	protected TriangulationContext() { }

	public override void Clear() { }

	public void Done() { }

	public abstract TriangulationAlgorithm get_Algorithm() { }

	[CompilerGenerated]
	public TriangulationDebugContext get_DebugContext() { }

	public DTSweepDebugContext get_DTDebugContext() { }

	[CompilerGenerated]
	public override bool get_IsDebugEnabled() { }

	[CompilerGenerated]
	public int get_StepCount() { }

	[CompilerGenerated]
	public Triangulatable get_Triangulatable() { }

	[CompilerGenerated]
	public TriangulationMode get_TriangulationMode() { }

	public abstract TriangulationConstraint NewConstraint(TriangulationPoint a, TriangulationPoint b) { }

	public override void PrepareTriangulation(Triangulatable t) { }

	[CompilerGenerated]
	protected void set_DebugContext(TriangulationDebugContext value) { }

	[CompilerGenerated]
	protected override void set_IsDebugEnabled(bool value) { }

	[CompilerGenerated]
	private void set_StepCount(int value) { }

	[CompilerGenerated]
	private void set_Triangulatable(Triangulatable value) { }

	[CompilerGenerated]
	protected void set_TriangulationMode(TriangulationMode value) { }

	public void Update(string message) { }

}

