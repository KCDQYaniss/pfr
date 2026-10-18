namespace Unity.Collections;

[Extension]
public static class AllocatorManager
{
	private static class AllocatorCache`1
	{
		public static FunctionPointer TryFunction; //Field offset: 0x0
		public static TryFunction CachedFunction; //Field offset: 0x0

	}

	internal struct AllocatorHandle : IAllocator, IDisposable, IEquatable, IComparable
	{
		public ushort Index; //Field offset: 0x0
		public ushort Version; //Field offset: 0x2

		public override TryFunction Function
		{
			 get { } //Length: 3
		}

		public override AllocatorHandle Handle
		{
			 get { } //Length: 3
			 set { } //Length: 3
		}

		public override bool IsAutoDispose
		{
			 get { } //Length: 206
		}

		public override bool IsCustomAllocator
		{
			 get { } //Length: 8
		}

		internal bool IsInstalled
		{
			internal get { } //Length: 206
		}

		internal TableEntry TableEntry
		{
			internal get { } //Length: 195
		}

		public override Allocator ToAllocator
		{
			 get { } //Length: 13
		}

		public int Value
		{
			 get { } //Length: 4
		}

		public Block AllocateBlock(int items) { }

		[Conditional("UNITY_DOTS_DEBUG")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		private static void CheckAllocatedSuccessfully(int error) { }

		public override int CompareTo(AllocatorHandle other) { }

		public override void Dispose() { }

		public bool Equals(Allocator other) { }

		public override bool Equals(AllocatorHandle other) { }

		public virtual bool Equals(object obj) { }

		public override TryFunction get_Function() { }

		public override AllocatorHandle get_Handle() { }

		public override bool get_IsAutoDispose() { }

		public override bool get_IsCustomAllocator() { }

		internal bool get_IsInstalled() { }

		internal TableEntry get_TableEntry() { }

		public override Allocator get_ToAllocator() { }

		public int get_Value() { }

		public virtual int GetHashCode() { }

		internal void IncrementVersion() { }

		internal void Install(TableEntry tableEntry) { }

		public static bool op_Equality(AllocatorHandle lhs, AllocatorHandle rhs) { }

		public static bool op_GreaterThan(AllocatorHandle lhs, AllocatorHandle rhs) { }

		public static bool op_GreaterThanOrEqual(AllocatorHandle lhs, AllocatorHandle rhs) { }

		public static AllocatorHandle op_Implicit(Allocator a) { }

		public static bool op_Inequality(AllocatorHandle lhs, AllocatorHandle rhs) { }

		public static bool op_LessThan(AllocatorHandle lhs, AllocatorHandle rhs) { }

		public static bool op_LessThanOrEqual(AllocatorHandle lhs, AllocatorHandle rhs) { }

		internal void Rewind() { }

		public override void set_Handle(AllocatorHandle value) { }

		public override int Try(ref Block block) { }

		public int TryAllocateBlock(out Block block, int items) { }

	}

	public struct Array16`1
	{
		internal T f0; //Field offset: 0x0
		internal T f1; //Field offset: 0x0
		internal T f2; //Field offset: 0x0
		internal T f3; //Field offset: 0x0
		internal T f4; //Field offset: 0x0
		internal T f5; //Field offset: 0x0
		internal T f6; //Field offset: 0x0
		internal T f7; //Field offset: 0x0
		internal T f8; //Field offset: 0x0
		internal T f9; //Field offset: 0x0
		internal T f10; //Field offset: 0x0
		internal T f11; //Field offset: 0x0
		internal T f12; //Field offset: 0x0
		internal T f13; //Field offset: 0x0
		internal T f14; //Field offset: 0x0
		internal T f15; //Field offset: 0x0

	}

