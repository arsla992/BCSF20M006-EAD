using StateDesignPattern;

public class DocumentEditing
{
    static void Main()
    {
        // Creating a document editor
        DocumentEditor documentEditor = new DocumentEditor();

        // Performing actions in different states
        documentEditor.PerformEdit();
        documentEditor.PerformSelect();

        // Changing the state
        documentEditor.SetState(new DrawState());

        // Performing actions in the new state
        documentEditor.PerformDraw();
        documentEditor.PerformEdit();
    }
}
