﻿using System;
using Android.Content;
using Android.Util;
using Android.Views;

namespace AppDevUnited.CannonGame.App
{
   public class CannonView : SurfaceView
   {
      // TODO: Эти элементы лучше сделать enum'ами
      public static int BlockerSoundId;
      public static int TargetSoundId;
      public static int CannonBallSpeedPercent;
      public static int CannonSoundId;

      public CannonView(Context context, IAttributeSet attrs)
         : base(context, attrs)
      {
      }      

      public void StopGame()
      {
         throw new NotImplementedException();
      }

      public void ReleaseResources()
      {
         throw new NotImplementedException();
      }

      public void PlaySound(int soundId)
      {
         throw new NotImplementedException();
      }
   }
}