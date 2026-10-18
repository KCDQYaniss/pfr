namespace EFT;

public class ClientPlayerMovementContext : MovementContext
{

	public virtual bool IsInPronePose
	{
		 set { } //Length: 230
	}

	public ClientPlayerMovementContext() { }

	public virtual void ApplyMotion(Vector3 motion, float deltaTime) { }

	public static ClientPlayerMovementContext Create(Player player, Func characterControllerGetter, LayerMask groundMask) { }

	public void DrawGizmos() { }

	public virtual void set_IsInPronePose(bool value) { }

}

