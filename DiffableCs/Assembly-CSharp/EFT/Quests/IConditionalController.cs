namespace EFT.Quests;

public interface IConditionalController : IDisposable
{

	public void CheckExitConditionCounters(ExitStatus exitStatus, float pastTime, string locationId, string exitName, HealthEffects effects, List zoneIds) { }

	public void CheckHealthEffectsCounter(HealthEffects effects, string locationId, List zoneIds) { }

	public void CheckKillConditionCounter(string target, string enemyProfileId, List targetEquipment, Item weapon, EBodyPart bodyPart, string locationId, float distance, string role, int hour, HealthEffects enemyEffects, HealthEffects effects, List zoneIds, string[] buffs) { }

	public void CheckShootFlareCounter(string zoneID) { }

	public void CheckShotConditionCounter(string target, string enemyProfileId, List targetEquipment, Item weapon, EBodyPart bodyPart, string locationId, float distance, string role, int hour, HealthEffects enemyEffects, HealthEffects effects, List zoneIds, string[] buffs) { }

	public void CheckTriggerConditionCounter(string target, HealthEffects effects, string locationId) { }

	public void CheckUseItemCounter(string target, float count, string locationId, List zoneIds) { }

	public void Run() { }

}

