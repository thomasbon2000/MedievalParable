using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data.Runtime
{
    [CreateAssetMenu(fileName = "Dialogue", menuName = "Dialogue")]
    public class DialogueScriptableObject : ScriptableObject
    {
        public AudioClip m_audio;
        public string m_text;
    }
}
