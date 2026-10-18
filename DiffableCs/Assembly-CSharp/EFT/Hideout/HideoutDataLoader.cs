namespace EFT.Hideout;

public sealed class HideoutDataLoader
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		private struct <<Load>g__LoadAreasQte|1>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass6_0 <>4__this; //Field offset: 0x20
			private TaskAwaiter <>u__1; //Field offset: 0x28

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		private struct <<Load>g__LoadAreaTemplates|2>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass6_0 <>4__this; //Field offset: 0x20
			private TaskAwaiter <>u__1; //Field offset: 0x28

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		private struct <<Load>g__LoadCustomizationOffers|3>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass6_0 <>4__this; //Field offset: 0x20
			private TaskAwaiter <>u__1; //Field offset: 0x28

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		private struct <<Load>g__LoadHideoutAreasInfo|5>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass6_0 <>4__this; //Field offset: 0x20
			private TaskAwaiter <>u__1; //Field offset: 0x28

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		private struct <<Load>g__LoadHideoutSettings|0>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass6_0 <>4__this; //Field offset: 0x20
			private TaskAwaiter <>u__1; //Field offset: 0x28

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		private struct <<Load>g__LoadProductionRecipes|4>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass6_0 <>4__this; //Field offset: 0x20
			private TaskAwaiter <>u__1; //Field offset: 0x28

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public IEftSession session; //Field offset: 0x10
		public HideoutDataLoader <>4__this; //Field offset: 0x18

		public <>c__DisplayClass6_0() { }

		[AsyncStateMachine(typeof(<<Load>g__LoadAreasQte|1>d))]
		internal Task <Load>g__LoadAreasQte|1() { }

		[AsyncStateMachine(typeof(<<Load>g__LoadAreaTemplates|2>d))]
		internal Task <Load>g__LoadAreaTemplates|2() { }

		[AsyncStateMachine(typeof(<<Load>g__LoadCustomizationOffers|3>d))]
		internal Task <Load>g__LoadCustomizationOffers|3() { }

		[AsyncStateMachine(typeof(<<Load>g__LoadHideoutAreasInfo|5>d))]
		internal Task <Load>g__LoadHideoutAreasInfo|5() { }

		[AsyncStateMachine(typeof(<<Load>g__LoadHideoutSettings|0>d))]
		internal Task <Load>g__LoadHideoutSettings|0() { }

		[AsyncStateMachine(typeof(<<Load>g__LoadProductionRecipes|4>d))]
		internal Task <Load>g__LoadProductionRecipes|4() { }

	}

	[CompilerGenerated]
	private struct <Load>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public IEftSession session; //Field offset: 0x20
		public HideoutDataLoader <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private HideoutSettings _hideoutSettings; //Field offset: 0x10
	private QteData[] _qteData; //Field offset: 0x18
	private UnparsedData _areaTemplates; //Field offset: 0x20
	private HideoutCustomizationOffersCollection _customizationOffers; //Field offset: 0x28
	private ProductionSchemesCollection _productionRecipes; //Field offset: 0x30
	private HideoutAreasInfo _areaInfo; //Field offset: 0x38

	public HideoutDataLoader() { }

	public HideoutRepresentation Apply(IEftSession session) { }

	private HideoutRepresentation CreateHideoutRepresentation() { }

	[AsyncStateMachine(typeof(<Load>d__6))]
	public Task Load(IEftSession session) { }

}

