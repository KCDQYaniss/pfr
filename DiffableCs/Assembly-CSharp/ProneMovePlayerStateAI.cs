//Type is in global namespace

public class ProneMovePlayerStateAI : ProneMovePlayerState
{

	public ProneMovePlayerStateAI(MovementContext movementContext) { }

	protected virtual void LimitMotion(ref Vector3 motion, float deltaTime) { }

	public virtual void Rotate(Vector2 deltaRotation, bool ignoreClamp = false) { }

}

