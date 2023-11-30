namespace TemplateDesignPattren
{
    abstract class PageTemplate
    {
        public void GeneratePage()
        {
            DisplayHeader();
            DisplayContent();
            DisplayFooter();
        }

        // These steps are common across all pages
        private void DisplayHeader()
        {
            Console.WriteLine("Displaying Header");
        }

        private void DisplayFooter()
        {
            Console.WriteLine("Displaying Footer");
        }

        protected abstract void DisplayContent();
    }
}
