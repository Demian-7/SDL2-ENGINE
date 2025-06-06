﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class Time
    {
        private readonly static Time _instance = new Time();

        private static float _deltaTime;
        private static DateTime _startTime;
        private static float _lastFrameTime;

        public static float DeltaTime => _deltaTime;
        public static DateTime StartTime => _startTime;
        public static float LastFrameTime => _lastFrameTime;

        private Time()
        {
            Init();
        }


        public static void Init()
        {
            _startTime = DateTime.Now;
        }
        public static void UpdateTime()
        {
            var currentTime = (float)(DateTime.Now - _startTime).TotalSeconds;
            _deltaTime = currentTime - _lastFrameTime;
            _lastFrameTime = currentTime;
        }


        public static Time Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