	public struct Array256`1
	{
		internal Array16 f0; //Field offset: 0x0
		internal Array16 f1; //Field offset: 0x0
		internal Array16 f2; //Field offset: 0x0
		internal Array16 f3; //Field offset: 0x0
		internal Array16 f4; //Field offset: 0x0
		internal Array16 f5; //Field offset: 0x0
		internal Array16 f6; //Field offset: 0x0
		internal Array16 f7; //Field offset: 0x0
		internal Array16 f8; //Field offset: 0x0
		internal Array16 f9; //Field offset: 0x0
		internal Array16 f10; //Field offset: 0x0
		internal Array16 f11; //Field offset: 0x0
		internal Array16 f12; //Field offset: 0x0
		internal Array16 f13; //Field offset: 0x0
		internal Array16 f14; //Field offset: 0x0
		internal Array16 f15; //Field offset: 0x0

	}

	public struct Array32768`1 : IIndexable
	{
		internal Array4096 f0; //Field offset: 0x0
		internal Array4096 f1; //Field offset: 0x0
		internal Array4096 f2; //Field offset: 0x0
		internal Array4096 f3; //Field offset: 0x0
		internal Array4096 f4; //Field offset: 0x0
		internal Array4096 f5; //Field offset: 0x0
		internal Array4096 f6; //Field offset: 0x0
		internal Array4096 f7; //Field offset: 0x0

		public override int Length
		{
			 get { } //Length: 6
			 set { } //Length: 3
		}

		public override T ElementAt(int index) { }

		public override int get_Length() { }

		public override void set_Length(int value) { }

	}

