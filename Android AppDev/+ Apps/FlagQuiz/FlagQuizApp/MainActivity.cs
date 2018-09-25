﻿using System;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Content.Res;
using Android.OS;
using Android.Preferences;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using R = AppDevUnited.FlagQuizApp.Resource;
using JavaObj = Java.Lang.Object;
using JavaCls = Java.Lang.Class;
using Orientation = Android.Content.Res.Orientation;
using Toolbar = Android.Support.V7.Widget.Toolbar;

namespace AppDevUnited.FlagQuizApp
{
   /// <summary>
   ///    Управляет фрагментом <see cref="MainActivityFragment" /> на телефоне и фрагментом
   ///    <see cref="MainActivityFragment" /> и <see cref="SettingsActivityFragment" />
   ///    на планшете
   /// </summary>
   [Activity(Label = "FlagQuizApp", MainLauncher = true)]
   public class MainActivity : AppCompatActivity
   {
      // Ключи для чтения данных из SharedPreferences
      private const string Choices = "pref_numberOfChoices";
      private const string Regions = "pref_regionsToInclude";
      private const string QuizFragmentTag = "quizFragment";

      private bool _phoneDevice = true; // Включение портретного режима
      private bool _preferencesChanged = true; // Настройки изменились

      protected override void OnCreate(Bundle savedInstanceState)
      {
         base.OnCreate(savedInstanceState);
         SetContentView(R.Layout.Main);

         var toolbar = FindViewById<Toolbar>(R.Id.action_bar);
         SetSupportActionBar(toolbar);

         // Задание знчений про умолчанию в файле SharedPreferences
         PreferenceManager.SetDefaultValues(this, R.Xml.preferences, false);

         // Регистрация слушателя для изменений SharedPreferences
         ISharedPreferencesOnSharedPreferenceChangeListener preferencesChangeListener =
            new DefaultSharedPreferenceChangeListener(this);
         var sharedPreferences = PreferenceManager.GetDefaultSharedPreferences(this);
         sharedPreferences.RegisterOnSharedPreferenceChangeListener(preferencesChangeListener);

         // Определение размера экрана
         var screenSize = Resources.Configuration.ScreenLayout & ScreenLayout.SizeMask;

         // Для планшетного утройства phoneDevice присваивается false
         if (screenSize == ScreenLayout.SizeLarge || screenSize == ScreenLayout.SizeXlarge)
            _phoneDevice = false; // Не соответствует размерам телефона

         // На телефоне разрешена только портретная ориентация
         if (_phoneDevice)
            RequestedOrientation = ScreenOrientation.Portrait;
      }

      protected override void OnStart()
      {
         base.OnStart();

         if (_preferencesChanged)
         {
            // После задания настроек по умолчанию инициализировать MainActivityFragment и запустить викторину            
            var quizFragment = (MainActivityFragment) SupportFragmentManager.FindFragmentByTag(QuizFragmentTag);
            quizFragment.UpdateGuessRows(PreferenceManager.GetDefaultSharedPreferences(this));
            quizFragment.UpdateRegions(PreferenceManager.GetDefaultSharedPreferences(this));
            quizFragment.ResetQuiz();
            _preferencesChanged = false;
         }
      }

      public override bool OnCreateOptionsMenu(IMenu menu)
      {
         // Получение текущей ориентации устройства
         var orientation = Resources.Configuration.Orientation;

         // Отображение меню приложения только в портретной ориентации
         if (orientation == Orientation.Portrait)
         {
            MenuInflater.Inflate(R.Menu.menu_main, menu);
            return true;
         }

         return false;
      }

      public override bool OnOptionsItemSelected(IMenuItem item)
      {
         var preferencesIntent = new Intent(this, JavaCls.ForName(nameof(SettingsActivity)));
         StartActivity(preferencesIntent);

         return base.OnOptionsItemSelected(item);
      }

      #region Слушатель изменений конфигурации SharedPreferences приложения

      private sealed class DefaultSharedPreferenceChangeListener
         : JavaObj, ISharedPreferencesOnSharedPreferenceChangeListener
      {
         private readonly MainActivity _activity;

         public DefaultSharedPreferenceChangeListener(MainActivity activity)
            => _activity = activity;

         public void OnSharedPreferenceChanged(ISharedPreferences sharedPreferences, string key)
         {
            _activity._preferencesChanged = true; // Пользователь изменил настройки

            var quizFragment =
               (MainActivityFragment) _activity.SupportFragmentManager.FindFragmentByTag(QuizFragmentTag);
            if (key.Equals(Choices, StringComparison.Ordinal))
            {
               // Изменилось число вариантов
               quizFragment.UpdateGuessRows(sharedPreferences);
               quizFragment.ResetQuiz();
            }
            else if (key.Equals(Regions, StringComparison.Ordinal))
            {
               // Изменились регионы
               var regions = sharedPreferences.GetStringSet(Regions, null);
               if (regions != null)
               {
                  if (regions.Count > 0)
                  {
                     quizFragment.UpdateRegions(sharedPreferences);
                     quizFragment.ResetQuiz();
                  }
                  else
                  {
                     // Хотя бы один регион - по умолчанию Северная Америка
                     var editor = sharedPreferences.Edit();
                     regions.Add(_activity.GetString(R.String.default_region));
                     editor.PutStringSet(Regions, regions);
                     editor.Apply();

                     Toast.MakeText(_activity, R.String.default_region_message, ToastLength.Short).Show();
                  }
               }
            }

            Toast.MakeText(_activity, R.String.restarting_quiz, ToastLength.Short).Show();
         }
      }

      #endregion
   }
}