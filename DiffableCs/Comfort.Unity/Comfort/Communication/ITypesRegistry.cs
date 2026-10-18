namespace Comfort.Communication;

public interface ITypesRegistry
{

	public Type[] Categories
	{
		 get { } //Length: 0
	}

	public int ProtocolCheckSum
	{
		 get { } //Length: 0
	}

	public int ProtocolCrc
	{
		 get { } //Length: 0
	}

	public Type[] get_Categories() { }

	public int get_ProtocolCheckSum() { }

	public int get_ProtocolCrc() { }

	public Type GetType(long id) { }

	public long Identifier(Type type) { }

}

