﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace lb567
{
    abstract class Iterator : IEnumerator
    {
        object IEnumerator.Current => Current();

        // Возвращает ключ текущего элемента
        public abstract int Key();

        // Возвращает текущий элемент.
        public abstract object Current();

        // Переходит к следующему элементу.
        public abstract bool MoveNext();

        // Перематывает Итератор к первому элементу.
        public abstract void Reset();
    }

    abstract class IteratorAggregate : IEnumerable
    {
        // Возвращает Iterator или другой IteratorAggregate для реализующего
        // объекта.
        public abstract IEnumerator GetEnumerator();
    }

    class InterpolOrderIterator : Iterator
    {
        private Interpol _collection;

        // Хранит текущее положение обхода. У итератора может быть множество
        // других полей для хранения состояния итерации, особенно когда он
        // должен работать с определённым типом коллекции.
        private int _position = -1;

        private bool _reverse = false;

        public InterpolOrderIterator(Interpol collection, bool reverse = false)
        {
            this._collection = collection;
            this._reverse = reverse;

            if (reverse)
            {
                this._position = collection.getItems().Count;
            }
        }

        public override object Current()
        {
            return this._collection.getItems()[_position];
        }

        public override int Key()
        {
            return this._position;
        }

        public override bool MoveNext()
        {
            int updatedPosition = this._position + (this._reverse ? -1 : 1);

            if (updatedPosition >= 0 && updatedPosition < this._collection.getItems().Count)
            {
                this._position = updatedPosition;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void Reset()
        {
            this._position = this._reverse ? this._collection.getItems().Count - 1 : 0;
        }
    }

    class Interpol : IteratorAggregate
    {

        List<Criminal> _collection = new List<Criminal>();

        bool _direction = false;

        public void ReverseDirection()
        {
            _direction = !_direction;
        }

        public List<Criminal> getItems()
        {
            return _collection;
        }

        public void AddItem(Criminal item)
        {
            this._collection.Add(item);
        }

        public override IEnumerator GetEnumerator()
        {
            return new InterpolOrderIterator(this, _direction);
        }

        public Criminal GetItemByIndex(int index)
        {
            return _collection[index];
        }

        public String GetCriminalInfoByIndex(int index)
        {
            string Status = "";
            if ("Context: Transition to ConcreteStateA." == _collection[index].GetGontext().GetType().ToString())
            {
                Status = _collection[index].GetGontext().Request2();
            }
            Console.WriteLine(_collection[index].GetGontext().GetType());
            return "Name is : " + _collection[index].GetName() + "\n" + "Sername is : " + _collection[index].GetSername() + "\n" + "BDay is : " + _collection[index].GetBDdate() + " \n" + "Wanted status is : " + _collection[index].GetStatus().ToString() ;
        }
    }
}
