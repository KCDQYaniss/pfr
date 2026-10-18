//Type is in global namespace

public interface IPhysicsTriggerWithStay : IPhysicsTrigger
{

	public void OnTriggerStayCustom(Collider enteredCollider, Collider triggerCollider) { }

}

