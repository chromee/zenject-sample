using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Sample.Scripts
{
    public sealed class SampleMonoBehavior : MonoBehaviour
    {
        [SerializeField] private Text _boolText;
        [SerializeField] private Text _floatText;
        
        [Inject] private readonly SampleA _sampleA;
        [Inject] private readonly SampleB _sampleB;

        private void Start()
        {
            _boolText.text = $"SampleA Flag is {_sampleA.Flag}.";
            _floatText.text = $"SampleB Val is {_sampleB.Val}.";
        }
    }
}