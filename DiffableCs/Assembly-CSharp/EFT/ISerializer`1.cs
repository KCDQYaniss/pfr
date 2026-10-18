namespace EFT;

public interface ISerializer`1
{

	public T Deserialize() { }

	public object Serialize(T t) { }

}

