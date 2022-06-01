// ------------------------ Memento Design Pattern --------------------------------
// Problem Statement
// 1. Here I am trying to implement a way to track the content inside a text editor 
// 2. I need to be able to undo to a previous state
//
// This class is the MEMENTO
// --------------------------------------------------------------------------------

using System;

namespace DesignPatterns.Memento
{
    public class EditorState
    {
        // variables
        private readonly string m_content;

        // ctor
        public EditorState(String content)
        {
            this.m_content = content;
        }

        public String getContent()
        {
            return this.m_content;
        }
    }
}
