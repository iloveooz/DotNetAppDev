﻿using System;
using Android.Content;
using Android.Text;
using Android.Views;
using Android.Views.InputMethods;
using Android.Widget;
using JavaObj = Java.Lang.Object;
using AppStrings = AppDevUnited.TwitterSearches.App.Resource.String;
using Uri = Android.Net.Uri;

namespace AppDevUnited.TwitterSearches.App
{
   public partial class MainActivity
   {
      private void OnTextChanged(object sender, TextChangedEventArgs e) => UpdateSaveFab();

      /// <summary>
      ///    Сохраняет пару "тэг-запрос" в SharedPreferences
      /// </summary>
      private sealed class SaveButtonClickListener : JavaObj, View.IOnClickListener
      {
         private readonly MainActivity _activity;

         public SaveButtonClickListener(MainActivity activity) => _activity = activity;

         public void OnClick(View view)
         {
            var query = _activity._queryEditText.Text;
            var tag = _activity._tagEditText.Text;

            if (!string.IsNullOrEmpty(query) && !string.IsNullOrEmpty(tag))
            {
               // Скрыть экранную клавиатуру
               if (_activity.GetSystemService(InputMethodService) is InputMethodManager inputMethodManager)
                  inputMethodManager.HideSoftInputFromWindow(view.WindowToken, HideSoftInputFlags.None);

               AddTaggedSearch(tag, query); // Добавить/обновить запрос
               _activity._queryEditText.Text = _activity._tagEditText.Text = string.Empty;
               _activity._queryEditText.RequestFocus();
            }
         }

         /// <summary>
         ///    Добавление нового запроса с обновлением всех кнопок
         /// </summary>
         /// <param name="tag">Тэг</param>
         /// <param name="query">Запрос</param>
         private void AddTaggedSearch(string tag, string query)
         {
            // Получение SharedPreferences.Editor для сохранения новой пары
            var preferencesEditor = _activity._savedSearches.Edit();
            preferencesEditor.PutString(tag, query); // Сохранение текущего запроса
            preferencesEditor.Apply(); // Сохранение обновленных настроек

            // Если тэг новый, добавить его, отсортировать и вывести список
            if (!_activity._tags.Contains(tag))
            {
               _activity._tags.Add(tag); // Добавить новый тэг
               _activity._tags.Sort(StringComparer.CurrentCultureIgnoreCase);
               _activity._adapter.NotifyDataSetChanged(); // Обновление тэгов в RecyclerView
            }
         }
      }

      /// <summary>
      ///    Запускает браузер для вывода результатов поиска
      /// </summary>
      private sealed class SearchTagItemClickListener : JavaObj, View.IOnClickListener
      {
         private readonly MainActivity _activity;

         public SearchTagItemClickListener(MainActivity activity) => _activity = activity;

         public void OnClick(View view)
         {
            // Получение строки запроса и создание URL для этого запроса
            if (!(view is TextView textView))
               return;

            var tag = textView.Text;
            var urlString =
               $"{_activity.GetString(AppStrings.search_URL)}{Uri.Encode(_activity._savedSearches.GetString(tag, string.Empty), "UTF-8")}";

            // Создание интента для запуска браузера
            var webIntent = new Intent(Intent.ActionView, Uri.Parse(urlString));
            _activity.StartActivity(webIntent); // Вывести результаты в браузер
         }
      }
   }
}