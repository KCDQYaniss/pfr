//Type is in global namespace

public class SightModVisualControllers : MonoBehaviour
{
	private ScopePrefabCache _scopePrefabCache; //Field offset: 0x20
	private ScopeZoomHandler _scopeZoomHandler; //Field offset: 0x28
	private SightComponent _sightMod; //Field offset: 0x30

	public SightComponent SightMod
	{
		 get { } //Length: 76
		 set { } //Length: 94
	}

	public SightModVisualControllers() { }

	private void Awake() { }

	public void ForceChangeScopeState() { }

	public SightComponent get_SightMod() { }

	public void Init() { }

	private void OnEnable() { }

	public void set_SightMod(SightComponent value) { }

	public bool TryGetZoomHandler(out ScopeZoomHandler zoomHandler) { }

	public void UpdateSightMode(bool setupZeroModeAnyway = false) { }

}

