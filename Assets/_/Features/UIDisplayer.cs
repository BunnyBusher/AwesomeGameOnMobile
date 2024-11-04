using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIDisplayer : MonoBehaviour
{
    [SerializeField] private Timer _timer;
    [SerializeField] private TMP_Text _currentChrono;
      

    

    private void Update()
    {
        _currentChrono.text = _timer._currentTime.ToString("F2");
        
    }



}