	public struct Array4096`1
	{
		internal Array256 f0; //Field offset: 0x0
		internal Array256 f1; //Field offset: 0x0
		internal Array256 f2; //Field offset: 0x0
		internal Array256 f3; //Field offset: 0x0
		internal Array256 f4; //Field offset: 0x0
		internal Array256 f5; //Field offset: 0x0
		internal Array256 f6; //Field offset: 0x0
		internal Array256 f7; //Field offset: 0x0
		internal Array256 f8; //Field offset: 0x0
		internal Array256 f9; //Field offset: 0x0
		internal Array256 f10; //Field offset: 0x0
		internal Array256 f11; //Field offset: 0x0
		internal Array256 f12; //Field offset: 0x0
		internal Array256 f13; //Field offset: 0x0
		internal Array256 f14; //Field offset: 0x0
		internal Array256 f15; //Field offset: 0x0

	}

	internal struct Block : IDisposable
	{
		public Range Range; //Field offset: 0x0
		public int BytesPerItem; //Field offset: 0x10
		public int AllocatedItems; //Field offset: 0x14
		public byte Log2Alignment; //Field offset: 0x18
		public byte Padding0; //Field offset: 0x19
		public ushort Padding1; //Field offset: 0x1A
		public uint Padding2; //Field offset: 0x1C

		public int Alignment
		{
			 get { } //Length: 12
			 set { } //Length: 75
		}

		public long AllocatedBytes
		{
			 get { } //Length: 13
		}

		public long Bytes
		{
			 get { } //Length: 13
		}

		public void Allocate() { }

		[Conditional("UNITY_DOTS_DEBUG")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		private void CheckFailedToAllocate(int error) { }

		[Conditional("UNITY_DOTS_DEBUG")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		private void CheckFailedToFree(int error) { }

		public override void Dispose() { }

		public void Free() { }

		public int get_Alignment() { }

		public long get_AllocatedBytes() { }

		public long get_Bytes() { }

		public void set_Alignment(int value) { }

		public int TryAllocate() { }

		public int TryFree() { }

	}

	internal struct BlockHandle
	{
		public ushort Value; //Field offset: 0x0

	}

	internal interface IAllocator : IDisposable
	{

		public TryFunction Function
		{
			 get { } //Length: 0
		}

		public AllocatorHandle Handle
		{
			 get { } //Length: 0
			 set { } //Length: 0
		}

		public bool IsAutoDispose
		{
			 get { } //Length: 3
		}

		public bool IsCustomAllocator
		{
			 get { } //Length: 0
		}

		public Allocator ToAllocator
		{
			 get { } //Length: 0
		}

		public TryFunction get_Function() { }

		public AllocatorHandle get_Handle() { }

		public bool get_IsAutoDispose() { }

		public bool get_IsCustomAllocator() { }

		public Allocator get_ToAllocator() { }

		public void set_Handle(AllocatorHandle value) { }

		public int Try(ref Block block) { }

	}

	public static class Managed
	{
		internal static TryFunction[] TryFunctionDelegates; //Field offset: 0x0

		private static Managed() { }

		[ExcludeFromBurstCompatTesting("Uses managed delegate")]
		public static void RegisterDelegate(int index, TryFunction function) { }

		[ExcludeFromBurstCompatTesting("Uses managed delegate")]
		public static void UnregisterDelegate(int index) { }

	}

	internal struct Range : IDisposable
	{
		public IntPtr Pointer; //Field offset: 0x0
		public int Items; //Field offset: 0x8
		public AllocatorHandle Allocator; //Field offset: 0xC

		public override void Dispose() { }

	}

	public sealed class SharedStatics
	{
		public sealed class IsAutoDispose
		{
			internal static readonly SharedStatic Ref; //Field offset: 0x0

			private static IsAutoDispose() { }

			public IsAutoDispose() { }

		}

		public sealed class IsInstalled
		{
			internal static readonly SharedStatic Ref; //Field offset: 0x0

			private static IsInstalled() { }

			public IsInstalled() { }

		}

		public sealed class TableEntry
		{
			internal static readonly SharedStatic Ref; //Field offset: 0x0

			private static TableEntry() { }

			public TableEntry() { }

		}


		public SharedStatics() { }

	}

	[BurstCompile]
	public struct SlabAllocator : IAllocator, IDisposable
	{
		[CompilerGenerated]
		private static class <>O
		{
			public static TryFunction <0>__Try; //Field offset: 0x0

		}

		public static class Try_000000B9$BurstDirectCall
		{
			private static IntPtr Pointer; //Field offset: 0x0
			private static IntPtr DeferredCompilation; //Field offset: 0x8

			private static Try_000000B9$BurstDirectCall() { }

			public static void Constructor() { }

			private static IntPtr GetFunctionPointer() { }

			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

			public static void Initialize() { }

			public static int Invoke(IntPtr allocatorState, ref Block block) { }

		}

		internal sealed class Try_000000B9$PostfixBurstDelegate : MulticastDelegate
		{

			public Try_000000B9$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

			public override IAsyncResult BeginInvoke(IntPtr allocatorState, ref Block block, AsyncCallback unnamed_param_2, object unnamed_param_3) { }

			public override int EndInvoke(IAsyncResult unnamed_param_0) { }

			public override int Invoke(IntPtr allocatorState, ref Block block) { }

		}

		internal AllocatorHandle m_handle; //Field offset: 0x0
		internal Block Storage; //Field offset: 0x8
		internal int Log2SlabSizeInBytes; //Field offset: 0x28
		internal FixedList4096Bytes Occupied; //Field offset: 0x30
		internal long budgetInBytes; //Field offset: 0x1030
		internal long allocatedBytes; //Field offset: 0x1038

		public long AllocatedBytes
		{
			 get { } //Length: 8
		}

		public long BudgetInBytes
		{
			 get { } //Length: 8
		}

		public override TryFunction Function
		{
			 get { } //Length: 254
		}

		public override AllocatorHandle Handle
		{
			 get { } //Length: 3
			 set { } //Length: 3
		}

		public override bool IsCustomAllocator
		{
			 get { } //Length: 8
		}

		internal int Slabs
		{
			internal get { } //Length: 19
		}

		internal int SlabSizeInBytes
		{
			internal get { } //Length: 11
			internal set { } //Length: 85
		}

		public override Allocator ToAllocator
		{
			 get { } //Length: 13
		}

		public override void Dispose() { }

		public long get_AllocatedBytes() { }

		public long get_BudgetInBytes() { }

		public override TryFunction get_Function() { }

		public override AllocatorHandle get_Handle() { }

		public override bool get_IsCustomAllocator() { }

		internal int get_Slabs() { }

		internal int get_SlabSizeInBytes() { }

		public override Allocator get_ToAllocator() { }

		internal void Initialize(Block storage, int slabSizeInBytes, long budget) { }

		public override void set_Handle(AllocatorHandle value) { }

		internal void set_SlabSizeInBytes(int value) { }

		public override int Try(ref Block block) { }

		[BurstCompile]
		[MonoPInvokeCallback(typeof(TryFunction))]
		public static int Try(IntPtr allocatorState, ref Block block) { }

		[BurstCompile]
		[MonoPInvokeCallback(typeof(TryFunction))]
		public static int Try$BurstManaged(IntPtr allocatorState, ref Block block) { }

	}

	[BurstCompile]
	public struct StackAllocator : IAllocator, IDisposable
	{
		[CompilerGenerated]
		private static class <>O
		{
			public static TryFunction <0>__Try; //Field offset: 0x0

		}

		public static class Try_000000AB$BurstDirectCall
		{
			private static IntPtr Pointer; //Field offset: 0x0
			private static IntPtr DeferredCompilation; //Field offset: 0x8

			private static Try_000000AB$BurstDirectCall() { }

			public static void Constructor() { }

			private static IntPtr GetFunctionPointer() { }

			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

			public static void Initialize() { }

			public static int Invoke(IntPtr allocatorState, ref Block block) { }

		}

		internal sealed class Try_000000AB$PostfixBurstDelegate : MulticastDelegate
		{

			public Try_000000AB$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

			public override IAsyncResult BeginInvoke(IntPtr allocatorState, ref Block block, AsyncCallback unnamed_param_2, object unnamed_param_3) { }

			public override int EndInvoke(IAsyncResult unnamed_param_0) { }

			public override int Invoke(IntPtr allocatorState, ref Block block) { }

		}

		internal AllocatorHandle m_handle; //Field offset: 0x0
		internal Block m_storage; //Field offset: 0x8
		internal long m_top; //Field offset: 0x28

		public override TryFunction Function
		{
			 get { } //Length: 254
		}

		public override AllocatorHandle Handle
		{
			 get { } //Length: 3
			 set { } //Length: 3
		}

		public override bool IsCustomAllocator
		{
			 get { } //Length: 8
		}

		public override Allocator ToAllocator
		{
			 get { } //Length: 13
		}

		public override void Dispose() { }

		public override TryFunction get_Function() { }

		public override AllocatorHandle get_Handle() { }

		public override bool get_IsCustomAllocator() { }

		public override Allocator get_ToAllocator() { }

		public void Initialize(Block storage) { }

		public override void set_Handle(AllocatorHandle value) { }

		public override int Try(ref Block block) { }

		[BurstCompile]
		[MonoPInvokeCallback(typeof(TryFunction))]
		public static int Try(IntPtr allocatorState, ref Block block) { }

		[BurstCompile]
		[MonoPInvokeCallback(typeof(TryFunction))]
		public static int Try$BurstManaged(IntPtr allocatorState, ref Block block) { }

	}

	public struct TableEntry
	{
		internal IntPtr function; //Field offset: 0x0
		internal IntPtr state; //Field offset: 0x8

	}

	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	internal sealed class TryFunction : MulticastDelegate
	{

		public TryFunction(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(IntPtr allocatorState, ref Block block, AsyncCallback callback, object object) { }

		public override int EndInvoke(ref Block block, IAsyncResult result) { }

		public override int Invoke(IntPtr allocatorState, ref Block block) { }

	}

	public static readonly AllocatorHandle Invalid; //Field offset: 0x0
	public const int kErrorNone = 0; //Field offset: 0x0
	public const int kErrorBufferOverflow = -1; //Field offset: 0x0
	public const ushort FirstUserIndex = 64; //Field offset: 0x0
	public const ushort MaxNumCustomAllocators = 32768; //Field offset: 0x0
	public static readonly AllocatorHandle None; //Field offset: 0x4
	public static readonly AllocatorHandle Temp; //Field offset: 0x8
	public static readonly AllocatorHandle TempJob; //Field offset: 0xC
	public static readonly AllocatorHandle Persistent; //Field offset: 0x10
	public static readonly AllocatorHandle AudioKernel; //Field offset: 0x14
	internal static readonly ushort NumGlobalScratchAllocators; //Field offset: 0x18
	internal static readonly ushort MaxNumGlobalAllocators; //Field offset: 0x1A
	internal static readonly uint GlobalAllocatorBaseIndex; //Field offset: 0x1C
	internal static readonly uint FirstGlobalScratchpadAllocatorIndex; //Field offset: 0x20

	private static AllocatorManager() { }

	[Extension]
	public static void* Allocate(ref T t, int sizeOf, int alignOf, int items = 1) { }

	[Extension]
	internal static U* Allocate(ref T t, U u, int items) { }

	public static void* Allocate(AllocatorHandle handle, int itemSizeInBytes, int alignmentInBytes, int items = 1) { }

	public static T* Allocate(AllocatorHandle handle, int items = 1) { }

	private static int allocate_block(ref Block block) { }

	[Extension]
	internal static Block AllocateBlock(ref T t, int sizeOf, int alignOf, int items) { }

	[Extension]
	internal static Block AllocateBlock(ref T t, U u, int items) { }

	[Extension]
	internal static void* AllocateStruct(ref T t, U u, int items) { }

	[BurstDiscard]
	private static void CheckDelegate(ref bool useDelegate) { }

	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	internal static void CheckFailedToAllocate(int error) { }

	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	internal static void CheckFailedToFree(int error) { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	internal static void CheckValid(AllocatorHandle handle) { }

	public static AllocatorHandle ConvertToAllocatorHandle(Allocator a) { }

	[ExcludeFromBurstCompatTesting("Register uses managed delegate")]
	internal static T CreateAllocator(AllocatorHandle backingAllocator, bool isGlobal = false, int globalIndex = 0) { }

	[ExcludeFromBurstCompatTesting("Registration uses managed delegates")]
	[Extension]
	internal static void DestroyAllocator(ref T t, AllocatorHandle backingAllocator) { }

	[BurstDiscard]
	private static void forward_mono_allocate_block(ref Block block, ref int error) { }

	public static void Free(AllocatorHandle handle, void* pointer, int itemSizeInBytes, int alignmentInBytes, int items = 1) { }

	[Extension]
	internal static void Free(ref T t, U* pointer, int items) { }

	[Extension]
	internal static void Free(ref T t, void* pointer, int sizeOf, int alignOf, int items) { }

	public static void Free(AllocatorHandle handle, T* pointer, int items = 1) { }

	public static void Free(AllocatorHandle handle, void* pointer) { }

	[Extension]
	internal static void FreeBlock(ref T t, ref Block block) { }

	public static void Initialize() { }

	public static void Initialize$SlabAllocator_Try_000000B9$BurstDirectCall() { }

	public static void Initialize$StackAllocator_Try_000000AB$BurstDirectCall() { }

	internal static void Install(AllocatorHandle handle, IntPtr allocatorState, TryFunction function) { }

	internal static void Install(AllocatorHandle handle, IntPtr allocatorState, FunctionPointer functionPointer, TryFunction function, bool IsAutoDispose = false) { }

	internal static bool IsCustomAllocator(AllocatorHandle allocator) { }

	internal static Allocator LegacyOf(AllocatorHandle handle) { }

	[ExcludeFromBurstCompatTesting("Uses managed delegate")]
	[Extension]
	public static void Register(ref T t, bool IsAutoDispose = false, bool isGlobal = false, int globalIndex = 0) { }

	internal static AllocatorHandle Register(IntPtr allocatorState, FunctionPointer functionPointer, bool IsAutoDispose = false, bool isGlobal = false, int globalIndex = 0) { }

	public static void Shutdown() { }

	public static int Try(ref Block block) { }

	private static int TryLegacy(ref Block block) { }

	[Extension]
	public static void UnmanagedUnregister(ref T t) { }

	[ExcludeFromBurstCompatTesting("Uses managed delegate")]
	[Extension]
	public static void Unregister(ref T t) { }

	private static bool UseDelegate() { }

}

