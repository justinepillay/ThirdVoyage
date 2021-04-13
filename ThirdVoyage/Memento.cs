using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdVoyage
{

    // memento class, duh
    public class Memento
    {
        private String state;

        public Memento(String state)
        {
            this.state = state;
        }

        public String getState()
        {
            return state;
        }
    }

}
