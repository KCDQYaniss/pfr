namespace Dissonance.Audio.Playback;

internal static class DecoderPipelinePool
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public FrameFormat format; //Field offset: 0x10
		public Action <>9__1; //Field offset: 0x28

		public <>c__DisplayClass2_0() { }

		internal DecoderPipeline <GetPool>b__0() { }

		internal void <GetPool>b__1(DecoderPipeline p) { }

	}

	private static readonly Dictionary Pools; //Field offset: 0x0
	private static int _nextPipelineId; //Field offset: 0x8

	private static DecoderPipelinePool() { }

	[NotNull]
	internal static DecoderPipeline GetDecoderPipeline(FrameFormat format, IVolumeProvider volume) { }

	[NotNull]
	private static ConcurrentPool GetPool(FrameFormat format) { }

	private static void Recycle(FrameFormat format, DecoderPipeline pipeline) { }

}

