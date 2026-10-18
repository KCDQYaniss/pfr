namespace EFT;

public class JobsScattering
{
	private int _countPerFrame; //Field offset: 0x10
	private List _queueOrder; //Field offset: 0x18
	private Dictionary _queueIndexes; //Field offset: 0x20
	private int _currentStartIndex; //Field offset: 0x28
	private bool _autoUpdate; //Field offset: 0x2C
	private int _lastFrameNumber; //Field offset: 0x30

	public int CountPerFrame
	{
		 get { } //Length: 164
	}

	public JobsScattering(int countPerFrame, int objectsCount = 0, bool autoUpdate = true) { }

	private void AutoFrameTick() { }

	public void FrameTick() { }

	public int get_CountPerFrame() { }

	private bool IsMyTurn(int id) { }

	public bool IsMyTurn(object someObject) { }

	private void Register(int id) { }

	public void Register(object someObject) { }

	public void SetCountPerFrame(int countPerFrame) { }

	private void Unregister(int id) { }

	public void Unregister(object someObject) { }

	private void UpdateQueueIndexes() { }

}

