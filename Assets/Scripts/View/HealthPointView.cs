using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UniRx;

namespace VContainerSandbox
{
    public class HealthPointView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _hpText;
        [SerializeField] private Slider _hpSlider;
        [SerializeField] private Button _damageButton;
        [SerializeField] private Button _healButton;

        public IObservable<Unit> OnClickDamageButton() => _damageButton.OnClickAsObservable();
        public IObservable<Unit> OnClickHealButton() => _healButton.OnClickAsObservable();

        public void SetHP(int hp)
        {
            _hpText.text = hp.ToString();
            _hpSlider.value = hp;
        }
    }
}