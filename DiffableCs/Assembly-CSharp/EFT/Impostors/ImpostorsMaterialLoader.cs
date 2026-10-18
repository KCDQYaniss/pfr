namespace EFT.Impostors;

internal sealed class ImpostorsMaterialLoader : IDisposable
{
	private abstract class State : IDisposable
	{
		[CompilerGenerated]
		private struct <LoadMaterial>d__22 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public Func materialFactory; //Field offset: 0x20
			public State <>4__this; //Field offset: 0x28
			private Task <task>5__2; //Field offset: 0x30
			private TaskAwaiter <>u__1; //Field offset: 0x38

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		private ImpostorsMaterialLoader _loader; //Field offset: 0x10
		private Material _material; //Field offset: 0x18
		private Texture2DArray _array0; //Field offset: 0x20
		private Texture2DArray _array1; //Field offset: 0x28
		private Token _token; //Field offset: 0x30
		[CompilerGenerated]
		private Task <MaterialTask>k__BackingField; //Field offset: 0x38

		protected AmplifyImpostorsArray ImpostorsArray
		{
			 get { } //Length: 27
		}

		protected bool IsValid
		{
			 get { } //Length: 22
		}

		public Material Material
		{
			 get { } //Length: 5
			 set { } //Length: 140
		}

		protected Task MaterialTask
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 82
		}

		protected State(ImpostorsMaterialLoader loader) { }

		public override void Dispose() { }

		public override void GenerateMaterialQualityHigh(bool updated, int[] ids) { }

		public override void GenerateMaterialQualityLow(bool updated) { }

		public override void GenerateMaterialQualityMedium(bool updated) { }

		protected AmplifyImpostorsArray get_ImpostorsArray() { }

		protected bool get_IsValid() { }

		public Material get_Material() { }

		[CompilerGenerated]
		protected Task get_MaterialTask() { }

		[AsyncStateMachine(typeof(<LoadMaterial>d__22))]
		private Task LoadMaterial(Func materialFactory) { }

		protected void set_Material(Material value) { }

		[CompilerGenerated]
		protected void set_MaterialTask(Task value) { }

		private static void TryDestroy(ref Material material, ref Texture2DArray array0, ref Texture2DArray array1, ref Token token) { }

		protected void TryLoadMaterial(Func materialFactory) { }

	}

	private sealed class StateQualityHigh : State
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass1_0
		{
			public StateQualityHigh <>4__this; //Field offset: 0x10
			public int[] ids; //Field offset: 0x18

			public <>c__DisplayClass1_0() { }

			internal Task <GenerateMaterialQualityHigh>b__0() { }

		}


		internal StateQualityHigh(ImpostorsMaterialLoader loader) { }

		public virtual void GenerateMaterialQualityHigh(bool updated, int[] ids) { }

	}

	private sealed class StateQualityLow : State
	{

		internal StateQualityLow(ImpostorsMaterialLoader loader) { }

		public virtual void GenerateMaterialQualityLow(bool updated) { }

	}

	private sealed class StateQualityMedium : State
	{

		internal StateQualityMedium(ImpostorsMaterialLoader loader) { }

		public virtual void GenerateMaterialQualityLow(bool updated) { }

		public virtual void GenerateMaterialQualityMedium(bool updated) { }

	}

	private State _state; //Field offset: 0x10
	private AmplifyImpostorsArray _impostorsArray; //Field offset: 0x18
	[CompilerGenerated]
	private AmplifyImpostorsArray <ImpostorsArray>k__BackingField; //Field offset: 0x20

	public AmplifyImpostorsArray ImpostorsArray
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public Material Material
	{
		 get { } //Length: 15
	}

	public ImpostorsMaterialLoader() { }

	public override void Dispose() { }

	public void GenerateMaterialQualityHigh(bool updated, int[] ids) { }

	public void GenerateMaterialQualityLow(bool updated) { }

	public void GenerateMaterialQualityMedium(bool updated) { }

	[CompilerGenerated]
	public AmplifyImpostorsArray get_ImpostorsArray() { }

	public Material get_Material() { }

	[CompilerGenerated]
	public void set_ImpostorsArray(AmplifyImpostorsArray value) { }

	private void SetState(State state) { }

}

