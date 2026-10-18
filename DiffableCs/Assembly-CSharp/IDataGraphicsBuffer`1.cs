//Type is in global namespace

public interface IDataGraphicsBuffer`1
{

	public T Data
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public void Close() { }

	public T get_Data() { }

	public NativeArray Open() { }

	public void set_Data(T value) { }

}

