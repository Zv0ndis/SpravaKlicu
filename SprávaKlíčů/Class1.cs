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

        public void PreviewKlíčeKolikZaměstnanců()
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

            // Dictionary to store the list of employees for each key
            Dictionary<string, List<string>> keyEmployees = new Dictionary<string, List<string>>();

            foreach (DataRow row in dt.Rows)
            {
                string keyNumber = row["KeyNumber"].ToString();
                string employeeName = $"{row["EmployeeName"]} {row["EmployeeSurname"]} ({row["EmployeeShortcut"]})";

                // Add employee to the list for the corresponding key
                if (keyEmployees.ContainsKey(keyNumber))
                {
                    if (!keyEmployees[keyNumber].Contains(employeeName))
                    {
                        keyEmployees[keyNumber].Add(employeeName);
                    }
                }
                else
                {
                    keyEmployees[keyNumber] = new List<string> { employeeName };
                }
            }

            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            PrintDocument pd = new PrintDocument();

            pd.PrintPage += (sender, e) =>
            {
                Graphics g = e.Graphics;
                Font font = new Font("Arial", 12);

                float yPos = 0;
                foreach (var kvp in keyEmployees)
                {
                    // Print the key header
                    string keyNumber = kvp.Key;
                    g.DrawString($"Zaměstnanců s klíčem {keyNumber}:", font, Brushes.Black, 50, yPos);
                    yPos += font.GetHeight();

                    // Print employee details for the current key
                    foreach (var employeeName in kvp.Value)
                    {
                        g.DrawString($"   {employeeName}", font, Brushes.Black, 50, yPos);
                        yPos += font.GetHeight();
                    }

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

        public void PreviewKlíčeZaměstnance(int selectedEmployeeId)
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

            PrintDocument pd = new PrintDocument();

            pd.PrintPage += (sender, e) =>
            {
                Graphics g = e.Graphics;
                Font font = new Font("Arial", 12);

                float yPos = 0;

                // Print employee details
                string employeeName = dt.Rows[0]["EmployeeName"].ToString();
                string employeeSurname = dt.Rows[0]["EmployeeSurname"].ToString();
                string employeeShortcut = dt.Rows[0]["EmployeeShortcut"].ToString();
                string employeeDetails = $"{employeeName} {employeeSurname}: počet klíčů {dt.Rows.Count}";
                g.DrawString(employeeDetails, font, Brushes.Black, 50, yPos);
                yPos += font.GetHeight();

                // Dictionary to store the count of each key number
                Dictionary<string, int> keyCounts = new Dictionary<string, int>();

                // Count the occurrences of each key number
                foreach (DataRow row in dt.Rows)
                {
                    string keyNumber = row["KeyNumber"].ToString();
                    if (keyCounts.ContainsKey(keyNumber))
                    {
                        keyCounts[keyNumber]++;
                    }
                    else
                    {
                        keyCounts[keyNumber] = 1;
                    }
                }

                // Output each key number along with its count of occurrences
                foreach (var kvp in keyCounts)
                {
                    string keyOutput = $"{kvp.Value}x Klíč {kvp.Key}";
                    g.DrawString(keyOutput, font, Brushes.Black, 50, yPos);
                    yPos += font.GetHeight();
                }

                // Check if the page can accommodate more rows
                if (yPos + font.GetHeight() > e.MarginBounds.Height)
                {
                    e.HasMorePages = true;
                }
            };

            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            previewDialog.Document = pd;

            if (previewDialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
        }

        public void PreviewVolnéKlíče()
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
