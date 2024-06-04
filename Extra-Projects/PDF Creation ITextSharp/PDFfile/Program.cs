using iTextSharp.text;
using iTextSharp.text.pdf;

namespace PDFfile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Please enter the surname: ");
            var surname = Console.ReadLine();
            Console.WriteLine("Please enter the email address");
            var email = Console.ReadLine();
            Console.WriteLine("Enter your income amount");
            var income = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your expenses");
            var expenses = double.Parse(Console.ReadLine());

            var createUser = new User(name, surname, email);

            var profit = income - expenses;

            var calculation = new Calculations(income, expenses, profit);

            Console.WriteLine("Please enter 1 to create pdf");
            if (Console.ReadLine() == "1")
            {
                GeneratePdf(createUser, calculation);
            }
        }

        public static void GeneratePdf(User user, Calculations calculations)
        {
            var document = new Document();
            var outputPath = $"C:\\Users\\Tristan\\Documents\\Projects\\PDF Creation ITextSharp\\PDFfile\\pdf\\{user.Name}.pdf";

            PdfWriter.GetInstance(document, new FileStream(outputPath, FileMode.Create));

            document.Open();

            CreatingUserInformation(user, document);

            AddingTable(calculations, document);

            AddingImage(document);

            document.Close();
        }

        private static void AddingImage(Document document)
        {
            var image1Path = "C:\\Users\\Tristan\\Desktop\\PDF Creation\\PDFfile\\4223289.jpg";

            var image1 = Image.GetInstance(image1Path);

            var pageWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin;
            image1.ScaleAbsoluteWidth(pageWidth);

            var height = 150f;
            image1.ScaleAbsoluteHeight(height);

            document.Add(image1);
        }

        private static void AddingTable(Calculations calculations, Document document)
        {
            var table = new PdfPTable(3);
            var cell = new PdfPCell(new Phrase("Calculations"));

            cell.Colspan = 3;
            cell.HorizontalAlignment = 1;
            table.AddCell(cell);
            table.AddCell($"Income: R{calculations.Income}");
            table.AddCell($"Expenses: R{calculations.Expense}");
            table.AddCell($"Profit: R{calculations.Profit}");

            float[] columnWidths = { 2f, 2f, 2f };
            table.SetWidths(columnWidths);

            table.SpacingBefore = 20f;
            table.SpacingAfter = 50f;
            document.Add(table);
        }

        private static void CreatingUserInformation(User user, Document document)
        {
            var font = new Font();
            font.Size = 16f;
            font.SetStyle(Font.UNDERLINE | Font.BOLD);

            var paragraph = new Paragraph("User Information", font);
            document.Add(paragraph);

            var userDetailsFont = new Font();
            userDetailsFont.Size = 12f;

            paragraph = new Paragraph();
            paragraph.Font = userDetailsFont;
            paragraph.Add(" \n \n");
            paragraph.Add("Name: " + user.Name);
            paragraph.Add("\nSurname: " + user.Surname);
            paragraph.Add("\nEmail: " + user.EmailAddress);
            paragraph.Add("\n \n");
            document.Add(paragraph);
        }
    }
}