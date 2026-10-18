namespace uLipSync;

[DefaultMember("Item")]
public struct MfccCalibrationData
{
	public float[] array; //Field offset: 0x0

	public float Item
	{
		 get { } //Length: 44
	}

	public int length
	{
		 get { } //Length: 25
	}

	public float get_Item(int i) { }

	public int get_length() { }

}

