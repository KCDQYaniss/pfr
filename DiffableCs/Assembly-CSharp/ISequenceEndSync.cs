//Type is in global namespace

public interface ISequenceEndSync
{

	public void ReportSequenceBusyUntil(double dspEndTime, AudioEventType eventType) { }

	public void ReportSequenceEnd(double dspEndTime, AudioEventType eventType) { }

}

