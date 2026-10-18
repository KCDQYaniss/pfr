//Type is in global namespace

public class BotAISteeringImpostorCharacterController : ImpostorCharacterController
{
	private const float INCREASAE_RAYCAST_DIST = 0.3; //Field offset: 0x0
	private Vector3 _steerDirection; //Field offset: 0x90

	protected virtual float _distanceRaycast
	{
		 get { } //Length: 9
	}

	public virtual bool ShouldStickToGround
	{
		 get { } //Length: 3
	}

	public virtual bool UseAsyncMoveValidation
	{
		 get { } //Length: 3
	}

	public BotAISteeringImpostorCharacterController(bool performMovementValidation, CapsuleCollider collider, Rigidbody rigidbody, IPlayer player, float skinWidth, LayerMask collisionMask) { }

	protected virtual float get__distanceRaycast() { }

	public virtual bool get_ShouldStickToGround() { }

	public virtual bool get_UseAsyncMoveValidation() { }

	public virtual CollisionFlags Move(Vector3 motion, float deltaTime) { }

	public virtual void SetSteerDirection(Vector3 steerDirection) { }

}

