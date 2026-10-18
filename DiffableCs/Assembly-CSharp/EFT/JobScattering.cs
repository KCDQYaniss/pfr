namespace EFT;

public class JobScattering
{
	private int _countFrames; //Field offset: 0x10
	private int _currentFrameCount; //Field offset: 0x14
	private bool _autoUpdate; //Field offset: 0x18
	private int _lastFrameNumber; //Field offset: 0x1C

	public int CountFrames
	{
		 get { } //Length: 164
	}

	public JobScattering(int countFrames, bool autoUpdate = true) { }

	private void AutoFrameTick() { }

	public void FrameTick() { }

	public int get_CountFrames() { }

	public bool HasTimeCome() { }

	public void SetCountFrames(int countFrames) { }

}

