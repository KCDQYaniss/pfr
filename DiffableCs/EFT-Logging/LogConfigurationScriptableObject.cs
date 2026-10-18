//Type is in global namespace

[CreateAssetMenu]
public class LogConfigurationScriptableObject : ScriptableObject
{
	internal enum ELogLevel
	{
		Trace = 0,
		Debug = 1,
		Information = 2,
		Warning = 3,
		Error = 4,
		Critical = 5,
	}

	[SerializeField]
	private List _rules; //Field offset: 0x18

	public LogConfigurationScriptableObject() { }

}

