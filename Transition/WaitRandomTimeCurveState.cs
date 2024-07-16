﻿using Arbor;
using UnityEngine;

namespace MornArbor
{
    public class WaitRandomTimeCurveState : StateBehaviour
    {
        [SerializeField] private AnimationCurve _curve;
        [SerializeField] private StateLink _next;
        private float _transitionTime;

        public override void OnStateBegin()
        {
            _transitionTime = Time.time +_curve.Evaluate(Random.value);
        }

        public override void OnStateUpdate()
        {
            if (Time.time >= _transitionTime) Transition(_next);
        }
    }
}