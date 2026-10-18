namespace Dissonance;

internal struct FrameSkipDetector
{
	private static readonly string MetricFrameTime; //Field offset: 0x0
	private readonly float _maxFrameTime; //Field offset: 0x0
	private readonly float _minimumBreakerDuration; //Field offset: 0x4
	private readonly float _maxBreakerDuration; //Field offset: 0x8
	private readonly float _breakerResetPerSecond; //Field offset: 0xC
	private float _breakerCloseTimer; //Field offset: 0x10
	private float _currentBreakerDuration; //Field offset: 0x14
	private bool _breakerClosed; //Field offset: 0x18

	internal bool IsBreakerClosed
	{
		internal get { } //Length: 5
	}

	private static FrameSkipDetector() { }

	public FrameSkipDetector(TimeSpan maxFrameTime, TimeSpan minimumBreakerDuration, TimeSpan maxBreakerDuration, TimeSpan breakerResetPerSecond) { }

	internal bool get_IsBreakerClosed() { }

	public bool IsFrameSkip(float deltaTime) { }

	private void UpdateBreaker(bool skip, float dt) { }

}

