namespace Unity.Collections;

[BurstCompile]
internal struct AutoFreeAllocator : IAllocator, IDisposable
{
	[CompilerGenerated]
	private static class <>O
	{
		public static TryFunction <0>__Try; //Field offset: 0x0

	}

	public static class Try_000000E3$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static Try_000000E3$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static int Invoke(IntPtr state, ref Block block) { }

	}

	internal sealed class Try_000000E3$PostfixBurstDelegate : MulticastDelegate
	{

		public Try_000000E3$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(IntPtr state, ref Block block, AsyncCallback unnamed_param_2, object unnamed_param_3) { }

		public override int EndInvoke(IAsyncResult unnamed_param_0) { }

		public override int Invoke(IntPtr state, ref Block block) { }

	}

	private ArrayOfArrays m_allocated; //Field offset: 0x0
	private ArrayOfArrays m_tofree; //Field offset: 0x20
	private AllocatorHandle m_handle; //Field offset: 0x40
	private AllocatorHandle m_backingAllocatorHandle; //Field offset: 0x44

	public override TryFunction Function
	{
		 get { } //Length: 254
	}

	public override AllocatorHandle Handle
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public override bool IsAutoDispose
	{
		 get { } //Length: 3
	}

	public override bool IsCustomAllocator
	{
		 get { } //Length: 9
	}

	public override Allocator ToAllocator
	{
		 get { } //Length: 14
	}

	public override void Dispose() { }

	public void FreeAll() { }

	public override TryFunction get_Function() { }

	public override AllocatorHandle get_Handle() { }

	public override bool get_IsAutoDispose() { }

	public override bool get_IsCustomAllocator() { }

	public override Allocator get_ToAllocator() { }

	public void Initialize(AllocatorHandle backingAllocatorHandle) { }

	public override void set_Handle(AllocatorHandle value) { }

	public override int Try(ref Block block) { }

	[BurstCompile]
	[MonoPInvokeCallback(typeof(TryFunction))]
	internal static int Try(IntPtr state, ref Block block) { }

	[BurstCompile]
	[MonoPInvokeCallback(typeof(TryFunction))]
	public static int Try$BurstManaged(IntPtr state, ref Block block) { }

	public void Update() { }

}

