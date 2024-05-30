namespace TerminalGuiSandbox
{
    using Terminal.Gui;

    internal class Program
    {
        static void Main(string[] args)
        {
            Application.Run<MainWindow>();
            Application.Shutdown();
        }
    }

    internal class MainWindow:Window
    {
        public MainWindow()
        {
            Title = "First Windows on TerminalGui";

            var aLabel = new Label()
            {
                Text = "Label Example",
                X = 10,
                Y = 10,

            };

            var inputText = new TextField()
            {
                X = 1,
                Y = 2,
                Width = 20,
            };

            var outputText = new TextField()
            {
                ReadOnly = true,
                X = 2,
                Y = 0,
                Width = 40,
            };

            var actionButton = new Button()
            {
                Text = "Do action",
                X = 5,
                Y = 8
            };

            actionButton.Clicked += () =>
            {
                outputText.Text = inputText.Text + " ++++ ";
            };

            Add(aLabel,inputText,outputText,actionButton);
        }
    }
}
