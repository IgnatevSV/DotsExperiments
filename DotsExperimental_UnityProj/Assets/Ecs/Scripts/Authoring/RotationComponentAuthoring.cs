using Unity.Entities;
using UnityEngine;

public class RotationComponentAuthoring : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;
    
    private class RotationComponentBaker : Baker<RotationComponentAuthoring>
    {
        public override void Bake(RotationComponentAuthoring authoring)
        {
            AddComponent(new RotationComponent(authoring._rotationSpeed));
        }
    }
}
