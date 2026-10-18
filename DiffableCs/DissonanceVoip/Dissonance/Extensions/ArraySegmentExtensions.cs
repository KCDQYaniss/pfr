namespace Dissonance.Extensions;

[Extension]
public static class ArraySegmentExtensions
{
	public struct DisposableHandle : IDisposable
	{
		private readonly IntPtr _ptr; //Field offset: 0x0
		private GCHandle _handle; //Field offset: 0x8

		public IntPtr Ptr
		{
			 get { } //Length: 101
		}

		internal DisposableHandle(IntPtr ptr, GCHandle handle) { }

		public override void Dispose() { }

		public IntPtr get_Ptr() { }

	}


	[Extension]
	internal static void Clear(ArraySegment segment) { }

	[Extension]
	internal static int CopyFrom(ArraySegment destination, T[] source) { }

	[Extension]
	public static ArraySegment CopyToSegment(ArraySegment source, T[] destination, int destinationOffset = 0) { }

	[Extension]
	internal static DisposableHandle Pin(ArraySegment segment) { }

	[Extension]
	[NotNull]
	internal static T[] ToArray(ArraySegment segment) { }

}

