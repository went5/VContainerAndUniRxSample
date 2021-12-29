using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

namespace VContainerSandbox
{
    public class HealthPoint : IHealthPoint
    {
        public IReadOnlyReactiveProperty<int> HpRP => _hpRP;
        private ReactiveProperty<int> _hpRP;
        public const int MINHP = 0;
        public const int MAXHP = 100;

        public void Damage(int damageNum)
        {
            var hp = _hpRP.Value - damageNum;
            hp = Mathf.Clamp(hp, MINHP, MAXHP);
            _hpRP.Value = hp;
        }

        public void Heal(int healNum)
        {
            var hp = _hpRP.Value + healNum;
            hp = Mathf.Clamp(hp, MINHP, MAXHP);
            _hpRP.Value = hp;
        }

        public HealthPoint(int hp)
        {
            hp = Mathf.Clamp(hp, MINHP, MAXHP);
            _hpRP = new ReactiveProperty<int>(hp);
        }
    }
}