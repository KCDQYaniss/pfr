//Type is in global namespace

public class BadValueLogTracker`1 : IDisposable
{
	private AbstractLogger _logger; //Field offset: 0x0
	private string _logType; //Field offset: 0x0
	private string _logTypeValue; //Field offset: 0x0
	private T _badValue; //Field offset: 0x0
	private int _count; //Field offset: 0x0
	private float _startTime; //Field offset: 0x0
	private T _maxBadValue; //Field offset: 0x0

	public BadValueLogTracker`1(AbstractLogger logger, string logType, string logTypeValue, T badValue) { }

	public void Check(T value) { }

	public override void Dispose() { }

	private void Reset() { }

	private void TryToPrintLog() { }

}

