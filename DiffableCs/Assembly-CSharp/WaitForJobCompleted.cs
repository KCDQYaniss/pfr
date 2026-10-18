//Type is in global namespace

public sealed class WaitForJobCompleted : CustomYieldInstruction
{
	private readonly bool _isUsingTempJobAllocator; //Field offset: 0x10
	private readonly int _forceJobCompletionFrameCount; //Field offset: 0x14
	private JobHandle _jobHandle; //Field offset: 0x18

	public virtual bool keepWaiting
	{
		 get { } //Length: 167
	}

	public WaitForJobCompleted(JobHandle jobHandle, bool isUsingTempJobAllocator = true) { }

	public virtual bool get_keepWaiting() { }

}

