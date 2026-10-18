namespace EFT;

[Extension]
public static class ItemFactoryCreateOperation
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_0
	{
		public ItemTemplates itemTemplates; //Field offset: 0x10

		public <>c__DisplayClass0_0() { }

		internal void <CreateItemFactory>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public ItemTemplates itemTemplates; //Field offset: 0x10

		public <>c__DisplayClass2_0() { }

		internal void <CreateItemFactory>b__0() { }

	}

	[CompilerGenerated]
	private struct <CreateItemFactory>d__0 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public IBackendSession backendSession; //Field offset: 0x20
		public ItemFactory itemFactory; //Field offset: 0x28
		private <>c__DisplayClass0_0 <>8__1; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CreateItemFactory>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public IClientBackEnd backendSession; //Field offset: 0x20
		public ItemFactory itemFactory; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CreateItemFactory>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ItemTemplates itemTemplates; //Field offset: 0x20
		private <>c__DisplayClass2_0 <>8__1; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PrepareItemTemplatesForItemFactory>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public IClientBackEnd backendSession; //Field offset: 0x20
		public ItemFactory itemFactory; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static Task _itemFactoryCreationTask; //Field offset: 0x0

	[AsyncStateMachine(typeof(<CreateItemFactory>d__0))]
	[Extension]
	public static Task CreateItemFactory(IBackendSession backendSession, ItemFactory itemFactory = null) { }

	[AsyncStateMachine(typeof(<CreateItemFactory>d__1))]
	[Extension]
	public static Task CreateItemFactory(IClientBackEnd backendSession, ItemFactory itemFactory = null) { }

	[AsyncStateMachine(typeof(<CreateItemFactory>d__2))]
	[Extension]
	public static Task CreateItemFactory(IClientBackEnd backendSession, ItemTemplates itemTemplates) { }

	[Extension]
	public static void FreeItemFactoryCreationTaskLink(IClientBackEnd backendSession) { }

	[Extension]
	public static Task GetItemFactoryCreationTask(IClientBackEnd backendSession, ItemFactory itemFactory = null) { }

	[AsyncStateMachine(typeof(<PrepareItemTemplatesForItemFactory>d__6))]
	[Extension]
	public static Task PrepareItemTemplatesForItemFactory(IClientBackEnd backendSession, ItemFactory itemFactory = null) { }

}

