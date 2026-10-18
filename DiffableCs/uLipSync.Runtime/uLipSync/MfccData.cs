namespace uLipSync;

public class MfccData
{
	public string name; //Field offset: 0x10
	public List mfccCalibrationDataList; //Field offset: 0x18
	public NativeArray mfccNativeArray; //Field offset: 0x20

	public MfccData(string name) { }

	public void AddCalibrationData(float[] mfcc) { }

	public void Allocate() { }

	public void Deallocate() { }

	protected virtual void Finalize() { }

	public float GetAverage(int i) { }

	private bool IsAllocated() { }

	public void RemoveOldCalibrationData(int dataCount) { }

	public void UpdateNativeArray() { }

}

