﻿using System.Collections.Generic;
using UnityEngine;

namespace LeoDeg.Framework.Events
{
    [CreateAssetMenu(menuName = "LeoDeg/Events/GameEvent")]
    public class GameEvent : ScriptableObject
    {
        private readonly List<GameEventListener> listeners = new List<GameEventListener>();

        public void Register(GameEventListener listener)
        {
            listeners.Add(listener);
        }

        public void UnRegister(GameEventListener listener)
        {
            listeners.Remove(listener);
        }

        public void Raise()
        {
            for (int i = 0; i < listeners.Count; i++)
            {
                listeners[i].Response();
            }
        }
    }
}
