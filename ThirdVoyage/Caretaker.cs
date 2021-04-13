using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdVoyage
{
    public class CareTaker
    {
        private List<Memento> mementoList = new List<Memento>();
        private Stack<Memento> mStack = new Stack<Memento>();

        //adds memento
        public void add(Memento state)
        {
            mementoList.Add(state);
            mStack.Push(state);
        }


        //gets last memento
        public Memento getMemento()
        {
            return mStack.Pop();
        }

    }

 }
