//Type is in global namespace

[Extension]
public static class Extensions
{
	private struct CommandBufferComparer : IComparer
	{
		public static readonly IComparer Interface; //Field offset: 0x0

		private static CommandBufferComparer() { }

		[BurstDiscard]
		public override int Compare(CommandBuffer a, CommandBuffer b) { }

		private static int GetIndex(ReadOnlySpan name) { }

	}


	[Extension]
	public static void SetKeyword(Material mat, string key, bool enable) { }

	[Extension]
	public static void SortCommandBuffers(Camera cam, CameraEvent evn) { }

}

