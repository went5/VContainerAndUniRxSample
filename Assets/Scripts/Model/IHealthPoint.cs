using UniRx;

namespace VContainerSandbox
{
    public interface IHealthPoint
    {
        void Damage(int damageNum);
        void Heal(int healNum);
        IReadOnlyReactiveProperty<int> HpRP { get; }
    }
}