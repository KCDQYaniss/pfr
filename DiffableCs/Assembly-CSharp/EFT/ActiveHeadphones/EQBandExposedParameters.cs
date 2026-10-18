namespace EFT.ActiveHeadphones;

public class EQBandExposedParameters
{
	public string gainParameter; //Field offset: 0x10
	public string frequencyParameter; //Field offset: 0x18
	public string QParameter; //Field offset: 0x20

	public EQBandExposedParameters(string gainParameter, string frequencyParameter, string qParameter) { }

}

