using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class HealthBar : MonoBehaviour
{
    [SerializeField] private float _timeToDrain=0.2f;
    [SerializeField] private Gradient _healthBarGradient;
    private float _target=1f;
    private int _healthMax;
    private Image fill;
    private Coroutine drainHealthBarCoroutine;
    private Color _newHealthBarColor;

    private void Start()
    {
        fill=GetComponent<Image>();
        fill.color=_healthBarGradient.Evaluate(_target);
        CheckHealthBarGradient();
    }
    public void UpdateHealthBar(float maxHealth, float currentHealth)
    {
        _target=currentHealth/maxHealth;
        drainHealthBarCoroutine=StartCoroutine(DrainHealthBar());
        CheckHealthBarGradient();
    }
    private IEnumerator DrainHealthBar()
    {
        float _fillAmount=fill.fillAmount;
        float elapsedTime=0f; 
        Color curColor=fill.color;

        while(elapsedTime<_timeToDrain)
        {
            elapsedTime+=Time.deltaTime;
            // lerp (smoooth) fill amount and color based on gradient
            fill.fillAmount=Mathf.Lerp(_fillAmount, _target, (elapsedTime/_timeToDrain));
            fill.color=Color.Lerp(curColor,_newHealthBarColor, (elapsedTime/_timeToDrain));

            yield return null;
        }
    }
    private void CheckHealthBarGradient()
    {
        _newHealthBarColor=_healthBarGradient.Evaluate(_target);
    }
}

