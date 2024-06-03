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
                X = 1,
                Y = 1,

            };

            var inputText = new TextField()
            {
                X = 30,
                Y = 1,
                Width = 20,
            };

            var outputText = new TextField()
            {
                ReadOnly = true,
                X = 30,
                Y = 3,
                Width = 40,
            };

            var textView = new TextView()
            {
                X = 9,
                Y = 10,
                Width = 40,
                Height = 10,
                Multiline = true
                
            };

            var scrollView = new ScrollView() { AutoHideScrollBars = false,
                X = 9,
                Y = 10,
                Width = 40,
                Height = 10,
                Visible = true,
                ContentSize = new Size(10, 20)
            };
            scrollView.Add(textView);


            var actionButton = new Button()
            {
                Text = "Do action",
                X = 5,
                Y = 8
            };

            actionButton.Clicked += () =>
            {
                outputText.Text = inputText.Text + " ++++ ";
                textView.Text = textView.Text  + outputText.Text + @"\n\r";
            };

            Add(aLabel,inputText,outputText,scrollView, actionButton);
        }
    }
}
