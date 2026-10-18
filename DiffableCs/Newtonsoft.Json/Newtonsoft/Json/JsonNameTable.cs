namespace Newtonsoft.Json;

public abstract class JsonNameTable
{

	protected JsonNameTable() { }

	[NullableContext(1)]
	public abstract string Get(char[] key, int start, int length) { }

}

