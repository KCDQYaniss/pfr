namespace Audio.AmbientSubsystem;

public abstract class EventSoundContentChangerAbstract : MonoBehaviour, IEventSoundContentChanger
{

	protected EventSoundContentChangerAbstract() { }

	public abstract void ChangeSoundContent(EEventType eventType) { }

}

