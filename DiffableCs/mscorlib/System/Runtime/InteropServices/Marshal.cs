namespace System.Runtime.InteropServices;

public static class Marshal
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__201_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal Dictionary <GetCustomMarshalerInstance>b__201_0() { }

	}

	public class MarshalerInstanceKeyComparer : IEqualityComparer
	{

		public MarshalerInstanceKeyComparer() { }

		public override bool Equals(ValueTuple lhs, ValueTuple rhs) { }

		public override int GetHashCode(ValueTuple key) { }

	}

	public sealed class SecureStringAllocator : MulticastDelegate
	{

		public SecureStringAllocator(object object, IntPtr method) { }

		public override IntPtr Invoke(int len) { }

	}

	public static readonly int SystemMaxDBCSCharSize; //Field offset: 0x0
	public static readonly int SystemDefaultCharSize; //Field offset: 0x4
	internal static Dictionary MarshalerInstanceCache; //Field offset: 0x8
	internal static readonly object MarshalerInstanceCacheLock; //Field offset: 0x10

	private static Marshal() { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	public static IntPtr AllocHGlobal(IntPtr cb) { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	public static IntPtr AllocHGlobal(int cb) { }

	private static IntPtr BufferToBSTR(char* ptr, int slen) { }

	private static void ClearBSTR(IntPtr ptr) { }

	private static void ClearUnicode(IntPtr ptr) { }

	public static void Copy(byte[] source, int startIndex, IntPtr destination, int length) { }

	public static void Copy(short[] source, int startIndex, IntPtr destination, int length) { }

	public static void Copy(int[] source, int startIndex, IntPtr destination, int length) { }

	public static void Copy(IntPtr[] source, int startIndex, IntPtr destination, int length) { }

	public static void Copy(IntPtr source, byte[] destination, int startIndex, int length) { }

	public static void Copy(IntPtr source, char[] destination, int startIndex, int length) { }

	public static void Copy(IntPtr source, int[] destination, int startIndex, int length) { }

	public static void Copy(IntPtr source, float[] destination, int startIndex, int length) { }

	public static void Copy(IntPtr source, IntPtr[] destination, int startIndex, int length) { }

	internal static void copy_from_unmanaged(IntPtr source, int startIndex, Array destination, int length) { }

	private static void copy_from_unmanaged_fixed(IntPtr source, int startIndex, Array destination, int length, void* fixed_destination_element) { }

	internal static void copy_to_unmanaged(Array source, int startIndex, IntPtr destination, int length) { }

	internal static void copy_to_unmanaged(byte[] source, int startIndex, IntPtr destination, int length) { }

	private static void copy_to_unmanaged_fixed(Array source, int startIndex, IntPtr destination, int length, void* fixed_source_element) { }

	public static void FreeBSTR(IntPtr ptr) { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static void FreeHGlobal(IntPtr hglobal) { }

	internal static ICustomMarshaler GetCustomMarshalerInstance(Type type, string cookie) { }

	public static Delegate GetDelegateForFunctionPointer(IntPtr ptr, Type t) { }

	public static TDelegate GetDelegateForFunctionPointer(IntPtr ptr) { }

	private static Delegate GetDelegateForFunctionPointerInternal(IntPtr ptr, Type t) { }

	public static IntPtr GetFunctionPointerForDelegate(Delegate d) { }

	public static IntPtr GetFunctionPointerForDelegate(TDelegate d) { }

	private static IntPtr GetFunctionPointerForDelegateInternal(Delegate d) { }

	public static int GetHRForException(Exception e) { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static int GetLastWin32Error() { }

	public static bool IsComObject(object o) { }

	public static IntPtr OffsetOf(Type t, string fieldName) { }

	public static string PtrToStringAnsi(IntPtr ptr) { }

	public static string PtrToStringAnsi(IntPtr ptr, int len) { }

	public static string PtrToStringBSTR(IntPtr ptr) { }

	public static string PtrToStringUni(IntPtr ptr) { }

	[ComVisible(True)]
	public static object PtrToStructure(IntPtr ptr, Type structureType) { }

	public static T PtrToStructure(IntPtr ptr) { }

	public static byte ReadByte(IntPtr ptr, int ofs) { }

	public static short ReadInt16(IntPtr ptr, int ofs) { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static int ReadInt32(IntPtr ptr) { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static int ReadInt32(IntPtr ptr, int ofs) { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static long ReadInt64(IntPtr ptr) { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static IntPtr ReadIntPtr(IntPtr ptr) { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static int Release(IntPtr pUnk) { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	private static int ReleaseInternal(IntPtr pUnk) { }

	internal static IntPtr SecureStringGlobalAllocator(int len) { }

	public static IntPtr SecureStringToBSTR(SecureString s) { }

	public static IntPtr SecureStringToGlobalAllocUnicode(SecureString s) { }

	internal static IntPtr SecureStringToUnicode(SecureString s, SecureStringAllocator allocator) { }

	public static int SizeOf(Type t) { }

	public static int SizeOf() { }

	public static int SizeOf(T structure) { }

	private static bool skip_fixed(Array array, int startIndex) { }

	public static IntPtr StringToHGlobalAnsi(string s) { }

	private static IntPtr StringToHGlobalAnsi(char* s, int length) { }

	private static IntPtr StringToHGlobalUni(char* s, int length) { }

	public static IntPtr StringToHGlobalUni(string s) { }

	[ComVisible(True)]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	public static void StructureToPtr(object structure, IntPtr ptr, bool fDeleteOld) { }

	public static void StructureToPtr(T structure, IntPtr ptr, bool fDeleteOld) { }

	public static IntPtr UnsafeAddrOfPinnedArrayElement(Array arr, int index) { }

	public static IntPtr UnsafeAddrOfPinnedArrayElement(T[] arr, int index) { }

	public static void WriteByte(IntPtr ptr, int ofs, byte val) { }

	public static void WriteInt16(IntPtr ptr, int ofs, short val) { }

	public static void WriteInt32(IntPtr ptr, int val) { }

	public static void WriteInt64(IntPtr ptr, long val) { }

	public static void WriteIntPtr(IntPtr ptr, IntPtr val) { }

	public static void ZeroFreeBSTR(IntPtr s) { }

	public static void ZeroFreeGlobalAllocUnicode(IntPtr s) { }

}

