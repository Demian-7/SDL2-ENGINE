﻿//using System.Collections.Generic;

//namespace MyGame.Scripts.Components
//{
//    public class AnimatorComponent
//    {
//        private string name;
//        private List<Image> textures;
//        private int currentFrameIndex = 0;
//        private float speed = 0.5f;
//        private float currentAnimationTime;
//        private bool isLoopEnabled;


//        public int FramesCount => textures.Count;
//        public int CurrentFrameIndex => currentFrameIndex;

//        public Image CurrentFrame => textures[currentFrameIndex];

//        public AnimatorComponent(string name, List<Image> frames, float speed, bool isLoopEnabled)
//        {
//            this.name = name;
//            this.textures = frames;
//            this.speed = speed;
//            this.isLoopEnabled = isLoopEnabled;
//        }


//        public void Update()
//        {
//            currentAnimationTime += Time.DeltaTime;

//            if (currentAnimationTime > speed)
//            {
//                currentFrameIndex++;
//                currentAnimationTime = 0;

//                if (currentFrameIndex >= textures.Count)
//                {
//                    if (isLoopEnabled)
//                    {
//                        currentFrameIndex = 0;
//                    }
//                    else
//                    {
//                        currentFrameIndex = textures.Count - 1;
//                    }
//                }
//            }
//        }
//    }
//}
