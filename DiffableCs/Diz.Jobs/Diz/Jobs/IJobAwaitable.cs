namespace Diz.Jobs;

public interface IJobAwaitable
{

	public IJobAwaiter GetAwaiter() { }

}

