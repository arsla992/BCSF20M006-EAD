namespace TemplateDesignPattren
{
    class Coffee : BeverageTemplate
    {
        protected override void Brew()
        {
            Console.WriteLine("Brewing coffee grounds");
        }
        protected override void AddCondiments()
        {
            Console.WriteLine("Adding sugar and milk");
        }
    }
}
