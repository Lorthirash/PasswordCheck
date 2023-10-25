using ExcelDataReader;

namespace PasswordCheckDemo
{
    internal class ReadFile : IReadFile
    {
        public void ReadExcelFile(string filePath)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            using (var reader = ExcelReaderFactory.CreateReader(stream, new ExcelReaderConfiguration()
            {
                FallbackEncoding = System.Text.Encoding.GetEncoding(1252)
            }))
            {
               
                ConsoleOutputPrinter.PrintResults(reader);
            }
        }
    }
}
