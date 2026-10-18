namespace EFT;

public class UpdateEftStatusEvent : BaseEvent
{
	public EEftStatus Status; //Field offset: 0x18
	public IReadOnlyDictionary AdditionalData; //Field offset: 0x20

	public UpdateEftStatusEvent() { }

	public void Invoke(EEftStatus status, IReadOnlyDictionary data = null) { }

	private bool IsSame(EEftStatus status, IReadOnlyDictionary data) { }

	public bool IsSame(UpdateEftStatusEvent other) { }

	public virtual void Reset() { }

}

