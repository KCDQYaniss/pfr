namespace System.Resources;

public class MissingSatelliteAssemblyException : SystemException
{
	private string _cultureName; //Field offset: 0x90

	public MissingSatelliteAssemblyException() { }

	public MissingSatelliteAssemblyException(string message, string cultureName) { }

	protected MissingSatelliteAssemblyException(SerializationInfo info, StreamingContext context) { }

}

