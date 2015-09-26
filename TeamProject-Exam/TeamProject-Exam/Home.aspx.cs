using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace TeamProject_Exam
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader reader = new StreamReader(ConfigurationManager.AppSettings["FilePath"]))
                {
                }
                onLoad.Text = "Welcome!";
            }
            catch (Exception)
            {
                onLoad.Text="File not loaded!";
            }




        }

        protected void add_Click(object sender, EventArgs e)
        {

            Data toAdd = new Data();
            toAdd.Date = dateText.Text;
            toAdd.Item = productText.Text;
            toAdd.Price = double.Parse(priceText.Text);
            using (StreamWriter writer = new StreamWriter(ConfigurationManager.AppSettings["FilePath"], true))
            {
                writer.WriteLine(toAdd);
            }
        }

        protected void calcBtn_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader(ConfigurationManager.AppSettings["FilePath"]);
            double total = 0;
            string line = reader.ReadLine();
            string[] values = line.Split('|');
            if (dropDown.SelectedIndex == 1)
            {


                values = line.Split('|');
                do
                {
                    if (DateTime.Now.AddDays(-7) < DateTime.Parse(values[0]))
                    {
                        total += double.Parse(values[2]);
                    }
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        values = line.Split('|');
                    }
                } while (line != null);
                result.Text = total.ToString();

            }




            else if (dropDown.SelectedIndex == 2)
            {

                values = line.Split('|');
                do
                {
                    if (DateTime.Now.AddDays(-30) < DateTime.Parse(values[0]))
                    {
                        total += double.Parse(values[2]);
                    }
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        values = line.Split('|');
                    }
                } while (line != null);
                result.Text = total.ToString();

            }
            else if (dropDown.SelectedIndex == 3)
            {
                values = line.Split('|');
                do
                {
                    if (DateTime.Now.AddDays(-365) < DateTime.Parse(values[0]))
                    {
                        total += double.Parse(values[2]);
                    }
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        values = line.Split('|');
                    }
                } while (line != null);
                result.Text = total.ToString();
            }
            reader.Close();
        }
    }
}