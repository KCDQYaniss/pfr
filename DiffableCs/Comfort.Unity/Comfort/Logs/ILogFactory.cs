namespace Comfort.Logs;

public interface ILogFactory
{

	public ILog CreateLog(Type type) { }

	public ILog CreateLog(string name) { }

}

