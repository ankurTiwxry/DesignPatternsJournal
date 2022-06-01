// ------------------------ Memento Design Pattern --------------------------------
// Problem Statement
// 1. Here I am trying to implement a way to track the content inside a text editor 
// 2. I need to be able to undo to a previous state
//
// This class is the CARETAKER
// --------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace DesignPatterns.Memento
{
    class EditorHistory
    {
        // variables
        // list of states
        private List<EditorState> states = new List<EditorState>();

        public void push(EditorState state)
        {
            states.Add(state);
        }

        public EditorState pop()
        {
            var lastIndex = states.Count - 1;
            var lastState = states[lastIndex];
            states.Remove(lastState);

            return lastState;
        }
    }
}
