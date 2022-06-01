// ------------------------ Memento Design Pattern --------------------------------
// Problem Statement
// 1. Here I am trying to implement a way to track the content inside a text editor 
// 2. I need to be able to undo to a previous state
//
// This class is the ORIGINATOR
// --------------------------------------------------------------------------------

using System;

namespace DesignPatterns.Memento
{
    class Editor
    {
        // variables
        private String m_content;

        // functions

        public EditorState createState()
        {
            return new EditorState(m_content);
        }

        public void restoreState(EditorState state)
        {
            this.m_content = state.getContent();  
        }


        // getters and setters

        public String getContent()
        {
            return this.m_content;
        }

        public void setContent(String content)
        {
            this.m_content = content;
        }
    }
}
