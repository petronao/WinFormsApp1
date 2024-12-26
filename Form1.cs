namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string directoryPath = @"C:\Users\RYZEN5600GT\Downloads\MEmu Download\SnapTube Audio\ffx - Copia";

            // Get all files in the directory
            string[] files = Directory.GetFiles(directoryPath);

            foreach (string filePath in files)
            {
                // Get the file name without the directory path
                string fileName = Path.GetFileName(filePath);

                // Define the new file name
                string newFileName = fileName.Replace("ffx Soundtrack_", "");

                // Combine the directory path with the new file name
                string newFilePath = Path.Combine(directoryPath, newFileName);

                // Rename the file
                File.Move(filePath, newFilePath);
            }

            Console.WriteLine("Files renamed successfully.");
        }
    
    }
}
