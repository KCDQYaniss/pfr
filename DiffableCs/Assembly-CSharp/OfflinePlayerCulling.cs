//Type is in global namespace

public class OfflinePlayerCulling : BasePlayerCulling
{
	private LocalPlayer _player; //Field offset: 0x30

	public OfflinePlayerCulling() { }

	protected virtual void ApplyVisibleState() { }

	public void Initialize(LocalPlayer player, PlayerBones playerBones) { }

}

