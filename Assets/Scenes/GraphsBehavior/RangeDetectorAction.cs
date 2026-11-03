using System;
using Unity.Behavior;
using UnityEngine;
using Action = Unity.Behavior.Action;
using Unity.Properties;

[Serializable, GeneratePropertyBag]
[NodeDescription(name: "Range Detector", story: "Update [RangeDetectorScript] and assign [Target]", category: "Action", id: "95923da71c6e1faad3b14f64bbe6a4c5")]
public partial class RangeDetectorAction : Action
{
    [SerializeReference] public BlackboardVariable<RangeDetector> RangeDetectorScript;
    [SerializeReference] public BlackboardVariable<GameObject> Target;

    protected override Status OnUpdate()
    {
        Target.Value = RangeDetectorScript.Value.UpdateDetector();
        return Target.Value == null? Status.Failure : Status.Success;
    }
}

