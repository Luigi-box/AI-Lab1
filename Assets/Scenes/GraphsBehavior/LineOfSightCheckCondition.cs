using System;
using Unity.Behavior;
using UnityEngine;

[Serializable, Unity.Properties.GeneratePropertyBag]
[Condition(name: "Line of Sight check", story: "Check [Target] with [LineOfSightDetector]", category: "Conditions", id: "bbbe893313bacae4156e75d225056ae4")]
public partial class LineOfSightCheckCondition : Condition
{
    [SerializeReference] public BlackboardVariable<GameObject> Target;
    [SerializeReference] public BlackboardVariable<LineOfSightDetector> LineOfSightDetector;

    public override bool IsTrue()
    {
        return LineOfSightDetector.Value.PerformDetection(Target.Value) != null;
    }
}
