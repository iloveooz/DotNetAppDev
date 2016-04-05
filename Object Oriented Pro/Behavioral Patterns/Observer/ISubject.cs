﻿namespace Observer
{
   /// <summary>
   /// Интерфейс субъекта
   /// </summary>
   /// <typeparam name="T">Тип состояния</typeparam>
   public interface ISubject<T>
   {
      bool Add(IObserver<T> observer);

      void Add(params IObserver<T>[] observers);

      bool Remove(IObserver<T> observer);

      void Notify(T state);
   }
}