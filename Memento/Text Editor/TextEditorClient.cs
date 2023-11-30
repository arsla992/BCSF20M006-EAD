using System;
using System.Collections.Generic;

// Memento
public class EditorMemento
{
    public string Content { get; }

    public EditorMemento(string content)
    {
        Content = content;
    }
}

// Originator
public class TextEditor
{
    private string content;

    public string Content
    {
        get { return content; }
        set { content = value; }
    }

    public EditorMemento CreateMemento()
    {
        return new EditorMemento(content);
    }

    public void RestoreMemento(EditorMemento memento)
    {
        content = memento.Content;
    }

    public void PrintContent()
    {
        Console.WriteLine($"Current Content: {content}");
    }
}

// Caretaker
public class History
{
    private List<EditorMemento> mementos = new List<EditorMemento>();

    public void SaveMemento(EditorMemento memento)
    {
        mementos.Add(memento);
    }

    public EditorMemento GetMemento(int index)
    {
        return mementos[index];
    }
}

// Client
public class TextEditorClient
{
    public static void Main(string[] args)
    {
        // Creating a text editor and history
        TextEditor textEditor = new TextEditor();
        History history = new History();

        // Editing and saving states
        textEditor.Content = "Version 1";
        history.SaveMemento(textEditor.CreateMemento());
        textEditor.PrintContent();

        textEditor.Content = "Version 2";
        history.SaveMemento(textEditor.CreateMemento());
        textEditor.PrintContent();

        // Undoing to previous state
        textEditor.RestoreMemento(history.GetMemento(0));
        textEditor.PrintContent();

        // Redoing to the latest state
        textEditor.RestoreMemento(history.GetMemento(1));
        textEditor.PrintContent();
    }
}
