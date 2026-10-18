namespace CommonAssets.Scripts.GlobalEventsSystem;

public class TimelineExplosionShakeEffectEvent : BaseEvent
{
	public CustomExplosionShakeSettings ExplosionShakeSettings; //Field offset: 0x18

	public TimelineExplosionShakeEffectEvent() { }

	public void Invoke(CustomExplosionShakeSettings explosionShakeSettings) { }

	public virtual void Reset() { }

}

