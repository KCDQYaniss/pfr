//Type is in global namespace

[ExecuteInEditMode]
public class SwitcherCullingObject : DisablerCullingObject
{
	[Header("Синяя стрелка (ось Z) коллайдеров должна указывать на вход в помещение")]
	[Header("Первая проверка делается по радиусу, дальше по коллайдерам")]
	[SerializeField]
	private float _firstCheckRadius; //Field offset: 0xF8
	private bool _isFirstCheck; //Field offset: 0xFC
	private ColliderReporter _enteredSwitcher; //Field offset: 0x100
	private Vector3 _enterPoint; //Field offset: 0x108
	private bool _hasEntered; //Field offset: 0x114

	public virtual bool HasEntered
	{
		 get { } //Length: 8
	}

	public SwitcherCullingObject() { }

	public virtual bool get_HasEntered() { }

	private Camera GetCamera() { }

	public virtual void ManualUpdate(float dt) { }

	protected virtual void OnSpectatorTriggerStateReset() { }

	protected virtual void OnTriggerEnterEvent(ColliderReporter colliderReporter, Collider collider) { }

	protected virtual void OnTriggerExitEvent(ColliderReporter colliderReporter, Collider collider) { }

	private bool SphereCheck() { }

}

