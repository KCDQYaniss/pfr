namespace CommonAssets.Scripts.GlobalEventsSystem;

public class ExplosionGlobalLinearShakeEffectEvent : BaseEvent
{
	public CustomExplosionShakeSettings ExplosionShakeSettings; //Field offset: 0x18

	public ExplosionGlobalLinearShakeEffectEvent() { }

	public void Invoke(CustomExplosionShakeSettings explosionShakeSettings) { }

	public virtual void Reset() { }

}

