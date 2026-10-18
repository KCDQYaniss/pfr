namespace EFT;

public class LampVisualScheduler
{
	private TransformAccessArray _transforms; //Field offset: 0x10
	private readonly List _controllers; //Field offset: 0x18
	private JobHandle _handle; //Field offset: 0x20
	private NativeList _indexes; //Field offset: 0x30
	private bool _isDisposed; //Field offset: 0x38

	public int Count
	{
		 get { } //Length: 80
	}

	public bool HasControllers
	{
		 get { } //Length: 69
	}

	public LampVisualScheduler() { }

	public void Add(LampController controller) { }

	public void Complete() { }

	public void Dispose() { }

	public void Execute(in CameraData cameraData) { }

	public int get_Count() { }

	public bool get_HasControllers() { }

	public void Remove(LampController controller) { }

	public void UpdateByIndex(int index, float time, int currentUpdateIndex) { }

}

