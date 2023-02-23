using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

public partial class RotationSystem : SystemBase
{
    protected override void OnUpdate()
    {
        var rotationAngle = SystemAPI.Time.DeltaTime * math.PI;
        
        foreach ((TransformAspect transformAspect, RotationComponent rotationComponent)
                 in SystemAPI.Query<TransformAspect, RotationComponent>())
        {
            transformAspect.RotateWorld(quaternion.RotateY(rotationAngle * rotationComponent.RotationSpeed));
        }
    }
}
