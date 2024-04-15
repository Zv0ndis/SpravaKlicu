using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;


namespace SprávaKlíčů
{
    public class PrinterManager
    {
        public void PrintEmployees(DataTable dt)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += (sender, e) =>
            {
                Graphics g = e.Graphics;
                Font font = new Font("Arial", 12);

                float yPos = 0;
                int count = 0;
                foreach (DataRow row in dt.Rows)
                {
                    foreach (DataColumn col in dt.Columns)
                    {
                        g.DrawString(row[col].ToString(), font, Brushes.Black, 50, yPos);
                        yPos += font.GetHeight();
                    }
                    yPos += 20; // Adding some space between rows
                    count++;

                    // Check if the page can accommodate more rows
                    if (count * font.GetHeight() > e.MarginBounds.Height)
                    {
                        e.HasMorePages = true;
                        return;
                    }
                }
            };

            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            previewDialog.Document = pd;

            if (previewDialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
        }

        public void PreviewEmployeesWithBorrowedKeys()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(Data.connectionString))
            {
                string query = @"
            SELECT 
                k.Number AS KeyNumber,
                e.Name AS EmployeeName,
                e.Surname AS EmployeeSurname,
                e.EShortcut AS EmployeeShortcut
            FROM 
                Employees e
            INNER JOIN 
                BorrowedKeys bk ON e.Id = bk.Employee
            INNER JOIN 
                Keys k ON bk.[Key] = k.Id";

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
            }

            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            PrintDocument pd = new PrintDocument();

            pd.PrintPage += (sender, e) =>
            {
                Graphics g = e.Graphics;
                Font font = new Font("Arial", 12);

                string currentKeyNumber = "";
                float yPos = 0;
                foreach (DataRow row in dt.Rows)
                {
                    string keyNumber = row["KeyNumber"].ToString();
                    string employeeName = row["EmployeeName"].ToString();
                    string employeeSurname = row["EmployeeSurname"].ToString();
                    string employeeShortcut = row["EmployeeShortcut"].ToString();

                    if (keyNumber != currentKeyNumber)
                    {
                        // Print the key header if it's a new key
                        if (currentKeyNumber != "")
                        {
                            yPos += 20; // Add space between keys
                        }
                        g.DrawString($"Klíč: {keyNumber}", font, Brushes.Black, 50, yPos);
                        yPos += font.GetHeight();
                        currentKeyNumber = keyNumber;
                    }

                    // Print the employee details
                    string employeeDetails = $"   {employeeName} {employeeSurname} ({employeeShortcut})";
                    g.DrawString(employeeDetails, font, Brushes.Black, 50, yPos);
                    yPos += font.GetHeight();
                }

                // Check if the page can accommodate more rows
                if (yPos + font.GetHeight() > e.MarginBounds.Height)
                {
                    e.HasMorePages = true;
                }
            };

            previewDialog.Document = pd;

            if (previewDialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
        }

        public void PreviewKeysWithEmployee(int selectedEmployeeId)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(Data.connectionString))
            {
                string query = @"
            SELECT 
                k.Number AS KeyNumber,
                k.TypeOfRoom AS KeyType,
                k.DoorSign AS KeyDoorSign,
                e.Name AS EmployeeName,
                e.Surname AS EmployeeSurname,
                e.EShortcut AS EmployeeShortcut,
                bk.DateOfBorrow AS DateOfBorrow
            FROM 
                Keys k
            INNER JOIN 
                BorrowedKeys bk ON k.Id = bk.[Key]
            INNER JOIN 
                Employees e ON bk.Employee = e.Id
            WHERE 
                e.Id = @EmployeeId"; // Filter based on the employee's ID

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@EmployeeId", selectedEmployeeId);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
            }

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No keys borrowed by the selected employee.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            PrintDocument pd = new PrintDocument();

            pd.PrintPage += (sender, e) =>
            {
                Graphics g = e.Graphics;
                Font font = new Font("Arial", 12);

                float yPos = 0;
                foreach (DataRow row in dt.Rows)
                {
                    // Print employee name
                    string employeeName = $"{row["EmployeeName"]} {row["EmployeeSurname"]} ({row["EmployeeShortcut"]})";
                    g.DrawString($"Zaměstnanec: {employeeName}", font, Brushes.Black, 50, yPos);
                    yPos += font.GetHeight();

                    // Print key details
                    string keyNumber = row["KeyNumber"].ToString();
                    g.DrawString($"    Klíč {keyNumber}", font, Brushes.Black, 50, yPos);
                    yPos += font.GetHeight();

                    yPos += 20; // Add space between keys
                }

                // Check if the page can accommodate more rows
                if (yPos + font.GetHeight() > e.MarginBounds.Height)
                {
                    e.HasMorePages = true;
                }
            };

            previewDialog.Document = pd;

            if (previewDialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
        }

        public void PreviewAvailableKeys()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(Data.connectionString))
            {
                string query = @"
        SELECT 
            k.Number AS KeyNumber,
            k.TypeOfRoom AS KeyType,
            k.DoorSign AS KeyDoorSign,
            (k.HowManyMade - ISNULL(k.HowManyBorrowed, 0)) AS FreeKeys,
            k.HowManyMade AS TotalKeys
        FROM 
            Keys k";

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
            }

            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            PrintDocument pd = new PrintDocument();

            pd.PrintPage += (sender, e) =>
            {
                Graphics g = e.Graphics;
                Font font = new Font("Arial", 12);

                float yPos = 0;
                int count = 0;
                foreach (DataRow row in dt.Rows)
                {
                    string keyNumber = row["KeyNumber"].ToString();
                    int freeKeys = Convert.ToInt32(row["FreeKeys"]);
                    int totalKeys = Convert.ToInt32(row["TotalKeys"]);

                    // Format the key in the desired way
                    string formattedKey = $"Klíč {keyNumber}: {freeKeys} / {totalKeys}";

                    // Draw the formatted key
                    g.DrawString(formattedKey, font, Brushes.Black, 50, yPos);
                    yPos += font.GetHeight();

                    yPos += 20; // Adding some space between keys
                    count++;

                    // Check if the page can accommodate more rows
                    if (count * font.GetHeight() > e.MarginBounds.Height)
                    {
                        e.HasMorePages = true;
                        return;
                    }
                }
            };

            previewDialog.Document = pd;

            if (previewDialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
        }

    }
}
