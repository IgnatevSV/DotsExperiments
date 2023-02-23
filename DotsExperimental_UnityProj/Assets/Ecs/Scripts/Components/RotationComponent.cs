using Unity.Entities;

public struct RotationComponent : IComponentData
{
    public float RotationSpeed { get; }

    public RotationComponent(float rotationSpeed)
    {
        RotationSpeed = rotationSpeed;
    }
}
