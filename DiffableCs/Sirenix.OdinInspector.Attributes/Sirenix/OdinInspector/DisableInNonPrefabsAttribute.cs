namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767))]
[Conditional("UNITY_EDITOR")]
[DontApplyToListElements]
[EditorBrowsable(EditorBrowsableState::Never (1))]
[Obsolete("Use [DisableIn(PrefabKind.NonPrefabInstance)] instead.", False)]
public class DisableInNonPrefabsAttribute : Attribute
{

	public DisableInNonPrefabsAttribute() { }

}

