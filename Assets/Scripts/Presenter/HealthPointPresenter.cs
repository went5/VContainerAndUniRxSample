using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VContainer.Unity;
using VContainerSandbox;
using UniRx;
using UniRx.Triggers;

namespace VContainerSandbox
{
    public class HealthPointPresenter : IInitializable
    {
        private readonly IHealthPoint _healthPoint;
        private readonly HealthPointView _healthPointView;

        public HealthPointPresenter(IHealthPoint healthPoint, HealthPointView healthPointView)
        {
            _healthPoint = healthPoint;
            _healthPointView = healthPointView;
        }
        public void Initialize()
        {
            _healthPoint.HpRP.Subscribe(hp => _healthPointView.SetHP(hp));
            // ボタンに処理を登録する
            _healthPointView.OnClickDamageButton().Subscribe(_ => _healthPoint.Damage(10));
            _healthPointView.OnClickHealButton().Subscribe(_ => _healthPoint.Heal(10));
        }
    }
}