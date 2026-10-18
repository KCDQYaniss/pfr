namespace Dissonance.Audio.Playback;

internal struct DesyncCalculator
{
	private const int MaxAllowedDesyncMillis = 1000; //Field offset: 0x0
	private const float MaximumPlaybackAdjustment = 0.15; //Field offset: 0x0
	[CompilerGenerated]
	private int <DesyncMilliseconds>k__BackingField; //Field offset: 0x0

	internal float CorrectedPlaybackSpeed
	{
		internal get { } //Length: 87
	}

	internal int DesyncMilliseconds
	{
		[CompilerGenerated]
		[IsReadOnly]
		internal get { } //Length: 3
		[CompilerGenerated]
		private set { } //Length: 3
	}

	private static float CalculateCorrectionFactor(float desyncMilliseconds) { }

	private static int CalculateDesync(TimeSpan idealPlaybackPosition, TimeSpan actualPlaybackPosition) { }

	internal float get_CorrectedPlaybackSpeed() { }

	[CompilerGenerated]
	[IsReadOnly]
	internal int get_DesyncMilliseconds() { }

	[CompilerGenerated]
	private void set_DesyncMilliseconds(int value) { }

	internal void Skip(int deltaDesyncMilliseconds) { }

	internal void Update(TimeSpan ideal, TimeSpan actual) { }

}

