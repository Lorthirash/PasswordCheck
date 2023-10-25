using PasswordCheckDemo;

string excelFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "prog-feladat-jelsz.xlsx");

ReadFile excelFile = new ReadFile();
excelFile.ReadExcelFile(excelFilePath);