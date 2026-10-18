namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767))]
[Conditional("UNITY_EDITOR")]
[DontApplyToListElements]
[EditorBrowsable(EditorBrowsableState::Never (1))]
[Obsolete("Use [DisableIn(PrefabKind.PrefabInstance)] instead.", False)]
public class DisableInPrefabInstancesAttribute : Attribute
{

	public DisableInPrefabInstancesAttribute() { }

}

